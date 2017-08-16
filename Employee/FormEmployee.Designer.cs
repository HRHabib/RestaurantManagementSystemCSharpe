namespace RestaurantManagementSystem
{
    partial class FormEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRMS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDesig = new System.Windows.Forms.TextBox();
            this.txtDutytime = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblDutytime = new System.Windows.Forms.Label();
            this.lblDesig = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtOvertime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRMS
            // 
            this.lblRMS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRMS.Font = new System.Drawing.Font("Amatic SC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRMS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRMS.Location = new System.Drawing.Point(12, 9);
            this.lblRMS.Name = "lblRMS";
            this.lblRMS.Size = new System.Drawing.Size(458, 77);
            this.lblRMS.TabIndex = 1;
            this.lblRMS.Text = "RESTAURANT MANAGEMENT SYSTEM";
            this.lblRMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRMS.Click += new System.EventHandler(this.lblRMS_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.txtOvertime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDesig);
            this.panel1.Controls.Add(this.txtDutytime);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblDutytime);
            this.panel1.Controls.Add(this.lblDesig);
            this.panel1.Controls.Add(this.lblSalary);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 324);
            this.panel1.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(262, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // txtDesig
            // 
            this.txtDesig.Location = new System.Drawing.Point(147, 281);
            this.txtDesig.Name = "txtDesig";
            this.txtDesig.Size = new System.Drawing.Size(262, 20);
            this.txtDesig.TabIndex = 17;
            // 
            // txtDutytime
            // 
            this.txtDutytime.Location = new System.Drawing.Point(147, 209);
            this.txtDutytime.Name = "txtDutytime";
            this.txtDutytime.Size = new System.Drawing.Size(262, 20);
            this.txtDutytime.TabIndex = 16;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(147, 169);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(262, 20);
            this.txtSalary.TabIndex = 15;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(147, 91);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(262, 20);
            this.txtAge.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(262, 20);
            this.txtName.TabIndex = 13;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Window;
            this.btnLogout.Location = new System.Drawing.Point(369, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblDutytime
            // 
            this.lblDutytime.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDutytime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDutytime.Location = new System.Drawing.Point(48, 209);
            this.lblDutytime.Name = "lblDutytime";
            this.lblDutytime.Size = new System.Drawing.Size(80, 23);
            this.lblDutytime.TabIndex = 10;
            this.lblDutytime.Text = "DUTY TIME";
            this.lblDutytime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesig
            // 
            this.lblDesig.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesig.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDesig.Location = new System.Drawing.Point(36, 279);
            this.lblDesig.Name = "lblDesig";
            this.lblDesig.Size = new System.Drawing.Size(102, 23);
            this.lblDesig.TabIndex = 8;
            this.lblDesig.Text = "DESIGNATION";
            this.lblDesig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalary
            // 
            this.lblSalary.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSalary.Location = new System.Drawing.Point(58, 169);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(80, 23);
            this.lblSalary.TabIndex = 6;
            this.lblSalary.Text = "SALARY";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAge
            // 
            this.lblAge.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAge.Location = new System.Drawing.Point(61, 88);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(80, 23);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "AGE";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmail.Location = new System.Drawing.Point(58, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 23);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "EMAIL";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblName.Location = new System.Drawing.Point(58, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOvertime
            // 
            this.txtOvertime.Location = new System.Drawing.Point(147, 244);
            this.txtOvertime.Name = "txtOvertime";
            this.txtOvertime.Size = new System.Drawing.Size(262, 20);
            this.txtOvertime.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(48, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "OVERTIME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRMS);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRMS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblDutytime;
        private System.Windows.Forms.Label lblDesig;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDesig;
        private System.Windows.Forms.TextBox txtDutytime;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtOvertime;
        private System.Windows.Forms.Label label1;
    }
}