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
    public partial class FormFoodManagement : Form
    {
        private FoodDAO foodDao = new FoodDAO();
        string uname;
        public FormFoodManagement()
        {
            InitializeComponent();
            LoadFoodsInfo();
        }

        public FormFoodManagement(string username)
        {
            InitializeComponent();
            LoadFoodsInfo();
            lblMngName.Text = username;
            uname = username;
        }

        private void FormFood_Load(object sender, EventArgs e)
        {

        }
        private void LoadFoodsInfo()
        {
            DataTable dataTable = foodDao.getFoods().Tables[0];
            dataGridViewFood.Rows.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                int n = dataGridViewFood.Rows.Add();
                dataGridViewFood.Rows[n].Cells[0].Value = item["Food_id"].ToString();
                dataGridViewFood.Rows[n].Cells[1].Value = item["Food_name"].ToString();
                dataGridViewFood.Rows[n].Cells[2].Value = item["Food_price"].ToString();
            }
        }

        private void dataGridViewFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.dataGridViewFood.Rows[e.RowIndex];
                txtId.Text = row.Cells["colFoodId"].Value.ToString();
                txtName.Text = row.Cells["colFoodName"].Value.ToString();
                txtPrice.Text = row.Cells["colFoodPrice"].Value.ToString();
            }
        }

        private void dataGridViewFood_SelectionChanged(object sender, EventArgs e)
        {
            //if (dataGridViewFood.SelectedRows.Count == 1)
            //{
            //    int idx = dataGridViewFood.SelectedRows[0].Index;
            //    txtId.Text = dataGridViewFood.Rows[idx].Cells[0].Value.ToString();
            //    txtName.Text = dataGridViewFood.Rows[idx].Cells[1].Value.ToString();
            //    txtAmount.Text = dataGridViewFood.Rows[idx].Cells[2].Value.ToString();
            //    txtPrice.Text = dataGridViewFood.Rows[idx].Cells[3].Value.ToString();
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(txtId.Text);
            //string name = txtName.Text;
            //int amount = Convert.ToInt32(txtAmount.Text);
            //int price = Convert.ToInt32(txtPrice.Text);

            //foodDao.createFood(new FoodDTO(id, name, amount, price));
            //LoadFoodsInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(txtId.Text);
            //string name = txtName.Text;
            //int amount = Convert.ToInt32(txtAmount.Text);
            //int price = Convert.ToInt32(txtPrice.Text);

            //foodDao.delFood(new FoodDTO(id, name, amount, price));
            //txtId.Text = "";
            //txtName.Text = "";
            //txtAmount.Text = "";
            //txtPrice.Text = "";
            //LoadFoodsInfo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(txtId.Text);
            //string name = txtName.Text;
            //int amount = Convert.ToInt32(txtAmount.Text);
            //int price = Convert.ToInt32(txtPrice.Text);

            //foodDao.updateFood(new FoodDTO(id, name, amount, price));
            //txtId.Text = "";
            //txtName.Text = "";
            //txtAmount.Text = "";
            //txtPrice.Text = "";
            //LoadFoodsInfo();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //this.Close();
            //FormRMSAC fromRMSAC = new FormRMSAC();
            //fromRMSAC.Show();

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string name = txtName.Text;
            //int amount = Convert.ToInt32(txtAmount.Text);
            int price = Convert.ToInt32(txtPrice.Text);

            foodDao.createFood(new FoodDTO(id, name, price));
            LoadFoodsInfo();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string name = txtName.Text;
            //int amount = Convert.ToInt32(txtAmount.Text);
            int price = Convert.ToInt32(txtPrice.Text);

            foodDao.delFood(new FoodDTO(id, name, price));
            txtId.Text = "";
            txtName.Text = "";
            //txtAmount.Text = "";
            txtPrice.Text = "";
            LoadFoodsInfo();
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string name = txtName.Text;
            //int amount = Convert.ToInt32(txtAmount.Text);
            int price = Convert.ToInt32(txtPrice.Text);

            foodDao.updateFood(new FoodDTO(id, name, price));
            txtId.Text = "";
            txtName.Text = "";
            //txtAmount.Text = "";
            txtPrice.Text = "";
            LoadFoodsInfo();
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

        
    }
}
