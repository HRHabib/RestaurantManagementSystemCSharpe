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
    public partial class FormProfit : Form
    {
        Connector connector = new Connector();
        ProfitDAO profitDao = new ProfitDAO();
        string uname;

        public FormProfit()
        {
            InitializeComponent();
            LoadProfitInfo();
        }

        public FormProfit(string username)
        {
            InitializeComponent();
            LoadProfitInfo();
            lblName.Text = username;
            uname = username;
        }

        private void LoadProfitInfo()
        {
            DataTable dataTable = profitDao.getProfits().Tables[0];
            dataGridViewprofit.Rows.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                int n = dataGridViewprofit.Rows.Add();
                dataGridViewprofit.Rows[n].Cells[0].Value = item["Profit_date"].ToString();
                dataGridViewprofit.Rows[n].Cells[1].Value = item["Profit_earn"].ToString();
                dataGridViewprofit.Rows[n].Cells[2].Value = item["Profit_cost"].ToString();
                double profit = Convert.ToDouble(item["profit_earn"].ToString()) - Convert.ToDouble(item["Profit_cost"].ToString());
                //string profit =diff.ToString("0.00");
                dataGridViewprofit.Rows[n].Cells[3].Value = profit.ToString("0.00");

                connector.sqlConnection.Open();
                string query = "update tbl_Profit set Profit_profit = '" + profit.ToString("0.00") + "' where Profit_date = '" + DateTime.Now.ToString("d/M/yyyy") + "' ";
                connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
                connector.sqlCommand.ExecuteNonQuery();
                connector.sqlConnection.Close();
            }
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
