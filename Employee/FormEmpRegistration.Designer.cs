namespace RestaurantManagementSystem
{
    partial class FormEmpRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpRegistration));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmpCPass = new System.Windows.Forms.TextBox();
            this.lblEmpCPass = new System.Windows.Forms.Label();
            this.txtEmpPass = new System.Windows.Forms.TextBox();
            this.txtEmpAge = new System.Windows.Forms.TextBox();
            this.lblEmpPass = new System.Windows.Forms.Label();
            this.lblEmpAge = new System.Windows.Forms.Label();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblEmpEmail = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.btnEmpSignUp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(118, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registration Form";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.txtEmpCPass);
            this.panel1.Controls.Add(this.lblEmpCPass);
            this.panel1.Controls.Add(this.txtEmpPass);
            this.panel1.Controls.Add(this.txtEmpAge);
            this.panel1.Controls.Add(this.lblEmpPass);
            this.panel1.Controls.Add(this.lblEmpAge);
            this.panel1.Controls.Add(this.txtEmpEmail);
            this.panel1.Controls.Add(this.txtEmpName);
            this.panel1.Controls.Add(this.lblEmpEmail);
            this.panel1.Controls.Add(this.lblEmpName);
            this.panel1.Location = new System.Drawing.Point(12, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 226);
            this.panel1.TabIndex = 2;
            // 
            // txtEmpCPass
            // 
            this.txtEmpCPass.Location = new System.Drawing.Point(181, 184);
            this.txtEmpCPass.Name = "txtEmpCPass";
            this.txtEmpCPass.PasswordChar = '*';
            this.txtEmpCPass.Size = new System.Drawing.Size(172, 20);
            this.txtEmpCPass.TabIndex = 9;
            // 
            // lblEmpCPass
            // 
            this.lblEmpCPass.AutoSize = true;
            this.lblEmpCPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpCPass.Location = new System.Drawing.Point(16, 184);
            this.lblEmpCPass.Name = "lblEmpCPass";
            this.lblEmpCPass.Size = new System.Drawing.Size(138, 13);
            this.lblEmpCPass.TabIndex = 8;
            this.lblEmpCPass.Text = "CONFIRM PASSWORD";
            // 
            // txtEmpPass
            // 
            this.txtEmpPass.Location = new System.Drawing.Point(180, 143);
            this.txtEmpPass.Name = "txtEmpPass";
            this.txtEmpPass.PasswordChar = '*';
            this.txtEmpPass.Size = new System.Drawing.Size(172, 20);
            this.txtEmpPass.TabIndex = 7;
            // 
            // txtEmpAge
            // 
            this.txtEmpAge.Location = new System.Drawing.Point(180, 102);
            this.txtEmpAge.Name = "txtEmpAge";
            this.txtEmpAge.Size = new System.Drawing.Size(172, 20);
            this.txtEmpAge.TabIndex = 6;
            // 
            // lblEmpPass
            // 
            this.lblEmpPass.AutoSize = true;
            this.lblEmpPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpPass.Location = new System.Drawing.Point(76, 146);
            this.lblEmpPass.Name = "lblEmpPass";
            this.lblEmpPass.Size = new System.Drawing.Size(78, 13);
            this.lblEmpPass.TabIndex = 5;
            this.lblEmpPass.Text = "PASSWORD";
            // 
            // lblEmpAge
            // 
            this.lblEmpAge.AutoSize = true;
            this.lblEmpAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpAge.Location = new System.Drawing.Point(122, 105);
            this.lblEmpAge.Name = "lblEmpAge";
            this.lblEmpAge.Size = new System.Drawing.Size(32, 13);
            this.lblEmpAge.TabIndex = 4;
            this.lblEmpAge.Text = "AGE";
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(179, 59);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(172, 20);
            this.txtEmpEmail.TabIndex = 3;
            this.txtEmpEmail.TextChanged += new System.EventHandler(this.txtEmpEmail_TextChanged);
            this.txtEmpEmail.Leave += new System.EventHandler(this.btnEmpSignUp_Click);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(179, 18);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(172, 20);
            this.txtEmpName.TabIndex = 2;
            // 
            // lblEmpEmail
            // 
            this.lblEmpEmail.AutoSize = true;
            this.lblEmpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpEmail.Location = new System.Drawing.Point(110, 59);
            this.lblEmpEmail.Name = "lblEmpEmail";
            this.lblEmpEmail.Size = new System.Drawing.Size(44, 13);
            this.lblEmpEmail.TabIndex = 1;
            this.lblEmpEmail.Text = "EMAIL";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(112, 25);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(42, 13);
            this.lblEmpName.TabIndex = 0;
            this.lblEmpName.Text = "NAME";
            // 
            // btnEmpSignUp
            // 
            this.btnEmpSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpSignUp.Location = new System.Drawing.Point(278, 429);
            this.btnEmpSignUp.Name = "btnEmpSignUp";
            this.btnEmpSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnEmpSignUp.TabIndex = 3;
            this.btnEmpSignUp.Text = "SIGN UP";
            this.btnEmpSignUp.UseVisualStyleBackColor = true;
            this.btnEmpSignUp.Click += new System.EventHandler(this.btnEmpSignUp_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(359, 429);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormEmpRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(437, 483);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEmpSignUp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormEmpRegistration";
            this.Text = "FormEmpRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmpEmail;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.TextBox txtEmpCPass;
        private System.Windows.Forms.Label lblEmpCPass;
        private System.Windows.Forms.TextBox txtEmpPass;
        private System.Windows.Forms.TextBox txtEmpAge;
        private System.Windows.Forms.Label lblEmpPass;
        private System.Windows.Forms.Label lblEmpAge;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Button btnEmpSignUp;
        private System.Windows.Forms.Button btnBack;
    }
}