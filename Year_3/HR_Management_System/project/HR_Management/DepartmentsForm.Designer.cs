namespace HR_Management
{
    partial class DepartmentsForm
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
            System.Windows.Forms.Label depIDLabel;
            System.Windows.Forms.Label depNameLabel;
            System.Windows.Forms.Label depLocationLabel;
            System.Windows.Forms.Label depBudgetLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentsForm));
            this.tblDepartmentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblDepartmentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.depIDTextBox = new System.Windows.Forms.TextBox();
            this.depNameTextBox = new System.Windows.Forms.TextBox();
            this.depLocationTextBox = new System.Windows.Forms.TextBox();
            this.depBudgetTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.NextPreviousTextBox = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tblDepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_Management_Dataset = new HR_Management.HR_Management_Dataset();
            this.tblDepartmentsTableAdapter = new HR_Management.HR_Management_DatasetTableAdapters.tblDepartmentsTableAdapter();
            this.tableAdapterManager = new HR_Management.HR_Management_DatasetTableAdapters.TableAdapterManager();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            depIDLabel = new System.Windows.Forms.Label();
            depNameLabel = new System.Windows.Forms.Label();
            depLocationLabel = new System.Windows.Forms.Label();
            depBudgetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmentsBindingNavigator)).BeginInit();
            this.tblDepartmentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_Management_Dataset)).BeginInit();
            this.SuspendLayout();
            // 
            // depIDLabel
            // 
            depIDLabel.AutoSize = true;
            depIDLabel.Location = new System.Drawing.Point(21, 53);
            depIDLabel.Name = "depIDLabel";
            depIDLabel.Size = new System.Drawing.Size(44, 13);
            depIDLabel.TabIndex = 1;
            depIDLabel.Text = "Dep ID:";
            // 
            // depNameLabel
            // 
            depNameLabel.AutoSize = true;
            depNameLabel.Location = new System.Drawing.Point(21, 79);
            depNameLabel.Name = "depNameLabel";
            depNameLabel.Size = new System.Drawing.Size(61, 13);
            depNameLabel.TabIndex = 3;
            depNameLabel.Text = "Dep Name:";
            // 
            // depLocationLabel
            // 
            depLocationLabel.AutoSize = true;
            depLocationLabel.Location = new System.Drawing.Point(325, 53);
            depLocationLabel.Name = "depLocationLabel";
            depLocationLabel.Size = new System.Drawing.Size(74, 13);
            depLocationLabel.TabIndex = 5;
            depLocationLabel.Text = "Dep Location:";
            // 
            // depBudgetLabel
            // 
            depBudgetLabel.AutoSize = true;
            depBudgetLabel.Location = new System.Drawing.Point(325, 79);
            depBudgetLabel.Name = "depBudgetLabel";
            depBudgetLabel.Size = new System.Drawing.Size(67, 13);
            depBudgetLabel.TabIndex = 7;
            depBudgetLabel.Text = "Dep Budget:";
            // 
            // tblDepartmentsBindingNavigator
            // 
            this.tblDepartmentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblDepartmentsBindingNavigator.BindingSource = this.tblDepartmentsBindingSource;
            this.tblDepartmentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblDepartmentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblDepartmentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblDepartmentsBindingNavigatorSaveItem});
            this.tblDepartmentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblDepartmentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblDepartmentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblDepartmentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblDepartmentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblDepartmentsBindingNavigator.Name = "tblDepartmentsBindingNavigator";
            this.tblDepartmentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblDepartmentsBindingNavigator.Size = new System.Drawing.Size(575, 25);
            this.tblDepartmentsBindingNavigator.TabIndex = 0;
            this.tblDepartmentsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblDepartmentsBindingNavigatorSaveItem
            // 
            this.tblDepartmentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblDepartmentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblDepartmentsBindingNavigatorSaveItem.Image")));
            this.tblDepartmentsBindingNavigatorSaveItem.Name = "tblDepartmentsBindingNavigatorSaveItem";
            this.tblDepartmentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblDepartmentsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // depIDTextBox
            // 
            this.depIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.depIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDepartmentsBindingSource, "DepID", true));
            this.depIDTextBox.Location = new System.Drawing.Point(101, 50);
            this.depIDTextBox.Name = "depIDTextBox";
            this.depIDTextBox.Size = new System.Drawing.Size(150, 20);
            this.depIDTextBox.TabIndex = 2;
            // 
            // depNameTextBox
            // 
            this.depNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.depNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDepartmentsBindingSource, "DepName", true));
            this.depNameTextBox.Location = new System.Drawing.Point(101, 76);
            this.depNameTextBox.Name = "depNameTextBox";
            this.depNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.depNameTextBox.TabIndex = 4;
            // 
            // depLocationTextBox
            // 
            this.depLocationTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.depLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDepartmentsBindingSource, "DepLocation", true));
            this.depLocationTextBox.Location = new System.Drawing.Point(405, 50);
            this.depLocationTextBox.Name = "depLocationTextBox";
            this.depLocationTextBox.Size = new System.Drawing.Size(150, 20);
            this.depLocationTextBox.TabIndex = 6;
            // 
            // depBudgetTextBox
            // 
            this.depBudgetTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.depBudgetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDepartmentsBindingSource, "DepBudget", true));
            this.depBudgetTextBox.Location = new System.Drawing.Point(405, 76);
            this.depBudgetTextBox.Name = "depBudgetTextBox";
            this.depBudgetTextBox.Size = new System.Drawing.Size(150, 20);
            this.depBudgetTextBox.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(186, 128);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(318, 128);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(399, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(480, 128);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // NextPreviousTextBox
            // 
            this.NextPreviousTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NextPreviousTextBox.Location = new System.Drawing.Point(161, 208);
            this.NextPreviousTextBox.Name = "NextPreviousTextBox";
            this.NextPreviousTextBox.Size = new System.Drawing.Size(238, 20);
            this.NextPreviousTextBox.TabIndex = 13;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrevious.Location = new System.Drawing.Point(60, 205);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNext.Location = new System.Drawing.Point(426, 205);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tblDepartmentsBindingSource
            // 
            this.tblDepartmentsBindingSource.DataMember = "tblDepartments";
            this.tblDepartmentsBindingSource.DataSource = this.hR_Management_Dataset;
            // 
            // hR_Management_Dataset
            // 
            this.hR_Management_Dataset.DataSetName = "HR_Management_Dataset";
            this.hR_Management_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDepartmentsTableAdapter
            // 
            this.tblDepartmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblDepartmentsTableAdapter = this.tblDepartmentsTableAdapter;
            this.tableAdapterManager.tblEmployeeDetailsTableAdapter = null;
            this.tableAdapterManager.tblEmployeesTableAdapter = null;
            this.tableAdapterManager.tblPositionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HR_Management.HR_Management_DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNew.Location = new System.Drawing.Point(24, 128);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(105, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(575, 260);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.NextPreviousTextBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(depIDLabel);
            this.Controls.Add(this.depIDTextBox);
            this.Controls.Add(depNameLabel);
            this.Controls.Add(this.depNameTextBox);
            this.Controls.Add(depLocationLabel);
            this.Controls.Add(this.depLocationTextBox);
            this.Controls.Add(depBudgetLabel);
            this.Controls.Add(this.depBudgetTextBox);
            this.Controls.Add(this.tblDepartmentsBindingNavigator);
            this.Name = "DepartmentsForm";
            this.Text = "Departments Form";
            this.Load += new System.EventHandler(this.DepartmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmentsBindingNavigator)).EndInit();
            this.tblDepartmentsBindingNavigator.ResumeLayout(false);
            this.tblDepartmentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_Management_Dataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HR_Management_Dataset hR_Management_Dataset;
        private System.Windows.Forms.BindingSource tblDepartmentsBindingSource;
        private HR_Management_DatasetTableAdapters.tblDepartmentsTableAdapter tblDepartmentsTableAdapter;
        private HR_Management_DatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblDepartmentsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblDepartmentsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox depIDTextBox;
        private System.Windows.Forms.TextBox depNameTextBox;
        private System.Windows.Forms.TextBox depLocationTextBox;
        private System.Windows.Forms.TextBox depBudgetTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox NextPreviousTextBox;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
    }
}