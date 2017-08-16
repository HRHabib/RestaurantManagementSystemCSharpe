namespace RestaurantManagementSystem
{
    partial class FormEmployeeManagement
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
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpDuty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpOvertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOvertime = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lblDutytime = new System.Windows.Forms.Label();
            this.txtDutyTime = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.lblRMS.Size = new System.Drawing.Size(668, 83);
            this.lblRMS.TabIndex = 3;
            this.lblRMS.Text = "RESTAURANT MANAGEMENT SYSTEM";
            this.lblRMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colEmpName,
            this.colEmpEmail,
            this.colEmpSalary,
            this.colEmpDuty,
            this.colEmpOvertime,
            this.colEmpDes});
            this.dataGridViewEmployee.Location = new System.Drawing.Point(12, 131);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.Size = new System.Drawing.Size(668, 163);
            this.dataGridViewEmployee.TabIndex = 4;
            this.dataGridViewEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellContentClick);
            this.dataGridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            // 
            // colEmpName
            // 
            this.colEmpName.HeaderText = "Name";
            this.colEmpName.Name = "colEmpName";
            // 
            // colEmpEmail
            // 
            this.colEmpEmail.HeaderText = "Email";
            this.colEmpEmail.Name = "colEmpEmail";
            // 
            // colEmpSalary
            // 
            this.colEmpSalary.HeaderText = "Salary";
            this.colEmpSalary.Name = "colEmpSalary";
            // 
            // colEmpDuty
            // 
            this.colEmpDuty.HeaderText = "Duty Time";
            this.colEmpDuty.Name = "colEmpDuty";
            // 
            // colEmpOvertime
            // 
            this.colEmpOvertime.HeaderText = "Overtime (h)";
            this.colEmpOvertime.Name = "colEmpOvertime";
            // 
            // colEmpDes
            // 
            this.colEmpDes.HeaderText = "Designation";
            this.colEmpDes.Name = "colEmpDes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtOvertime);
            this.panel1.Controls.Add(this.lblDesignation);
            this.panel1.Controls.Add(this.txtDesignation);
            this.panel1.Controls.Add(this.lblDutytime);
            this.panel1.Controls.Add(this.txtDutyTime);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblSalary);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Location = new System.Drawing.Point(12, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 148);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Overtime";
            // 
            // txtOvertime
            // 
            this.txtOvertime.Location = new System.Drawing.Point(460, 71);
            this.txtOvertime.Name = "txtOvertime";
            this.txtOvertime.Size = new System.Drawing.Size(191, 20);
            this.txtOvertime.TabIndex = 12;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(6, 112);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(74, 13);
            this.lblDesignation.TabIndex = 11;
            this.lblDesignation.Text = "Designation";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(99, 109);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(191, 20);
            this.txtDesignation.TabIndex = 10;
            this.txtDesignation.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblDutytime
            // 
            this.lblDutytime.AutoSize = true;
            this.lblDutytime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDutytime.Location = new System.Drawing.Point(15, 73);
            this.lblDutytime.Name = "lblDutytime";
            this.lblDutytime.Size = new System.Drawing.Size(60, 13);
            this.lblDutytime.TabIndex = 9;
            this.lblDutytime.Text = "Duty time";
            // 
            // txtDutyTime
            // 
            this.txtDutyTime.Location = new System.Drawing.Point(99, 70);
            this.txtDutyTime.Name = "txtDutyTime";
            this.txtDutyTime.Size = new System.Drawing.Size(191, 20);
            this.txtDutyTime.TabIndex = 8;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(53, 36);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(99, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(191, 20);
            this.txtId.TabIndex = 6;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(384, 37);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(42, 13);
            this.lblSalary.TabIndex = 5;
            this.lblSalary.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(462, 31);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(191, 20);
            this.txtSalary.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPTIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(12, 104);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(70, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPTIONToolStripMenuItem
            // 
            this.oPTIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dELETEToolStripMenuItem,
            this.uPDATEToolStripMenuItem,
            this.bACKToolStripMenuItem,
            this.lOGOUTToolStripMenuItem1});
            this.oPTIONToolStripMenuItem.Name = "oPTIONToolStripMenuItem";
            this.oPTIONToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.oPTIONToolStripMenuItem.Text = "Manage";
            this.oPTIONToolStripMenuItem.Click += new System.EventHandler(this.oPTIONToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // uPDATEToolStripMenuItem
            // 
            this.uPDATEToolStripMenuItem.Name = "uPDATEToolStripMenuItem";
            this.uPDATEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uPDATEToolStripMenuItem.Text = "UPDATE";
            this.uPDATEToolStripMenuItem.Click += new System.EventHandler(this.uPDATEToolStripMenuItem_Click);
            // 
            // bACKToolStripMenuItem
            // 
            this.bACKToolStripMenuItem.Name = "bACKToolStripMenuItem";
            this.bACKToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bACKToolStripMenuItem.Text = "BACK";
            this.bACKToolStripMenuItem.Click += new System.EventHandler(this.bACKToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem1
            // 
            this.lOGOUTToolStripMenuItem1.Name = "lOGOUTToolStripMenuItem1";
            this.lOGOUTToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.lOGOUTToolStripMenuItem1.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem1.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem1_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(580, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 12;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(692, 489);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.lblRMS);
            this.Name = "FormEmployeeManagement";
            this.Text = "FormEmployeeManagement";
            this.Load += new System.EventHandler(this.FormEmployeeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRMS;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label lblDutytime;
        private System.Windows.Forms.TextBox txtDutyTime;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOvertime;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpDuty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpOvertime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpDes;
    }
}