using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RestaurantManagementSystem
{
    public partial class FormEmpRegistration : Form
    {
        private EmployeeDAO employeeDao = new EmployeeDAO();
        private int flag = 0;
        public FormEmpRegistration()
        {
            InitializeComponent();
        }

        private void btnEmpSignUp_Click(object sender, EventArgs e)
        {
            if (txtEmpPass.Text == txtEmpCPass.Text && txtEmpName.Text != "" && txtEmpEmail.Text != "" && txtEmpAge.Text != "" && txtEmpPass.Text != "" && txtEmpCPass.Text!="" && flag == 1)
            {
                string name = txtEmpName.Text;
                string email = txtEmpEmail.Text;
                string pass = txtEmpPass.Text;
                int age = Convert.ToInt32(txtEmpAge.Text);
                //int id = 0;
                int salary = 0;
                string duty = "";
                string degination = "";

                employeeDao.addEmployee(new EmployeeDTO(name, age, salary, pass, email, duty, degination));
                MessageBox.Show("You have successfully registered!");
                this.Hide();
                //FormEmployeeLogin objFormEmployeeLogin = new FormEmployeeLogin();
                //objFormEmployeeLogin.Show();
                FormEmployee objFromEmployee = new FormEmployee(txtEmpEmail.Text);
                objFromEmployee.Show();
 
            }
            else if (txtEmpPass.Text != txtEmpCPass.Text)
            {
                MessageBox.Show("Password Mismatch");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Invalid Email");
            }
            
           
           
        }

        private void txtEmpEmail_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtEmpEmail.Text, pattern))
            {
                flag = 1;
            }
            else
            {
                flag = 0;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormEmployeeLogin objFormEmployeeLogin = new FormEmployeeLogin();
            this.Close();
            objFormEmployeeLogin.Show();
        }
    }
}
