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
    public partial class FormManagerHome : Form
    {
        string uname;
        public FormManagerHome()
        {
            InitializeComponent();
            panelOptions.Show();
            panelBillSection.Hide();
            //panelBill.Hide();
            //panelEmp.Hide();
            //panelFood.Hide();
        }

        public FormManagerHome(string username)
        {
            InitializeComponent();
            lblName.Text = username;
            uname = username;
            panelOptions.Show();
            panelBillSection.Hide();
            //panelBill.Show();
            //panelBillHide.Show();
            //panelFoodHide.Show();
        }

        private void btnFoodMng_Click(object sender, EventArgs e)
        {
            FormFoodManagement objFromFood = new FormFoodManagement(uname);
            this.Hide();
            objFromFood.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FormRMSAC fromRMSAC = new FormRMSAC();
            fromRMSAC.Show();
        }

        private void btnEmployeeMng_Click(object sender, EventArgs e)
        {
            FormEmployeeManagement objFormEmployeeManagement = new FormEmployeeManagement(uname);
            this.Hide();
            objFormEmployeeManagement.Show();
        }

        private void btnBillMng_Click(object sender, EventArgs e)
        {
            FormBillManagement objFormBillManagement = new FormBillManagement(uname);
            this.Hide();
            objFormBillManagement.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            //panelFood.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormBillManagement objFormBillManagment = new FormBillManagement();
            //this.Hide();
            //objFormBillManagment.Show();
        }

        private void btnMngSec_Click(object sender, EventArgs e)
        {
            panelOptions.Show();
            panelBillSection.Hide();
        }

        private void btnBillSec_Click(object sender, EventArgs e)
        {
            panelOptions.Show();
            panelBillSection.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            FormSell objFormPayment = new FormSell(uname);
            this.Hide();
            objFormPayment.Show();
        }
    }
}
