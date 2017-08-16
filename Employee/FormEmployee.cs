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
    public partial class FormEmployee : Form
    {
        private string email;
        public FormEmployee(string email)
        {
            InitializeComponent();
            this.email = email;
            show();
        }

        
        
        private void show()
        {
            Connector connector = new Connector();
            connector.sqlConnection.Open();
            string query = "select * from tbl_Emplyee where Emp_email = '" + email + "'";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlAdaper = new SqlDataAdapter(connector.sqlCommand);
            connector.dataSet = new DataSet();
            connector.sqlAdaper.Fill(connector.dataSet);
            connector.sqlConnection.Close();
            txtName.Text = connector.dataSet.Tables[0].Rows[0][1].ToString();
            txtAge.Text = connector.dataSet.Tables[0].Rows[0][3].ToString();
            txtEmail.Text = connector.dataSet.Tables[0].Rows[0][4].ToString();
            txtSalary.Text = connector.dataSet.Tables[0].Rows[0][5].ToString();
            txtDutytime.Text = connector.dataSet.Tables[0].Rows[0][6].ToString();
            txtDesig.Text = connector.dataSet.Tables[0].Rows[0][7].ToString();
            txtOvertime.Text = connector.dataSet.Tables[0].Rows[0][8].ToString();
        }
        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FormRMSAC objFormRMSAC = new FormRMSAC();
            objFormRMSAC.Show();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRMS_Click(object sender, EventArgs e)
        {

        }

    }
}
