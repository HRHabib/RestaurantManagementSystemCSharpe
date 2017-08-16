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
    public partial class FormRMSAC : Form
    {
        public FormRMSAC()
        {
            InitializeComponent();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            FormManagerLogin objFormManagerLogin = new FormManagerLogin();
            this.Hide();
            objFormManagerLogin.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FormEmployeeLogin objFormEmployeeLogin = new FormEmployeeLogin();
            this.Hide();
            objFormEmployeeLogin.Show();
        }
    }
}
