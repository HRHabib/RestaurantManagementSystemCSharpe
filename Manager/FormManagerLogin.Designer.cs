namespace RestaurantManagementSystem
{
    partial class FormManagerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagerLogin));
            this.lblMngUsername = new System.Windows.Forms.Label();
            this.lblMngPassword = new System.Windows.Forms.Label();
            this.txtMngEmail = new System.Windows.Forms.TextBox();
            this.txtMngPassword = new System.Windows.Forms.TextBox();
            this.btnMngLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMngUsername
            // 
            this.lblMngUsername.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMngUsername.Location = new System.Drawing.Point(37, 74);
            this.lblMngUsername.Name = "lblMngUsername";
            this.lblMngUsername.Size = new System.Drawing.Size(100, 23);
            this.lblMngUsername.TabIndex = 0;
            this.lblMngUsername.Text = "EMAIL";
            this.lblMngUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMngUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMngPassword
            // 
            this.lblMngPassword.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMngPassword.Location = new System.Drawing.Point(11, 126);
            this.lblMngPassword.Name = "lblMngPassword";
            this.lblMngPassword.Size = new System.Drawing.Size(116, 23);
            this.lblMngPassword.TabIndex = 1;
            this.lblMngPassword.Text = "PASSWORD";
            this.lblMngPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMngEmail
            // 
            this.txtMngEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMngEmail.Location = new System.Drawing.Point(161, 74);
            this.txtMngEmail.Name = "txtMngEmail";
            this.txtMngEmail.Size = new System.Drawing.Size(179, 20);
            this.txtMngEmail.TabIndex = 2;
            // 
            // txtMngPassword
            // 
            this.txtMngPassword.Location = new System.Drawing.Point(161, 128);
            this.txtMngPassword.Name = "txtMngPassword";
            this.txtMngPassword.PasswordChar = '*';
            this.txtMngPassword.Size = new System.Drawing.Size(179, 20);
            this.txtMngPassword.TabIndex = 3;
            // 
            // btnMngLogin
            // 
            this.btnMngLogin.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngLogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnMngLogin.Location = new System.Drawing.Point(224, 188);
            this.btnMngLogin.Name = "btnMngLogin";
            this.btnMngLogin.Size = new System.Drawing.Size(116, 58);
            this.btnMngLogin.TabIndex = 4;
            this.btnMngLogin.Text = "Login";
            this.btnMngLogin.UseVisualStyleBackColor = true;
            this.btnMngLogin.Click += new System.EventHandler(this.btnMngLogin_Click);
            // 
            // FormManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(394, 288);
            this.Controls.Add(this.btnMngLogin);
            this.Controls.Add(this.txtMngPassword);
            this.Controls.Add(this.txtMngEmail);
            this.Controls.Add(this.lblMngPassword);
            this.Controls.Add(this.lblMngUsername);
            this.Name = "FormManagerLogin";
            this.Text = "FormManagerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMngUsername;
        private System.Windows.Forms.Label lblMngPassword;
        private System.Windows.Forms.TextBox txtMngEmail;
        private System.Windows.Forms.TextBox txtMngPassword;
        private System.Windows.Forms.Button btnMngLogin;
    }
}