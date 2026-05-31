using System;
using System.Globalization;
using System.Windows.Forms;

namespace HR_Management
{
    public partial class DepartmentsForm : Form
    {
        public DepartmentsForm()
        {
            InitializeComponent();
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            // Load data and update position indicator
            this.tblDepartmentsTableAdapter.Fill(this.hR_Management_Dataset.tblDepartments);
            currentPosition();
            SetFieldsReadOnly(true);

            // Ensure these buttons bypass control validation so they always respond
            // even if the user is editing a bound field that rejects validation.
            btnCancel.CausesValidation = false;
            btnExit.CausesValidation = false;
            btnPrevious.CausesValidation = false;
            btnNext.CausesValidation = false;
            btnDelete.CausesValidation = false;

            // Allow users to move away from numeric fields even when they contain non-numeric input.
            // Saving still validates and shows an error message.
            depIDTextBox.CausesValidation = false;
            depBudgetTextBox.CausesValidation = false;
        }

        // Single save handler used by binding navigator Save button (if present)
        private void tblDepartmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Add new row and enable editing
            this.tblDepartmentsBindingSource.AddNew();
            SetFieldsReadOnly(false);
            depIDTextBox.Focus();
            currentPosition();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.tblDepartmentsBindingSource.Current == null)
            {
                MessageBox.Show("No record selected to delete.");
                return;
            }

            var dr = MessageBox.Show("Are you sure you want to delete the current department?", "Delete Department", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr != DialogResult.Yes)
            {
                return;
            }

            try
            {
                this.tblDepartmentsBindingSource.RemoveCurrent();
                UpdateDatabase();
                MessageBox.Show("The record was deleted successfully.", "Delete Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Refresh dataset and position
                this.tblDepartmentsTableAdapter.Fill(this.hR_Management_Dataset.tblDepartments);
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
            // Enable editing of current record
            if (this.tblDepartmentsBindingSource.Current == null)
            {
                MessageBox.Show("No record selected to edit.");
                return;
            }

            SetFieldsReadOnly(false);
            depNameTextBox.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Move focus to the cancel button (which has CausesValidation = false)
            // to avoid any Validating event on the current control from cancelling the click.
            try
            {
                this.ActiveControl = btnCancel;
            }
            catch
            {
                // ignore if focus can't be set
            }

            // Cancel pending edits and reload data
            try
            {
                this.tblDepartmentsBindingSource.CancelEdit();
            }
            catch
            {
                // ignore
            }

            this.tblDepartmentsTableAdapter.Fill(this.hR_Management_Dataset.tblDepartments);
            SetFieldsReadOnly(true);
            currentPosition();

            // Put focus on a safe control so the user can continue navigating
            if (tblDepartmentsBindingSource.Count > 0)
            {
                depIDTextBox.Focus();
            }
            else
            {
                btnNew.Focus();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (this.tblDepartmentsBindingSource.Position > 0)
            {
                this.tblDepartmentsBindingSource.MovePrevious();
                currentPosition();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.tblDepartmentsBindingSource.Position < this.tblDepartmentsBindingSource.Count - 1)
            {
                this.tblDepartmentsBindingSource.MoveNext();
                currentPosition();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void currentPosition()
        {
            int rowNumber = Math.Max(0, tblDepartmentsBindingSource.Count);
            int currentPosition = (tblDepartmentsBindingSource.Position >= 0) ? tblDepartmentsBindingSource.Position + 1 : 0;
            NextPreviousTextBox.Text = currentPosition.ToString() + " / " + rowNumber.ToString();
        }


        private void SaveChanges()
        {
            try
            {
                // Validate numeric-only fields before committing
                if (!ValidateNumericFields())
                {
                    return;
                }

                this.Validate();
                this.tblDepartmentsBindingSource.EndEdit();

                UpdateDatabase();

                // Refresh to pick up database-assigned values (if any)
                this.tblDepartmentsTableAdapter.Fill(this.hR_Management_Dataset.tblDepartments);
                SetFieldsReadOnly(true);
                currentPosition();

                MessageBox.Show("The Departments table was updated successfully.", "Update Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }

        private bool ValidateNumericFields()
        {
            // DepID must be an integer
            var depIdText = (depIDTextBox.Text ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(depIdText))
            {
                MessageBox.Show("DepID must be an integer!", "Invalid DepID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                depIDTextBox.Focus();
                return false;
            }

            if (!int.TryParse(depIdText, NumberStyles.Integer, CultureInfo.CurrentCulture, out _))
            {
                MessageBox.Show("DepID must be an integer!", "Invalid DepID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                depIDTextBox.Focus();
                return false;
            }

            // DepBudget must be a decimal number
            var budgetText = (depBudgetTextBox.Text ?? string.Empty).Trim();
            if (!string.IsNullOrEmpty(budgetText))
            {
                if (!decimal.TryParse(budgetText, NumberStyles.Number, CultureInfo.CurrentCulture, out _))
                {
                    MessageBox.Show("DepBudget must be a decimal number!", "Invalid DepBudget", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    depBudgetTextBox.Focus();
                    return false;
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
            depIDTextBox.ReadOnly = readOnly;
            depNameTextBox.ReadOnly = readOnly;
            depLocationTextBox.ReadOnly = readOnly;
            depBudgetTextBox.ReadOnly = readOnly;
        }
    }
}