using GSF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;

namespace HR_Management
{
    public partial class EmployeeDetailsForm : Form
    {
        private enum SearchField
        {
            None,
            EmpID,
            FullName,
            Department,
            Location,
            Position,
            Salary
        }

        private SearchField _currentSearchField = SearchField.None;
        private Label lblSearchHint;
        private ContextMenuStrip _searchByMenu;

        // Add these private fields to the EmployeeDetailsForm class to fix CS1061
        private HR_Management_DatasetTableAdapters.tblEmployeesTableAdapter tblEmployeesTableAdapter = new HR_Management_DatasetTableAdapters.tblEmployeesTableAdapter();
        private HR_Management_DatasetTableAdapters.tblPositionsTableAdapter tblPositionsTableAdapter = new HR_Management_DatasetTableAdapters.tblPositionsTableAdapter();
        private HR_Management_DatasetTableAdapters.tblDepartmentsTableAdapter tblDepartmentsTableAdapter = new HR_Management_DatasetTableAdapters.tblDepartmentsTableAdapter();

        public EmployeeDetailsForm()
        {
            InitializeComponent();
        }

        private void EmployeeDetailsForm_Load(object sender, EventArgs e)
        {
            // Ensure dataset tables loaded for joins and UI initialization
            this.tblEmployeesTableAdapter?.Fill(this.hR_Management_Dataset.tblEmployees);
            this.tblPositionsTableAdapter?.Fill(this.hR_Management_Dataset.tblPositions);
            this.tblDepartmentsTableAdapter?.Fill(this.hR_Management_Dataset.tblDepartments);

            // IMPORTANT: make the TableAdapterManager aware of the other adapters so UpdateAll
            // can insert/update rows in the correct order (employees first, then details).
            // Without this, UpdateAll may only call the EmployeeDetails adapter and
            // inserting a detail that references a non-existing EmpID will fail the FK.
            this.tableAdapterManager.tblEmployeesTableAdapter = this.tblEmployeesTableAdapter;
            this.tableAdapterManager.tblPositionsTableAdapter = this.tblPositionsTableAdapter;
            this.tableAdapterManager.tblDepartmentsTableAdapter = this.tblDepartmentsTableAdapter;
            // tblEmployeeDetailsTableAdapter is already assigned by designer.

            // Load employee details from DB initially
            this.tblEmployeeDetailsTableAdapter.Fill(this.hR_Management_Dataset.tblEmployeeDetails);

            currentPosition();
            SetFieldsReadOnly(true);

            // Controls that should bypass validation to always respond
            btnCancel.CausesValidation = false;
            btnExit.CausesValidation = false;
            btnPrevious.CausesValidation = false;
            btnNext.CausesValidation = false;
            btnFirst.CausesValidation = false;
            btnLast.CausesValidation = false;
            btnDelete.CausesValidation = false;
            btnCancelAll.CausesValidation = false;

            // Allow users to leave numeric fields with non-numeric input — save-time validation will catch errors
            empIDTextBox.CausesValidation = false;
            salaryTextBox.CausesValidation = false;

            // Wire up button events (designer may not have)
            btnNew.Click += btnNew_Click;
            btnDelete.Click += btnDelete_Click;
            btnSave.Click += btnSave_Click;
            btnEdit.Click += btnEdit_Click;
            btnCancel.Click += btnCancel_Click;
            btnPrevious.Click += btnPrevious_Click;
            btnNext.Click += btnNext_Click;
            btnFirst.Click += btnFirst_Click;
            btnLast.Click += btnLast_Click;
            btnExit.Click += btnExit_Click;
            btnLoad.Click += btnLoad_Click;
            btnCancelAll.Click += btnCancelAll_Click;
            btnSearch.Click += btnSearch_Click;
            btnSearchBy.Click += btnSearchBy_Click;

            // Initially disable the search text box until a criteria is selected via Search by...
            textBoxSearch.Text = string.Empty;
            textBoxSearch.Enabled = false;

            // Create label above search box that indicates the currently chosen criteria (or instructs to choose one)
            lblSearchHint = new Label
            {
                AutoSize = true,
                Text = "Click on 'Search by...'",
                Location = new Point(textBoxSearch.Left, textBoxSearch.Top - 18),
            };
            this.Controls.Add(lblSearchHint);
            lblSearchHint.BringToFront();

            // Build context menu for Search by...
            _searchByMenu = new ContextMenuStrip();
            _searchByMenu.Items.Add("Emp ID").Tag = SearchField.EmpID;
            _searchByMenu.Items.Add("Full Name").Tag = SearchField.FullName;
            _searchByMenu.Items.Add("Department").Tag = SearchField.Department;
            _searchByMenu.Items.Add("Location").Tag = SearchField.Location;
            _searchByMenu.Items.Add("Position").Tag = SearchField.Position;
            _searchByMenu.Items.Add("Salary").Tag = SearchField.Salary;
            foreach (ToolStripItem it in _searchByMenu.Items)
            {
                it.Click += SearchByMenuItem_Click;
            }
        }

        private void SearchByMenuItem_Click(object sender, EventArgs e)
        {
            if (!(sender is ToolStripItem tsi)) return;
            var field = (SearchField)(tsi.Tag ?? SearchField.None);
            _currentSearchField = field;

            // update label and clear previous filter
            lblSearchHint.Text = (_currentSearchField == SearchField.None)
                ? "Choose search criteria first (click Search by...)"
                : $"Enter value for: {_currentSearchField}";

            // Clear previous search text when changing criteria
            textBoxSearch.Text = string.Empty;
            // Enable search box only when a concrete criteria is chosen
            textBoxSearch.Enabled = (_currentSearchField != SearchField.None);
            // Reset grid filter if present
            ClearSearchFilter();

            if (textBoxSearch.Enabled)
                textBoxSearch.Focus();
            else
                btnSearchBy.Focus();
        }

        private void btnSearchBy_Click(object sender, EventArgs e)
        {
            // Show the context menu adjacent to the button
            _searchByMenu.Show(btnSearchBy, new Point(0, btnSearchBy.Height));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void DoSearch()
        {
            if (_currentSearchField == SearchField.None)
            {
                // Search box is disabled until a criteria is chosen — focus the Search by button.
                btnSearchBy.Focus();
                return;
            }

            var raw = (textBoxSearch.Text ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(raw))
            {
                // Empty search — reset filter and show all
                ClearSearchFilter();
                return;
            }

            try
            {
                string filter = BuildFilter(_currentSearchField, raw);
                // Apply filter to BindingSource (works with DataTable as data source)
                tblEmployeeDetailsBindingSource.Filter = filter;
                currentPosition();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Search error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string BuildFilter(SearchField field, string raw)
        {
            // Escape single quotes for RowFilter
            string Escape(string s) => s.Replace("'", "''");

            switch (field)
            {
                case SearchField.EmpID:
                    // Allows partial matching on the numeric EmpID by converting to string
                    return $"Convert(EmpID, 'System.String') LIKE '%{Escape(raw)}%'";

                case SearchField.FullName:
                    return $"FullName LIKE '%{Escape(raw)}%'";

                case SearchField.Department:
                    return $"Department LIKE '%{Escape(raw)}%'";

                case SearchField.Location:
                    return $"Location LIKE '%{Escape(raw)}%'";

                case SearchField.Position:
                    return $"Position LIKE '%{Escape(raw)}%'";

                case SearchField.Salary:
                    // Salary special operators: =, !=, >=, <=, >, <
                    string op = null;
                    string valuePart = raw;

                    // detect operators at start
                    string[] operators = new[] { ">=", "<=", "!=", ">", "<", "=" };
                    foreach (var o in operators)
                    {
                        if (raw.StartsWith(o, StringComparison.Ordinal))
                        {
                            op = o;
                            valuePart = raw.Substring(o.Length).Trim();
                            break;
                        }
                    }

                    // default to equality (contains is not meaningful for numeric) — support exact numeric match if no operator
                    if (op == null)
                    {
                        op = "=";
                        valuePart = raw;
                    }

                    if (!decimal.TryParse(valuePart, NumberStyles.Number, CultureInfo.CurrentCulture, out var num))
                    {
                        throw new FormatException("Salary search value is not a valid number for the chosen operator. Use your locale decimal separator.");
                    }

                    // RowFilter expects invariant decimal representation
                    var inv = num.ToString(CultureInfo.InvariantCulture);

                    // Map != to <> for DataColumn expressions
                    if (op == "!=") op = "<>";

                    return $"Salary {op} {inv}";

                default:
                    throw new InvalidOperationException("Unknown search field.");
            }
        }

        private void ClearSearchFilter()
        {
            tblEmployeeDetailsBindingSource.RemoveFilter();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Rebuild employee details rows from the current Employees/Positions/Departments tables
            try
            {
                LoadEmployeeDetailsFromTables();
                MessageBox.Show("EmployeeDetails loaded from Employees/Positions/Departments", "Load Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load failed: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEmployeeDetailsFromTables()
        {
            // Ensure source tables are fresh
            this.tblEmployeesTableAdapter.Fill(this.hR_Management_Dataset.tblEmployees);
            this.tblPositionsTableAdapter.Fill(this.hR_Management_Dataset.tblPositions);
            this.tblDepartmentsTableAdapter.Fill(this.hR_Management_Dataset.tblDepartments);

            // Clear existing detail rows in-memory
            this.hR_Management_Dataset.tblEmployeeDetails.Clear();

            foreach (HR_Management_Dataset.tblEmployeesRow emp in this.hR_Management_Dataset.tblEmployees)
            {
                var detailRow = this.hR_Management_Dataset.tblEmployeeDetails.NewtblEmployeeDetailsRow();
                detailRow.EmpID = emp.EmpID;
                detailRow.FullName = (emp.EmpFirstName ?? string.Empty).Trim() + " " + (emp.EmpLastName ?? string.Empty).Trim();

                // Department + Location from Departments table via DepID
                if (!emp.IsDepIDNull())
                {
                    var dep = this.hR_Management_Dataset.tblDepartments.FindByDepID(emp.DepID);
                    if (dep != null)
                    {
                        detailRow.Department = dep.DepName;
                        if (!dep.IsDepLocationNull())
                            detailRow.Location = dep.DepLocation;
                        else
                            detailRow.SetLocationNull();
                    }
                    else
                    {
                        detailRow.SetDepartmentNull();
                        detailRow.SetLocationNull();
                    }
                }
                else
                {
                    detailRow.SetDepartmentNull();
                    detailRow.SetLocationNull();
                }

                // Position + Salary from Positions table via PosID
                if (!emp.IsPosIDNull())
                {
                    var pos = this.hR_Management_Dataset.tblPositions.FindByPosID(emp.PosID);
                    if (pos != null)
                    {
                        detailRow.Position = pos.PosTitle ?? string.Empty;
                        if (!pos.IsPosSalaryNull())
                        {
                            detailRow.Salary = pos.PosSalary;
                        }
                        else
                        {
                            detailRow.SetSalaryNull();
                        }
                    }
                    else
                    {
                        detailRow.Position = string.Empty;
                        detailRow.SetSalaryNull();
                    }
                }
                else
                {
                    detailRow.Position = string.Empty;
                    detailRow.SetSalaryNull();
                }

                // Add the typed row
                this.hR_Management_Dataset.tblEmployeeDetails.AddtblEmployeeDetailsRow(detailRow);
            }

            // Update binding UI
            tblEmployeeDetailsBindingSource.DataSource = this.hR_Management_Dataset.tblEmployeeDetails;
            tblEmployeeDetailsBindingSource.ResetBindings(false);
            ClearSearchFilter();
            currentPosition();
        }

        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            // Cancel pending edits and reload data from DB
            try
            {
                this.tblEmployeeDetailsBindingSource.CancelEdit();
            }
            catch { /* ignore */ }

            this.tblEmployeeDetailsTableAdapter.Fill(this.hR_Management_Dataset.tblEmployeeDetails);
            ClearSearchFilter();
            SetFieldsReadOnly(true);
            currentPosition();
        }

        // Navigation and CRUD handlers

        private void tblEmployeeDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.tblEmployeeDetailsBindingSource.AddNew();
            SetFieldsReadOnly(false);
            empIDTextBox.Focus();
            currentPosition();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.tblEmployeeDetailsBindingSource.Current == null)
            {
                MessageBox.Show("No record selected to delete.");
                return;
            }

            var dr = MessageBox.Show("Are you sure you want to delete the current employee detail record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr != DialogResult.Yes) return;

            try
            {
                this.tblEmployeeDetailsBindingSource.RemoveCurrent();
                UpdateDatabase();
                MessageBox.Show("The record was deleted successfully.", "Delete Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.tblEmployeeDetailsTableAdapter.Fill(this.hR_Management_Dataset.tblEmployeeDetails);
                currentPosition();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message, "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.tblEmployeeDetailsBindingSource.Current == null)
            {
                MessageBox.Show("No record selected to edit.");
                return;
            }

            SetFieldsReadOnly(false);
            fullNameTextBox.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = btnCancel;
            }
            catch { /* ignore */ }

            try
            {
                this.tblEmployeeDetailsBindingSource.CancelEdit();
            }
            catch { /* ignore */ }

            this.tblEmployeeDetailsTableAdapter.Fill(this.hR_Management_Dataset.tblEmployeeDetails);
            SetFieldsReadOnly(true);
            currentPosition();

            if (tblEmployeeDetailsBindingSource.Count > 0)
                empIDTextBox.Focus();
            else
                btnNew.Focus();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (this.tblEmployeeDetailsBindingSource.Position > 0)
            {
                this.tblEmployeeDetailsBindingSource.MovePrevious();
                currentPosition();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.tblEmployeeDetailsBindingSource.Position < this.tblEmployeeDetailsBindingSource.Count - 1)
            {
                this.tblEmployeeDetailsBindingSource.MoveNext();
                currentPosition();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.tblEmployeeDetailsBindingSource.MoveFirst();
            currentPosition();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.tblEmployeeDetailsBindingSource.MoveLast();
            currentPosition();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void currentPosition()
        {
            int rowNumber = Math.Max(0, tblEmployeeDetailsBindingSource.Count);
            int currentPosition = (tblEmployeeDetailsBindingSource.Position >= 0) ? tblEmployeeDetailsBindingSource.Position + 1 : 0;
            NextPreviousTextBox.Text = currentPosition.ToString() + " / " + rowNumber.ToString();
        }

        private void SaveChanges()
        {
            try
            {
                // Validate required numeric fields before committing
                if (!ValidateFields())
                {
                    return;
                }

                this.Validate();
                this.tblEmployeeDetailsBindingSource.EndEdit();

                UpdateDatabase();

                // Refresh from DB
                this.tblEmployeeDetailsTableAdapter.Fill(this.hR_Management_Dataset.tblEmployeeDetails);
                SetFieldsReadOnly(true);
                currentPosition();

                MessageBox.Show("The EmployeeDetails table was updated successfully.", "Update Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message, "Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFields()
        {
            // EmpID required integer
            var empIdText = (empIDTextBox.Text ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(empIdText))
            {
                MessageBox.Show("EmpID is required and must be a whole number.", "Invalid EmpID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                empIDTextBox.Focus();
                return false;
            }

            if (!int.TryParse(empIdText, NumberStyles.Integer, CultureInfo.CurrentCulture, out int empId))
            {
                MessageBox.Show("EmpID must be a whole number (no letters or symbols).", "Invalid EmpID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                empIDTextBox.Focus();
                return false;
            }

            // Ensure the referenced employee exists in tblEmployees (either loaded or newly added)
            // This prevents the FK conflict when inserting EmployeeDetails referencing a missing EmpID.
            var empRow = this.hR_Management_Dataset.tblEmployees.FindByEmpID(empId);
            if (empRow == null)
            {
                MessageBox.Show($"EmpID {empId} does not exist in Employees. Create the employee first (Employees form) or add the employee row before saving EmployeeDetails.", "Missing Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                empIDTextBox.Focus();
                return false;
            }

            // Salary optional but if provided must be decimal
            var salaryText = (salaryTextBox.Text ?? string.Empty).Trim();
            if (!string.IsNullOrEmpty(salaryText))
            {
                if (!decimal.TryParse(salaryText, NumberStyles.Number, CultureInfo.CurrentCulture, out _))
                {
                    MessageBox.Show("Salary must be a valid decimal number. Use your locale's decimal separator.", "Invalid Salary", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salaryTextBox.Focus();
                    return false;
                }
            }

            // FullName and Position are required in tblEmployeeDetails schema
            if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
            {
                MessageBox.Show("FullName is required.", "Invalid FullName", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fullNameTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(positionTextBox.Text))
            {
                MessageBox.Show("Position is required.", "Invalid Position", MessageBoxButtons.OK, MessageBoxIcon.Error);
                positionTextBox.Focus();
                return false;
            }

            return true;
        }

        private void UpdateDatabase()
        {
            this.tableAdapterManager.UpdateAll(this.hR_Management_Dataset);
        }

        private void SetFieldsReadOnly(bool readOnly)
        {
            empIDTextBox.ReadOnly = readOnly;
            fullNameTextBox.ReadOnly = readOnly;
            departmentTextBox.ReadOnly = readOnly;
            locationTextBox.ReadOnly = readOnly;
            positionTextBox.ReadOnly = readOnly;
            salaryTextBox.ReadOnly = readOnly;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                // Cancel any pending edit to avoid committing partial data
                try { this.tblEmployeeDetailsBindingSource.CancelEdit(); } catch { /* ignore */ }

                // Reset UI search state but do NOT change focus
                _currentSearchField = SearchField.None;
                textBoxSearch.Text = string.Empty;
                textBoxSearch.Enabled = false;
                lblSearchHint.Text = "Click on 'Search by...'";

                // Remove any in-memory filter and reload the EmployeeDetails table from DB
                ClearSearchFilter();
                this.tblEmployeeDetailsTableAdapter.Fill(this.hR_Management_Dataset.tblEmployeeDetails);

                // Ensure binding source reflects the reloaded table
                tblEmployeeDetailsBindingSource.DataSource = this.hR_Management_Dataset.tblEmployeeDetails;
                tblEmployeeDetailsBindingSource.ResetBindings(false);

                SetFieldsReadOnly(true);
                currentPosition();

                // Leave current focus unchanged per request
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reset failed: " + ex.Message, "Reset error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "Word_Report.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Word(tblEmployeeDetailsDataGridView, sfd.FileName);
            }

        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Aptos Display";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 16;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Отчет за служителите";
                    headerRange.Font.Size = 18;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs2(filename);
            }

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            sfd.FileName = "Excel_Report.xlsx";
            

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Excel(tblEmployeeDetailsDataGridView, sfd.FileName);
            }
        }

        public void Export_Data_To_Excel(DataGridView DGV, string filename)
        {
            if (DGV == null || DGV.Columns.Count == 0)
                throw new InvalidOperationException("No data available to export.");

            if (DGV.Rows.Count == 0)
            {
                // still create a workbook with headers
            }

            Excel.Application xlApp = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;
            Excel.Range headerRange = null;
            Excel.Range usedRange = null;
            Excel.Range titleRange = null;

            try
            {
                xlApp = new Excel.Application();
                wb = xlApp.Workbooks.Add(Type.Missing);
                ws = (Excel.Worksheet)wb.ActiveSheet;
                ws.Name = "Employee Report";

                int colCount = DGV.Columns.Count;
                int rowCount = DGV.Rows.Count;

                // write header
                for (int c = 0; c < colCount; c++)
                {
                    ws.Cells[1, c + 1] = DGV.Columns[c].HeaderText;
                }

                // write data rows
                for (int r = 0; r < rowCount; r++)
                {
                    for (int c = 0; c < colCount; c++)
                    {
                        var cell = DGV.Rows[r].Cells[c].Value;
                        ws.Cells[r + 2, c + 1] = (cell == null) ? string.Empty : cell;
                    }
                }

                // header formatting
                headerRange = ws.Range[ws.Cells[1, 1], ws.Cells[1, colCount]];
                headerRange.Font.Bold = true;
                headerRange.Font.Size = 12;
                headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);

                // Autofit columns
                usedRange = ws.UsedRange;
                usedRange.Columns.AutoFit();

                // Add a centered title in the first row above header (insert a row)
                ws.Rows[1].Insert(Excel.XlInsertShiftDirection.xlShiftDown);
                ws.Cells[1, 1] = "Отчет за служителите";
                titleRange = ws.Range[ws.Cells[1, 1], ws.Cells[1, colCount]];
                titleRange.Merge();
                titleRange.Font.Size = 14;
                titleRange.Font.Bold = true;
                titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // Save as .xlsx
                wb.SaveAs(filename, Excel.XlFileFormat.xlOpenXMLWorkbook);

                // Do not show Excel — close workbook and quit application to avoid opening Excel.
                wb.Close(false);
                xlApp.Quit();
            }
            finally
            {
                // Release COM objects in reverse order of creation where applicable.
                if (titleRange != null) Marshal.ReleaseComObject(titleRange);
                if (headerRange != null) Marshal.ReleaseComObject(headerRange);
                if (usedRange != null) Marshal.ReleaseComObject(usedRange);
                if (ws != null) Marshal.ReleaseComObject(ws);
                if (wb != null) Marshal.ReleaseComObject(wb);
                if (xlApp != null) Marshal.ReleaseComObject(xlApp);

                titleRange = null;
                headerRange = null;
                usedRange = null;
                ws = null;
                wb = null;
                xlApp = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}
