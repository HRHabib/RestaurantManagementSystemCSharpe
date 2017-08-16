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
    public partial class FormEmployeeLogin : Form
    {
        private EmployeeDAO employeeDao = new EmployeeDAO(); 
        public FormEmployeeLogin()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmpRegistration objFromEmpRegistration = new FormEmpRegistration();
            objFromEmpRegistration.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPass.Text;

            //employeeDao.loginEmployee(new EmployeeDTO(email, password));
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=RMSdb;Integrated Security=True");

            string quary = "select * from tbl_Emplyee where Emp_email = '" + txtEmail.Text + "'and Emp_password = '" + txtPass.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(quary, sqlConnection);
            SqlDataAdapter sqlAdaper = new SqlDataAdapter(sqlCommand);
            //DataTable datatable = new DataTable();
            DataSet dataSet = new DataSet();
            //sqlAdaper.Fill(datatable);
            sqlAdaper.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 1)
            {
                FormEmployee objFromEmployee = new FormEmployee(txtEmail.Text);
                this.Hide();
                objFromEmployee.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or/and Password");
            }
            
        }
    }
}
