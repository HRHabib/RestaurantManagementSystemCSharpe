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
    public partial class FormBillManagement : Form
    {
        private FoodDAO foodDao = new FoodDAO();
        Connector connector = new Connector();
        private string strQuantity;
        int search = 0, ammount, totalAmount = 0;
        int sell;
        int rowNum;
        string strSearch, strAmount, uname;
        

        public FormBillManagement(string username)
        {
            InitializeComponent();
            LoadFoodsInfo();
            uname = username;
        }

        private void LoadFoodsInfo()
        {

            if (search == 0)
            {
                DataTable dataTable = foodDao.getBillFoods();
                dataGridViewBill.Rows.Clear();
                foreach (DataRow item in dataTable.Rows)
                {
                    int n = dataGridViewBill.Rows.Add();
                    dataGridViewBill.Rows[n].Cells[0].Value = false;
                    dataGridViewBill.Rows[n].Cells[1].Value = item["Food_id"].ToString();
                    dataGridViewBill.Rows[n].Cells[2].Value = item["Food_name"].ToString();
                    dataGridViewBill.Rows[n].Cells[3].Value = item["Food_price"].ToString();
                    //dataGridViewBill.Rows[n].Cells[4].Value = item["Food_stock"].ToString();
                }
            }
            else
            {
                search = 0;
            }


        }

        

        private void dataGridViewBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search = 1;
            strSearch = txtSearch.Text;

            string query = "select Food_id, Food_name, Food_price from tbl_food where Food_name like'" + strSearch + "%'";
            DataTable dataTable = foodDao.searchFoods(query).Tables[0];
            dataGridViewBill.Rows.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                int n = dataGridViewBill.Rows.Add();
                dataGridViewBill.Rows[n].Cells[0].Value = false;
                dataGridViewBill.Rows[n].Cells[1].Value = item["Food_id"].ToString();
                dataGridViewBill.Rows[n].Cells[2].Value = item["Food_name"].ToString();
                dataGridViewBill.Rows[n].Cells[3].Value = item["Food_price"].ToString();
                //dataGridViewBill.Rows[n].Cells[4].Value = item["Food_stock"].ToString();
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewBill_MouseClick(object sender, MouseEventArgs e)
        {
            //int n = dataGridViewBill.Rows.Add();
            //dataGridViewBill.Rows[n].Cells[0].Value = false;
            if ((bool)dataGridViewBill.SelectedRows[0].Cells[0].Value == false)
            {
                dataGridViewBill.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dataGridViewBill.SelectedRows[0].Cells[0].Value = false;
            }
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            /*//SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=RMSdb;Integrated Security=True");
            //SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Food", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataGridViewBill.Rows.Clear();
            if (search == 0)
            {
                //SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=RMSdb;Integrated Security=True");
                //SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Food", con);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);
                DataTable dataTable = foodDao.getBillFoods();
                dataGridViewBill.Rows.Clear();
                foreach (DataRow item in dataTable.Rows)
                {
                    int n = dataGridViewBill.Rows.Add();
                    dataGridViewBill.Rows[n].Cells[0].Value = false;
                    dataGridViewBill.Rows[n].Cells[1].Value = item["Food_id"].ToString();
                    dataGridViewBill.Rows[n].Cells[2].Value = item["Food_name"].ToString();
                    dataGridViewBill.Rows[n].Cells[3].Value = item["Food_price"].ToString();
                    //dataGridViewBill.Rows[n].Cells[4].Value = item["Food_stock"].ToString();
                }
            }
            else
            {
                search = 0;
            }*/
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridViewBill.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = dataGridViewBillSelect.Rows.Add();
                    dataGridViewBillSelect.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    dataGridViewBillSelect.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    dataGridViewBillSelect.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                }
            }

            foreach (DataGridViewRow item in dataGridViewBill.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    item.Cells[0].Value = false;
                }
            }
        }

        private void btnQnatity_Click(object sender, EventArgs e)
        {
            int n = 0;
            strQuantity = txtQuantity.Text;
            int quantity = Convert.ToInt32(txtQuantity.Text);
            int price = Convert.ToInt32(dataGridViewBillSelect.Rows[dataGridViewBillSelect.SelectedRows[0].Index].Cells[2].Value);
            
            {
                int amount = quantity * price;
                //totalAmount += amount;
                dataGridViewBillSelect.Rows[dataGridViewBillSelect.SelectedRows[0].Index].Cells[3].Value = strQuantity;
                dataGridViewBillSelect.Rows[dataGridViewBillSelect.SelectedRows[0].Index].Cells[4].Value = amount.ToString();

            }
            
            txtQuantity.Text = "";
        }

        private void useQuantity()
        {

        }
        private void dataGridViewBillSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
            }
        }

        private void dataGridViewBillSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                rowNum = dataGridViewBillSelect.SelectedRows[0].Index;
                //MessageBox.Show(dataGridViewBillSelect.SelectedRows[0].Index.ToString());
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FormRMSAC fromRMSAC = new FormRMSAC();
            fromRMSAC.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManagerHome objfromManagerHome = new FormManagerHome(uname);
            objfromManagerHome.Show();
        }

        private void btnTamount_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewBillSelect.Rows.Count; i++)
            {
                totalAmount = totalAmount + Convert.ToInt32(dataGridViewBillSelect.Rows[i].Cells[4].Value.ToString());
            }
            lblTotalAmount.Text = totalAmount.ToString();

            connector.sqlConnection.Open();
            string query = " insert into tbl_FoodSell values ('" + lblTotalAmount.Text + "')";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlCommand.ExecuteNonQuery();
            connector.sqlConnection.Close();
        }
    }
}
