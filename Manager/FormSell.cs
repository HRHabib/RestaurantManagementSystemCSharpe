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
    public partial class FormSell : Form
    {
        Connector connector = new Connector();
        private FoodSellDAO foodsellDao = new FoodSellDAO();
        private EmployeeDAO employeeDao = new EmployeeDAO();
        string uname;
        int index;
        int totalAmount;
        double perDaySalary;
        
        public FormSell()
        {
            InitializeComponent();
            panelDailySell.Visible = true;
            LoadFoodSellInfo();
            
        }

        public FormSell(string username)
        {
            InitializeComponent();
            panelDailySell.Visible = true;
            LoadFoodSellInfo();
            lblName.Text = username;
            uname = username;

        }
        

        private void LoadFoodSellInfo()
        {
            panelDailySell.Visible = true;
            //panelProfit.Visible = false;
            DataTable dataTable = foodsellDao.getFoodSell().Tables[0];
            dataGridViewFoodSell.Rows.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                int n = dataGridViewFoodSell.Rows.Add();
                dataGridViewFoodSell.Rows[n].Cells[0].Value = item["Sell_id"].ToString();
                dataGridViewFoodSell.Rows[n].Cells[1].Value = item["Sell_amount"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewprofit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dailySellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormSell objFormSell = new FormSell(uname);
            this.Hide();
            objFormSell.Show();
            LoadFoodSellInfo();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridViewFoodSell.Rows)
            {
                totalAmount += Convert.ToInt32(item.Cells[1].Value.ToString());
            }
           

            connector.sqlConnection.Open();
            string query = " insert into tbl_Profit (Profit_date, Profit_earn) values ('" + DateTime.Now.ToString("d/M/yyyy") + "', '" + totalAmount.ToString() + "')";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlCommand.ExecuteNonQuery();
            connector.sqlConnection.Close();
            foodsellDao.clearFoodSell();
            LoadFoodSellInfo();
        }

        private void panelProfit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dailyCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCost objFormCost = new FormCost(uname);
            this.Hide();
            objFormCost.Show();
            
        }

        private void LoadEmployeeSalary()
        {
            
        }

        private void dataGridViewEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            //if ((bool)dataGridViewEmployee.SelectedRows[0].Cells[0].Value == false)
            //{
            //    dataGridViewEmployee.SelectedRows[0].Cells[0].Value = true;
            //}
            //else
            //{
            //    dataGridViewEmployee.SelectedRows[0].Cells[0].Value = false;
            //}
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
        }

        private void clickToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pROFITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormProfit objFormProfit = new FormProfit(uname);
            this.Hide();
            objFormProfit.Show();
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
           
            //panelDailySell.Show();
            //panelProfit.Hide();
            //panelCost.Hide();
            //listpanel.Add(panelDailySell);
            //listpanel.Add(panelCost);
            //listpanel.Add(panelProfit);
            //listpanel[index].BringToFront();
           
        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagerHome objFormManagerHome = new FormManagerHome(uname);
            this.Hide();
            objFormManagerHome.Show();
        }

        private void lOGOUTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRMSAC objFormRMSAC = new FormRMSAC();
            this.Hide();
            objFormRMSAC.Show();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
