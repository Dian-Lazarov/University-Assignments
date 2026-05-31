namespace HR_Management
{
    partial class PositionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionsForm));
            System.Windows.Forms.Label posIDLabel;
            System.Windows.Forms.Label posTitleLabel;
            System.Windows.Forms.Label posSalaryLabel;
            System.Windows.Forms.Label depIDLabel;
            this.hR_Management_Dataset = new HR_Management.HR_Management_Dataset();
            this.tblPositionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPositionsTableAdapter = new HR_Management.HR_Management_DatasetTableAdapters.tblPositionsTableAdapter();
            this.tableAdapterManager = new HR_Management.HR_Management_DatasetTableAdapters.TableAdapterManager();
            this.tblPositionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tblPositionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.posIDTextBox = new System.Windows.Forms.TextBox();
            this.posTitleTextBox = new System.Windows.Forms.TextBox();
            this.posSalaryTextBox = new System.Windows.Forms.TextBox();
            this.depIDTextBox = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.NextPreviousTextBox = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            posIDLabel = new System.Windows.Forms.Label();
            posTitleLabel = new System.Windows.Forms.Label();
            posSalaryLabel = new System.Windows.Forms.Label();
            depIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hR_Management_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPositionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPositionsBindingNavigator)).BeginInit();
            this.tblPositionsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // hR_Management_Dataset
            // 
            this.hR_Management_Dataset.DataSetName = "HR_Management_Dataset";
            this.hR_Management_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPositionsBindingSource
            // 
            this.tblPositionsBindingSource.DataMember = "tblPositions";
            this.tblPositionsBindingSource.DataSource = this.hR_Management_Dataset;
            // 
            // tblPositionsTableAdapter
            // 
            this.tblPositionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblDepartmentsTableAdapter = null;
            this.tableAdapterManager.tblEmployeeDetailsTableAdapter = null;
            this.tableAdapterManager.tblEmployeesTableAdapter = null;
            this.tableAdapterManager.tblPositionsTableAdapter = this.tblPositionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = HR_Management.HR_Management_DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblPositionsBindingNavigator
            // 
            this.tblPositionsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblPositionsBindingNavigator.BindingSource = this.tblPositionsBindingSource;
            this.tblPositionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblPositionsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblPositionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblPositionsBindingNavigatorSaveItem});
            this.tblPositionsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblPositionsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblPositionsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblPositionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblPositionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblPositionsBindingNavigator.Name = "tblPositionsBindingNavigator";
            this.tblPositionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblPositionsBindingNavigator.Size = new System.Drawing.Size(575, 25);
            this.tblPositionsBindingNavigator.TabIndex = 0;
            this.tblPositionsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tblPositionsBindingNavigatorSaveItem
            // 
            this.tblPositionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblPositionsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblPositionsBindingNavigatorSaveItem.Image")));
            this.tblPositionsBindingNavigatorSaveItem.Name = "tblPositionsBindingNavigatorSaveItem";
            this.tblPositionsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblPositionsBindingNavigatorSaveItem.Text = "Save Data";
            this.tblPositionsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblPositionsBindingNavigatorSaveItem_Click);
            // 
            // posIDLabel
            // 
            posIDLabel.AutoSize = true;
            posIDLabel.Location = new System.Drawing.Point(16, 51);
            posIDLabel.Name = "posIDLabel";
            posIDLabel.Size = new System.Drawing.Size(42, 13);
            posIDLabel.TabIndex = 1;
            posIDLabel.Text = "Pos ID:";
            // 
            // posIDTextBox
            // 
            this.posIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPositionsBindingSource, "PosID", true));
            this.posIDTextBox.Location = new System.Drawing.Point(82, 48);
            this.posIDTextBox.Name = "posIDTextBox";
            this.posIDTextBox.Size = new System.Drawing.Size(147, 20);
            this.posIDTextBox.TabIndex = 2;
            // 
            // posTitleLabel
            // 
            posTitleLabel.AutoSize = true;
            posTitleLabel.Location = new System.Drawing.Point(16, 77);
            posTitleLabel.Name = "posTitleLabel";
            posTitleLabel.Size = new System.Drawing.Size(51, 13);
            posTitleLabel.TabIndex = 3;
            posTitleLabel.Text = "Pos Title:";
            // 
            // posTitleTextBox
            // 
            this.posTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPositionsBindingSource, "PosTitle", true));
            this.posTitleTextBox.Location = new System.Drawing.Point(82, 74);
            this.posTitleTextBox.Name = "posTitleTextBox";
            this.posTitleTextBox.Size = new System.Drawing.Size(147, 20);
            this.posTitleTextBox.TabIndex = 4;
            // 
            // posSalaryLabel
            // 
            posSalaryLabel.AutoSize = true;
            posSalaryLabel.Location = new System.Drawing.Point(339, 51);
            posSalaryLabel.Name = "posSalaryLabel";
            posSalaryLabel.Size = new System.Drawing.Size(60, 13);
            posSalaryLabel.TabIndex = 5;
            posSalaryLabel.Text = "Pos Salary:";
            // 
            // posSalaryTextBox
            // 
            this.posSalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPositionsBindingSource, "PosSalary", true));
            this.posSalaryTextBox.Location = new System.Drawing.Point(405, 48);
            this.posSalaryTextBox.Name = "posSalaryTextBox";
            this.posSalaryTextBox.Size = new System.Drawing.Size(147, 20);
            this.posSalaryTextBox.TabIndex = 6;
            // 
            // depIDLabel
            // 
            depIDLabel.AutoSize = true;
            depIDLabel.Location = new System.Drawing.Point(339, 77);
            depIDLabel.Name = "depIDLabel";
            depIDLabel.Size = new System.Drawing.Size(44, 13);
            depIDLabel.TabIndex = 7;
            depIDLabel.Text = "Dep ID:";
            // 
            // depIDTextBox
            // 
            this.depIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPositionsBindingSource, "DepID", true));
            this.depIDTextBox.Location = new System.Drawing.Point(405, 74);
            this.depIDTextBox.Name = "depIDTextBox";
            this.depIDTextBox.Size = new System.Drawing.Size(147, 20);
            this.depIDTextBox.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(100, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNew.Location = new System.Drawing.Point(19, 126);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 25;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNext.Location = new System.Drawing.Point(421, 203);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrevious.Location = new System.Drawing.Point(55, 203);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 23;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // NextPreviousTextBox
            // 
            this.NextPreviousTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NextPreviousTextBox.Location = new System.Drawing.Point(156, 206);
            this.NextPreviousTextBox.Name = "NextPreviousTextBox";
            this.NextPreviousTextBox.Size = new System.Drawing.Size(238, 20);
            this.NextPreviousTextBox.TabIndex = 22;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(475, 126);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(394, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(313, 126);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(181, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // PositionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(575, 258);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.NextPreviousTextBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(posIDLabel);
            this.Controls.Add(this.posIDTextBox);
            this.Controls.Add(posTitleLabel);
            this.Controls.Add(this.posTitleTextBox);
            this.Controls.Add(posSalaryLabel);
            this.Controls.Add(this.posSalaryTextBox);
            this.Controls.Add(depIDLabel);
            this.Controls.Add(this.depIDTextBox);
            this.Controls.Add(this.tblPositionsBindingNavigator);
            this.Name = "PositionsForm";
            this.Text = "Positions Form";
            this.Load += new System.EventHandler(this.PositionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hR_Management_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPositionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPositionsBindingNavigator)).EndInit();
            this.tblPositionsBindingNavigator.ResumeLayout(false);
            this.tblPositionsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HR_Management_Dataset hR_Management_Dataset;
        private System.Windows.Forms.BindingSource tblPositionsBindingSource;
        private HR_Management_DatasetTableAdapters.tblPositionsTableAdapter tblPositionsTableAdapter;
        private HR_Management_DatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblPositionsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblPositionsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox posIDTextBox;
        private System.Windows.Forms.TextBox posTitleTextBox;
        private System.Windows.Forms.TextBox posSalaryTextBox;
        private System.Windows.Forms.TextBox depIDTextBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox NextPreviousTextBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
    }
}