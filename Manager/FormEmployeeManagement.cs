using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class FormEmployeeManagement : Form
    {
        private EmployeeDAO employeeDao = new EmployeeDAO();
        string uname;
        public FormEmployeeManagement()
        {
            InitializeComponent();
            LoadEmployeesInfo();
        }

        public FormEmployeeManagement(string username)
        {
            InitializeComponent();
            LoadEmployeesInfo();
            lblName.Text = username;
            uname = username;
        }

        private void LoadEmployeesInfo()
        {
            DataTable dataTable = employeeDao.getEmployees().Tables[0];
            dataGridViewEmployee.Rows.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                int n = dataGridViewEmployee.Rows.Add();
                dataGridViewEmployee.Rows[n].Cells[0].Value = item["Emp_id"].ToString();
                dataGridViewEmployee.Rows[n].Cells[1].Value = item["Emp_name"].ToString();
                dataGridViewEmployee.Rows[n].Cells[2].Value = item["Emp_email"].ToString();
                dataGridViewEmployee.Rows[n].Cells[3].Value = item["Emp_salary"].ToString();
                dataGridViewEmployee.Rows[n].Cells[4].Value = item["Emp_dutyTime"].ToString();
                dataGridViewEmployee.Rows[n].Cells[5].Value = item["Emp_overtime"].ToString();
                dataGridViewEmployee.Rows[n].Cells[6].Value = item["Emp_designation"].ToString();
            }
        }
        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewEmployee.Rows[e.RowIndex];
                txtId.Text = row.Cells["colId"].Value.ToString();
                txtSalary.Text = row.Cells["colEmpSalary"].Value.ToString();
                txtDutyTime.Text = row.Cells["colEmpDuty"].Value.ToString();
                txtOvertime.Text = row.Cells["colEmpOvertime"].Value.ToString();
                txtDesignation.Text = row.Cells["colEmpDes"].Value.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEmployeeManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            int salary = Convert.ToInt32(txtSalary.Text);
            string dutytime = txtDutyTime.Text;
            string overtime = txtOvertime.Text;
            string designation = txtDesignation.Text;

            employeeDao.updateEmployee(new EmployeeDTO(id, salary, dutytime, overtime, designation));
            txtId.Text = "";
            txtSalary.Text = "";
            txtDutyTime.Text = "";
            txtOvertime.Text = "";
            txtDesignation.Text = "";
            LoadEmployeesInfo();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            //FormRMSAC fromRMSAC = new FormRMSAC();
            //fromRMSAC.Show();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            int salary = Convert.ToInt32(txtSalary.Text);
            string dutytime = txtDutyTime.Text;
            string overtime = txtOvertime.Text;
            string des = txtDesignation.Text;

            employeeDao.delEmployee(new EmployeeDTO(id, salary, dutytime, overtime, des));
            txtId.Text = "";
            txtSalary.Text = "";
            txtDutyTime.Text = "";
            txtOvertime.Text = "";
            txtDesignation.Text = "";
            LoadEmployeesInfo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManagerHome objfromManagerHome = new FormManagerHome(uname);
            objfromManagerHome.Show();
        }

        private void lOGOUTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormRMSAC fromRMSAC = new FormRMSAC();
            fromRMSAC.Show();
        }

        private void oPTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
