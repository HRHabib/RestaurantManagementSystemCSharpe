using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    public partial class FormCost : Form
    {
        Connector connector = new Connector();
        private EmployeeDAO employeeDao = new EmployeeDAO();
        double totalCost = 0;
        double perDaySalary;
        string uname;

        public FormCost()
        {
            InitializeComponent();
            LoadEmployeeSalary();
        }

        public FormCost(string username)
        {
            InitializeComponent();
            LoadEmployeeSalary();
            lblName.Text = username;
            uname = username;
        }

        private void LoadEmployeeSalary()
        {
            DataTable dataTable = employeeDao.getEmployees().Tables[0];
            dataGridViewEmpCost.Rows.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                int n = dataGridViewEmpCost.Rows.Add();
                dataGridViewEmpCost.Rows[n].Cells[0].Value = false;
                dataGridViewEmpCost.Rows[n].Cells[1].Value = item["Emp_name"].ToString();
                dataGridViewEmpCost.Rows[n].Cells[2].Value = item["Emp_salary"].ToString();
                dataGridViewEmpCost.Rows[n].Cells[3].Value = item["Emp_overtime"].ToString();
            }
        }

        private void dataGridViewEmpCost_MouseClick(object sender, MouseEventArgs e)
        {
            if ((bool)dataGridViewEmpCost.SelectedRows[0].Cells[0].Value == false)
            {
                dataGridViewEmpCost.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dataGridViewEmpCost.SelectedRows[0].Cells[0].Value = false;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridViewEmpCost.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    double salary = Convert.ToDouble(item.Cells[2].Value.ToString()) / (26.0);
                    int overtimeHour = Convert.ToInt32(item.Cells[3].Value.ToString());
                    double overtimeSalary = overtimeHour * ((salary * 25) / 100.0);
                    perDaySalary = salary + overtimeSalary;
                    item.Cells[4].Value = perDaySalary.ToString("0.00");
                    totalCost += perDaySalary;
                    
                }
            }

            foreach (DataGridViewRow item in dataGridViewEmpCost.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    item.Cells[0].Value = false;
                }
            }
            //MessageBox.Show(perDaySalary.ToString());
        }

        private void dataGridViewEmpCost_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewEmpCost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCost_Click(object sender, EventArgs e)
        {
            totalCost = totalCost + Convert.ToDouble(txtCost.Text) + Convert.ToDouble(txtRawCost.Text);
            //MessageBox.Show(totalCost.ToString());

            connector.sqlConnection.Open();
            string query = "update tbl_Profit set Profit_cost = '" + totalCost.ToString() + "' where Profit_date = '" + DateTime.Now.ToString("d/M/yyyy") + "' ";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlCommand.ExecuteNonQuery();
            connector.sqlConnection.Close();
            txtCost.Text = "";
            txtRawCost.Text = "";
            //MessageBox.Show(DateTime.Now.ToString("d/M/yyyy"));
        }

        private void dailySellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSell objFormSell = new FormSell(uname);
            this.Hide();
            objFormSell.Show();
        }

        private void dailyCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCost objFormCost = new FormCost(uname);
            this.Hide();
            objFormCost.Show();
        }

        private void pROFITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfit objFormProfit = new FormProfit(uname);
            this.Hide();
            objFormProfit.Show();
        }

        /*private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }*/

        private void lOGOUTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormRMSAC objFormRMSAC = new FormRMSAC();
            this.Hide();
            objFormRMSAC.Show();
        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagerHome objFormManagerHome = new FormManagerHome(uname);
            this.Hide();
            objFormManagerHome.Show();
        }
    }
}
