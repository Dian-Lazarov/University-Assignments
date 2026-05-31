using System;
using System.Globalization;
using System.Windows.Forms;

namespace HR_Management
{
    public partial class PositionsForm : Form
    {
        public PositionsForm()
        {
            InitializeComponent();
        }

        private void PositionsForm_Load(object sender, EventArgs e)
        {
            this.tblPositionsTableAdapter.Fill(this.hR_Management_Dataset.tblPositions);
            currentPosition();
            SetFieldsReadOnly(true);

            // Ensure these buttons bypass control validation so they always respond
            // even if the user is editing a bound field that rejects validation.
            btnCancel.CausesValidation = false;
            btnExit.CausesValidation = false;
            btnPrevious.CausesValidation = false;
            btnNext.CausesValidation = false;
            btnDelete.CausesValidation = false;

            // Allow users to leave numeric-only fields with invalid input.
            // Save will still validate and show an error message.
            posIDTextBox.CausesValidation = false;
            posSalaryTextBox.CausesValidation = false;
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

        private void tblPositionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Add new row and enable editing
            this.tblPositionsBindingSource.AddNew();
            SetFieldsReadOnly(false);
            posIDTextBox.Focus();
            currentPosition();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.tblPositionsBindingSource.Current == null)
            {
                MessageBox.Show("No record selected to delete.");
                return;
            }

            var dr = MessageBox.Show("Are you sure you want to delete the current position?", "Delete Position", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr != DialogResult.Yes)
            {
                return;
            }

            try
            {
                this.tblPositionsBindingSource.RemoveCurrent();
                UpdateDatabase();
                MessageBox.Show("The record was deleted successfully.", "Delete Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh dataset and position
                this.tblPositionsTableAdapter.Fill(this.hR_Management_Dataset.tblPositions);
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
            if (this.tblPositionsBindingSource.Current == null)
            {
                MessageBox.Show("No record selected to edit.");
                return;
            }

            SetFieldsReadOnly(false);
            posTitleTextBox.Focus();
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
                this.tblPositionsBindingSource.CancelEdit();
            }
            catch
            {
                // ignore
            }

            this.tblPositionsTableAdapter.Fill(this.hR_Management_Dataset.tblPositions);
            SetFieldsReadOnly(true);
            currentPosition();

            // Put focus on a safe control so the user can continue navigating
            if (tblPositionsBindingSource.Count > 0)
            {
                posIDTextBox.Focus();
            }
            else
            {
                btnNew.Focus();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (this.tblPositionsBindingSource.Position > 0)
            {
                this.tblPositionsBindingSource.MovePrevious();
                currentPosition();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.tblPositionsBindingSource.Position < this.tblPositionsBindingSource.Count - 1)
            {
                this.tblPositionsBindingSource.MoveNext();
                currentPosition();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void currentPosition()
        {
            int rowNumber = Math.Max(0, tblPositionsBindingSource.Count);
            int currentPosition = (tblPositionsBindingSource.Position >= 0) ? tblPositionsBindingSource.Position + 1 : 0;
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
                this.tblPositionsBindingSource.EndEdit();

                UpdateDatabase();

                // Refresh to pick up database-assigned values (if any)
                this.tblPositionsTableAdapter.Fill(this.hR_Management_Dataset.tblPositions);
                SetFieldsReadOnly(true);
                currentPosition();

                MessageBox.Show("The Positions table was updated successfully.", "Update Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }

        /// <summary>
        /// Validate numeric-only fields (PosID required int; PosSalary optional decimal; DepID optional int).
        /// Shows appropriate error messages and returns true when validation passes.
        /// </summary>
        private bool ValidateNumericFields()
        {
            // PosID must be an integer
            var posIdText = (posIDTextBox.Text ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(posIdText))
            {
                MessageBox.Show("PosID must be an integer!", "Invalid PosID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                posIDTextBox.Focus();
                return false;
            }

            if (!int.TryParse(posIdText, NumberStyles.Integer, CultureInfo.CurrentCulture, out _))
            {
                MessageBox.Show("PosID must be an integer!", "Invalid PosID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                posIDTextBox.Focus();
                return false;
            }

            // PosSalary must be a decimal number
            var salaryText = (posSalaryTextBox.Text ?? string.Empty).Trim();
            if (!string.IsNullOrEmpty(salaryText))
            {
                if (!decimal.TryParse(salaryText, NumberStyles.Number, CultureInfo.CurrentCulture, out _))
                {
                    MessageBox.Show("PosSalary must be a decimal number!", "Invalid PosSalary", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    posSalaryTextBox.Focus();
                    return false;
                }
            }

            // DepID must be an integer
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

            return true;
        }

        private void UpdateDatabase()
        {
            this.tableAdapterManager.UpdateAll(this.hR_Management_Dataset);
        }

        private void SetFieldsReadOnly(bool readOnly)
        {
            posIDTextBox.ReadOnly = readOnly;
            posTitleTextBox.ReadOnly = readOnly;
            posSalaryTextBox.ReadOnly = readOnly;
            depIDTextBox.ReadOnly = readOnly;
        }
    }
}
