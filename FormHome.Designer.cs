namespace RestaurantManagementSystem
{
    partial class FormRMSAC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRMSAC));
            this.lblRMS = new System.Windows.Forms.Label();
            this.panelRMSMng = new System.Windows.Forms.Panel();
            this.btnManager = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelRMSMng.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRMS
            // 
            this.lblRMS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRMS.Font = new System.Drawing.Font("Amatic SC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRMS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRMS.Location = new System.Drawing.Point(12, 19);
            this.lblRMS.Name = "lblRMS";
            this.lblRMS.Size = new System.Drawing.Size(532, 77);
            this.lblRMS.TabIndex = 0;
            this.lblRMS.Text = "RESTAURANT MANAGEMENT SYSTEM";
            this.lblRMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRMSMng
            // 
            this.panelRMSMng.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelRMSMng.Controls.Add(this.btnManager);
            this.panelRMSMng.Location = new System.Drawing.Point(62, 124);
            this.panelRMSMng.Name = "panelRMSMng";
            this.panelRMSMng.Size = new System.Drawing.Size(162, 169);
            this.panelRMSMng.TabIndex = 1;
            // 
            // btnManager
            // 
            this.btnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.ForeColor = System.Drawing.Color.Crimson;
            this.btnManager.Image = ((System.Drawing.Image)(resources.GetObject("btnManager.Image")));
            this.btnManager.Location = new System.Drawing.Point(0, 0);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(162, 169);
            this.btnManager.TabIndex = 0;
            this.btnManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(80, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "MANAGER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Location = new System.Drawing.Point(326, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 169);
            this.panel1.TabIndex = 5;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(179, 169);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGreen;
            this.label3.Location = new System.Drawing.Point(351, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "EMPLOYEE";
            // 
            // FormRMSAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(556, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelRMSMng);
            this.Controls.Add(this.lblRMS);
            this.Name = "FormRMSAC";
            this.Text = "FormHome";
            this.panelRMSMng.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRMS;
        private System.Windows.Forms.Panel panelRMSMng;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Label label3;
    }
}

