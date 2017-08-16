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
    public partial class FormManagerLogin : Form
    {
        //private RMS_DAO rmsDAO = new RMS_DAO();
        public FormManagerLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMngLogin_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=RMSdb;Integrated Security=True");

            string quary = "select * from tbl_Manager where Mng_email = '" + txtMngEmail.Text.Trim() + "'and Mng_password = '" + txtMngPassword.Text.Trim() + "'";
            SqlCommand sqlCommand = new SqlCommand(quary, sqlConnection);
            SqlDataAdapter sqlAdaper = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlAdaper.Fill(dataSet);
            string username = dataSet.Tables[0].Rows[0]["Mng_name"].ToString();

            if (dataSet.Tables[0].Rows.Count == 1)
            {
                FormManagerHome objFromEmpHome = new FormManagerHome(username);
                this.Hide();
                objFromEmpHome.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or/and Password");
            }
        }
    }
}
