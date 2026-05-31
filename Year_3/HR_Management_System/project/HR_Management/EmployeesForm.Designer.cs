namespace HR_Management
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            System.Windows.Forms.Label empIDLabel;
            System.Windows.Forms.Label empFirstNameLabel;
            System.Windows.Forms.Label empLastNameLabel;
            System.Windows.Forms.Label empEmailLabel;
            System.Windows.Forms.Label empPhoneLabel;
            System.Windows.Forms.Label empAddressLabel;
            System.Windows.Forms.Label empHireDateLabel;
            System.Windows.Forms.Label posIDLabel;
            System.Windows.Forms.Label depIDLabel;
            this.hR_Management_Dataset = new HR_Management.HR_Management_Dataset();
            this.tblEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmployeesTableAdapter = new HR_Management.HR_Management_DatasetTableAdapters.tblEmployeesTableAdapter();
            this.tableAdapterManager = new HR_Management.HR_Management_DatasetTableAdapters.TableAdapterManager();
            this.tblEmployeesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblEmployeesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.empFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.empLastNameTextBox = new System.Windows.Forms.TextBox();
            this.empEmailTextBox = new System.Windows.Forms.TextBox();
            this.empPhoneTextBox = new System.Windows.Forms.TextBox();
            this.empAddressTextBox = new System.Windows.Forms.TextBox();
            this.empHireDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.posIDTextBox = new System.Windows.Forms.TextBox();
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
            empIDLabel = new System.Windows.Forms.Label();
            empFirstNameLabel = new System.Windows.Forms.Label();
            empLastNameLabel = new System.Windows.Forms.Label();
            empEmailLabel = new System.Windows.Forms.Label();
            empPhoneLabel = new System.Windows.Forms.Label();
            empAddressLabel = new System.Windows.Forms.Label();
            empHireDateLabel = new System.Windows.Forms.Label();
            posIDLabel = new System.Windows.Forms.Label();
            depIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hR_Management_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingNavigator)).BeginInit();
            this.tblEmployeesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // hR_Management_Dataset
            // 
            this.hR_Management_Dataset.DataSetName = "HR_Management_Dataset";
            this.hR_Management_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmployeesBindingSource
            // 
            this.tblEmployeesBindingSource.DataMember = "tblEmployees";
            this.tblEmployeesBindingSource.DataSource = this.hR_Management_Dataset;
            // 
            // tblEmployeesTableAdapter
            // 
            this.tblEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblDepartmentsTableAdapter = null;
            this.tableAdapterManager.tblEmployeeDetailsTableAdapter = null;
            this.tableAdapterManager.tblEmployeesTableAdapter = this.tblEmployeesTableAdapter;
            this.tableAdapterManager.tblPositionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HR_Management.HR_Management_DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblEmployeesBindingNavigator
            // 
            this.tblEmployeesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblEmployeesBindingNavigator.BindingSource = this.tblEmployeesBindingSource;
            this.tblEmployeesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblEmployeesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblEmployeesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblEmployeesBindingNavigatorSaveItem});
            this.tblEmployeesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblEmployeesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblEmployeesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblEmployeesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblEmployeesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblEmployeesBindingNavigator.Name = "tblEmployeesBindingNavigator";
            this.tblEmployeesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblEmployeesBindingNavigator.Size = new System.Drawing.Size(798, 25);
            this.tblEmployeesBindingNavigator.TabIndex = 0;
            this.tblEmployeesBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tblEmployeesBindingNavigatorSaveItem
            // 
            this.tblEmployeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblEmployeesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblEmployeesBindingNavigatorSaveItem.Image")));
            this.tblEmployeesBindingNavigatorSaveItem.Name = "tblEmployeesBindingNavigatorSaveItem";
            this.tblEmployeesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tblEmployeesBindingNavigatorSaveItem.Text = "Save Data";
            this.tblEmployeesBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblEmployeesBindingNavigatorSaveItem_Click);
            // 
            // empIDLabel
            // 
            empIDLabel.AutoSize = true;
            empIDLabel.Location = new System.Drawing.Point(17, 40);
            empIDLabel.Name = "empIDLabel";
            empIDLabel.Size = new System.Drawing.Size(45, 13);
            empIDLabel.TabIndex = 1;
            empIDLabel.Text = "Emp ID:";
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmployeesBindingSource, "EmpID", true));
            this.empIDTextBox.Location = new System.Drawing.Point(108, 37);
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.empIDTextBox.TabIndex = 2;
            // 
            // empFirstNameLabel
            // 
            empFirstNameLabel.AutoSize = true;
            empFirstNameLabel.Location = new System.Drawing.Point(17, 66);
            empFirstNameLabel.Name = "empFirstNameLabel";
            empFirstNameLabel.Size = new System.Drawing.Size(84, 13);
            empFirstNameLabel.TabIndex = 3;
            empFirstNameLabel.Text = "Emp First Name:";
            // 
            // empFirstNameTextBox
            // 
            this.empFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmployeesBindingSource, "EmpFirstName", true));
            this.empFirstNameTextBox.Location = new System.Drawing.Point(108, 63);
            this.empFirstNameTextBox.Name = "empFirstNameTextBox";
            this.empFirstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.empFirstNameTextBox.TabIndex = 4;
            // 
            // empLastNameLabel
            // 
            empLastNameLabel.AutoSize = true;
            empLastNameLabel.Location = new System.Drawing.Point(17, 92);
            empLastNameLabel.Name = "empLastNameLabel";
            empLastNameLabel.Size = new System.Drawing.Size(85, 13);
            empLastNameLabel.TabIndex = 5;
            empLastNameLabel.Text = "Emp Last Name:";
            // 
            // empLastNameTextBox
            // 
            this.empLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmployeesBindingSource, "EmpLastName", true));
            this.empLastNameTextBox.Location = new System.Drawing.Point(108, 89);
            this.empLastNameTextBox.Name = "empLastNameTextBox";
            this.empLastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.empLastNameTextBox.TabIndex = 6;
            // 
            // empEmailLabel
            // 
            empEmailLabel.AutoSize = true;
            empEmailLabel.Location = new System.Drawing.Point(17, 118);
            empEmailLabel.Name = "empEmailLabel";
            empEmailLabel.Size = new System.Drawing.Size(59, 13);
            empEmailLabel.TabIndex = 7;
            empEmailLabel.Text = "Emp Email:";
            // 
            // empEmailTextBox
            // 
            this.empEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmployeesBindingSource, "EmpEmail", true));
            this.empEmailTextBox.Location = new System.Drawing.Point(108, 115);
            this.empEmailTextBox.Name = "empEmailTextBox";
            this.empEmailTextBox.Size = new System.Drawing.Size(200, 20);
            this.empEmailTextBox.TabIndex = 8;
            // 
            // empPhoneLabel
            // 
            empPhoneLabel.AutoSize = true;
            empPhoneLabel.Location = new System.Drawing.Point(17, 144);
            empPhoneLabel.Name = "empPhoneLabel";
            empPhoneLabel.Size = new System.Drawing.Size(65, 13);
            empPhoneLabel.TabIndex = 9;
            empPhoneLabel.Text = "Emp Phone:";
            // 
            // empPhoneTextBox
            // 
            this.empPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmployeesBindingSource, "EmpPhone", true));
            this.empPhoneTextBox.Location = new System.Drawing.Point(108, 141);
            this.empPhoneTextBox.Name = "empPhoneTextBox";
            this.empPhoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.empPhoneTextBox.TabIndex = 10;
            // 
            // empAddressLabel
            // 
            empAddressLabel.AutoSize = true;
            empAddressLabel.Location = new System.Drawing.Point(17, 170);
            empAddressLabel.Name = "empAddressLabel";
            empAddressLabel.Size = new System.Drawing.Size(72, 13);
            empAddressLabel.TabIndex = 11;
            empAddressLabel.Text = "Emp Address:";
            // 
            // empAddressTextBox
            // 
            this.empAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmployeesBindingSource, "EmpAddress", true));
            this.empAddressTextBox.Location = new System.Drawing.Point(108, 167);
            this.empAddressTextBox.Name = "empAddressTextBox";
            this.empAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.empAddressTextBox.TabIndex = 12;
            // 
            // empHireDateLabel
            // 
            empHireDateLabel.AutoSize = true;
            empHireDateLabel.Location = new System.Drawing.Point(17, 197);
            empHireDateLabel.Name = "empHireDateLabel";
            empHireDateLabel.Size = new System.Drawing.Size(79, 13);
            empHireDateLabel.TabIndex = 13;
            empHireDateLabel.Text = "Emp Hire Date:";
            // 
            // empHireDateDateTimePicker
            // 
            this.empHireDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblEmployeesBindingSource, "EmpHireDate", true));
            this.empHireDateDateTimePicker.Location = new System.Drawing.Point(108, 193);
            this.empHireDateDateTimePicker.Name = "empHireDateDateTimePicker";
            this.empHireDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.empHireDateDateTimePicker.TabIndex = 14;
            // 
            // posIDLabel
            // 
            posIDLabel.AutoSize = true;
            posIDLabel.Location = new System.Drawing.Point(17, 222);
            posIDLabel.Name = "posIDLabel";
            posIDLabel.Size = new System.Drawing.Size(42, 13);
            posIDLabel.TabIndex = 15;
            posIDLabel.Text = "Pos ID:";
            // 
            // posIDTextBox
            // 
            this.posIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmployeesBindingSource, "PosID", true));
            this.posIDTextBox.Location = new System.Drawing.Point(108, 219);
            this.posIDTextBox.Name = "posIDTextBox";
            this.posIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.posIDTextBox.TabIndex = 16;
            // 
            // depIDLabel
            // 
            depIDLabel.AutoSize = true;
            depIDLabel.Location = new System.Drawing.Point(17, 248);
            depIDLabel.Name = "depIDLabel";
            depIDLabel.Size = new System.Drawing.Size(44, 13);
            depIDLabel.TabIndex = 17;
            depIDLabel.Text = "Dep ID:";
            // 
            // depIDTextBox
            // 
            this.depIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmployeesBindingSource, "DepID", true));
            this.depIDTextBox.Location = new System.Drawing.Point(108, 245);
            this.depIDTextBox.Name = "depIDTextBox";
            this.depIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.depIDTextBox.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(522, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNew.Location = new System.Drawing.Point(441, 82);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 26;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNext.Location = new System.Drawing.Point(705, 34);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 25;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrevious.Location = new System.Drawing.Point(339, 34);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 24;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // NextPreviousTextBox
            // 
            this.NextPreviousTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NextPreviousTextBox.Location = new System.Drawing.Point(440, 37);
            this.NextPreviousTextBox.Name = "NextPreviousTextBox";
            this.NextPreviousTextBox.Size = new System.Drawing.Size(238, 20);
            this.NextPreviousTextBox.TabIndex = 23;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(603, 124);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(522, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(441, 124);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(603, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(798, 289);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.NextPreviousTextBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(empIDLabel);
            this.Controls.Add(this.empIDTextBox);
            this.Controls.Add(empFirstNameLabel);
            this.Controls.Add(this.empFirstNameTextBox);
            this.Controls.Add(empLastNameLabel);
            this.Controls.Add(this.empLastNameTextBox);
            this.Controls.Add(empEmailLabel);
            this.Controls.Add(this.empEmailTextBox);
            this.Controls.Add(empPhoneLabel);
            this.Controls.Add(this.empPhoneTextBox);
            this.Controls.Add(empAddressLabel);
            this.Controls.Add(this.empAddressTextBox);
            this.Controls.Add(empHireDateLabel);
            this.Controls.Add(this.empHireDateDateTimePicker);
            this.Controls.Add(posIDLabel);
            this.Controls.Add(this.posIDTextBox);
            this.Controls.Add(depIDLabel);
            this.Controls.Add(this.depIDTextBox);
            this.Controls.Add(this.tblEmployeesBindingNavigator);
            this.Name = "EmployeesForm";
            this.Text = "Employees Form";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hR_Management_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingNavigator)).EndInit();
            this.tblEmployeesBindingNavigator.ResumeLayout(false);
            this.tblEmployeesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HR_Management_Dataset hR_Management_Dataset;
        private System.Windows.Forms.BindingSource tblEmployeesBindingSource;
        private HR_Management_DatasetTableAdapters.tblEmployeesTableAdapter tblEmployeesTableAdapter;
        private HR_Management_DatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblEmployeesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblEmployeesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.TextBox empFirstNameTextBox;
        private System.Windows.Forms.TextBox empLastNameTextBox;
        private System.Windows.Forms.TextBox empEmailTextBox;
        private System.Windows.Forms.TextBox empPhoneTextBox;
        private System.Windows.Forms.TextBox empAddressTextBox;
        private System.Windows.Forms.DateTimePicker empHireDateDateTimePicker;
        private System.Windows.Forms.TextBox posIDTextBox;
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