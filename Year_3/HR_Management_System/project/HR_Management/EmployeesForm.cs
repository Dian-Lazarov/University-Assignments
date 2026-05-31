using System;
using System.Globalization;
using System.Windows.Forms;

namespace HR_Management
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            // Load data and initialize UI consistent with Departments/Positions forms
            this.tblEmployeesTableAdapter.Fill(this.hR_Management_Dataset.tblEmployees);
            currentPosition();
            SetFieldsReadOnly(true);

            // Ensure these buttons bypass control validation so they always respond
            btnCancel.CausesValidation = false;
            btnExit.CausesValidation = false;
            btnPrevious.CausesValidation = false;
            btnNext.CausesValidation = false;
            btnDelete.CausesValidation = false;

            // Allow users to leave numeric-only fields with invalid input.
            // Save will still validate and show an error message.
            empIDTextBox.CausesValidation = false;
            // optional numeric fields
            posIDTextBox.CausesValidation = false;
            depIDTextBox.CausesValidation = false;

            // Wire up button events in case designer didn't set them
            btnNew.Click += btnNew_Click;
            btnDelete.Click += btnDelete_Click;
            btnSave.Click += btnSave_Click;
            btnEdit.Click += btnEdit_Click;
            btnCancel.Click += btnCancel_Click;
            btnPrevious.Click += btnPrevious_Click;
            btnNext.Click += btnNext_Click;
            btnExit.Click += btnExit_Click;
        }

        private void tblEmployeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.tblEmployeesBindingSource.AddNew();
            SetFieldsReadOnly(false);
            empIDTextBox.Focus();
            currentPosition();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.tblEmployeesBindingSource.Current == null)
            {
                MessageBox.Show("No record selected to delete.");
                return;
            }

            var dr = MessageBox.Show("Are you sure you want to delete the current employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr != DialogResult.Yes)
            {
                return;
            }

            try
            {
                this.tblEmployeesBindingSource.RemoveCurrent();
                UpdateDatabase();
                MessageBox.Show("The record was deleted successfully.", "Delete Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.tblEmployeesTableAdapter.Fill(this.hR_Management_Dataset.tblEmployees);
                currentPosition();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.tblEmployeesBindingSource.Current == null)
            {
                MessageBox.Show("No record selected to edit.");
                return;
            }

            SetFieldsReadOnly(false);
            empFirstNameTextBox.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = btnCancel;
            }
            catch
            {
                // ignore
            }

            try
            {
                this.tblEmployeesBindingSource.CancelEdit();
            }
            catch
            {
                // ignore
            }

            this.tblEmployeesTableAdapter.Fill(this.hR_Management_Dataset.tblEmployees);
            SetFieldsReadOnly(true);
            currentPosition();

            if (tblEmployeesBindingSource.Count > 0)
            {
                empIDTextBox.Focus();
            }
            else
            {
                btnNew.Focus();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (this.tblEmployeesBindingSource.Position > 0)
            {
                this.tblEmployeesBindingSource.MovePrevious();
                currentPosition();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.tblEmployeesBindingSource.Position < this.tblEmployeesBindingSource.Count - 1)
            {
                this.tblEmployeesBindingSource.MoveNext();
                currentPosition();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void currentPosition()
        {
            int rowNumber = Math.Max(0, tblEmployeesBindingSource.Count);
            int currentPosition = (tblEmployeesBindingSource.Position >= 0) ? tblEmployeesBindingSource.Position + 1 : 0;
            NextPreviousTextBox.Text = currentPosition.ToString() + " / " + rowNumber.ToString();
        }

        private void SaveChanges()
        {
            try
            {
                // Validate numeric-only fields (and hire date if text) before committing
                if (!ValidateNumericFields())
                {
                    return;
                }

                this.Validate();
                this.tblEmployeesBindingSource.EndEdit();

                UpdateDatabase();

                this.tblEmployeesTableAdapter.Fill(this.hR_Management_Dataset.tblEmployees);
                SetFieldsReadOnly(true);
                currentPosition();

                MessageBox.Show("The Employees table was updated successfully.", "Update Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }

        /// <summary>
        /// Validates numeric-only fields:
        /// EmpID required int; PosID optional int; DepID optional int.
        /// Also validates EmpHireDate if it's bound to a TextBox.
        /// Shows user-friendly error messages and focuses offending control.
        /// </summary>
        private bool ValidateNumericFields()
        {
            // EmpID must be an integer and is required
            var empIdText = (empIDTextBox.Text ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(empIdText))
            {
                MessageBox.Show("EmpID must be an integer!", "Invalid EmpID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                empIDTextBox.Focus();
                return false;
            }

            if (!int.TryParse(empIdText, NumberStyles.Integer, CultureInfo.CurrentCulture, out _))
            {
                MessageBox.Show("EmpID must be an integer!", "Invalid EmpID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                empIDTextBox.Focus();
                return false;
            }

            // PosID is optional, but if provided must be integer
            var posIdText = (posIDTextBox.Text ?? string.Empty).Trim();
            if (!string.IsNullOrEmpty(posIdText))
            {
                if (!int.TryParse(posIdText, NumberStyles.Integer, CultureInfo.CurrentCulture, out _))
                {
                    MessageBox.Show("PosID must be an integer!", "Invalid PosID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    posIDTextBox.Focus();
                    return false;
                }
            }

            // DepID is optional, but if provided must be integer
            var depIdText = (depIDTextBox.Text ?? string.Empty).Trim();
            if (!string.IsNullOrEmpty(depIdText))
            {
                if (!int.TryParse(depIdText, NumberStyles.Integer, CultureInfo.CurrentCulture, out _))
                {
                    MessageBox.Show("DepID must be an integer!", "Invalid DepID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    depIDTextBox.Focus();
                    return false;
                }
            }

            // Validate hire date if it's a TextBox (if designer uses DateTimePicker it's always valid)
            var hireDatePicker = this.Controls.Find("empHireDateDateTimePicker", true);
            if (hireDatePicker.Length == 0)
            {
                // try TextBox
                var hireTextBoxes = this.Controls.Find("empHireDateTextBox", true);
                if (hireTextBoxes.Length > 0 && hireTextBoxes[0] is TextBox hireTextBox)
                {
                    var txt = (hireTextBox.Text ?? string.Empty).Trim();
                    if (string.IsNullOrEmpty(txt))
                    {
                        MessageBox.Show("EmpHireDate must be a valid date!", "Invalid Hire Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hireTextBox.Focus();
                        return false;
                    }

                    if (!DateTime.TryParse(txt, CultureInfo.CurrentCulture, DateTimeStyles.None, out _))
                    {
                        MessageBox.Show("EmpHireDate must be a valid date!", "Invalid Hire Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hireTextBox.Focus();
                        return false;
                    }
                }
            }

            return true;
        }

        private void UpdateDatabase()
        {
            this.tableAdapterManager.UpdateAll(this.hR_Management_Dataset);
        }

        private void SetFieldsReadOnly(bool readOnly)
        {
            // TextBoxes
            empIDTextBox.ReadOnly = readOnly;
            empFirstNameTextBox.ReadOnly = readOnly;
            empLastNameTextBox.ReadOnly = readOnly;
            empEmailTextBox.ReadOnly = readOnly;
            empPhoneTextBox.ReadOnly = readOnly;
            empAddressTextBox.ReadOnly = readOnly;
            posIDTextBox.ReadOnly = readOnly;
            depIDTextBox.ReadOnly = readOnly;

            // Hire date control may be a DateTimePicker; disable it instead of ReadOnly
            var hirePickers = this.Controls.Find("empHireDateDateTimePicker", true);
            if (hirePickers.Length > 0 && hirePickers[0] is DateTimePicker dtp)
            {
                dtp.Enabled = !readOnly;
            }
            else
            {
                var hireTextBoxes = this.Controls.Find("empHireDateTextBox", true);
                if (hireTextBoxes.Length > 0 && hireTextBoxes[0] is TextBox tb)
                {
                    tb.ReadOnly = readOnly;
                }
            }
        }
    }
}
