using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Management
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentsForm departmentsForm = new DepartmentsForm();
            this.Hide();
            departmentsForm.ShowDialog();
            this.Show();
        }

        private void positionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PositionsForm positionsForm = new PositionsForm();
            this.Hide();
            positionsForm.ShowDialog();
            this.Show();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm();
            this.Hide();
            employeesForm.ShowDialog();
            this.Show();
        }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeDetailsForm employeeDetailsForm = new EmployeeDetailsForm();
            this.Hide();
            employeeDetailsForm.ShowDialog();
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
