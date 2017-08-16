namespace RestaurantManagementSystem
{
    partial class FormCost
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
            this.panelCost = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dataGridViewEmpCost = new System.Windows.Forms.DataGridView();
            this.colEmpSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpOvertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpDaySalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRMS = new System.Windows.Forms.Label();
            this.menuStripOption = new System.Windows.Forms.MenuStrip();
            this.clickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailySellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCost = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRawCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMng = new System.Windows.Forms.Label();
            this.panelCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpCost)).BeginInit();
            this.menuStripOption.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCost
            // 
            this.panelCost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCost.Controls.Add(this.btnSelect);
            this.panelCost.Controls.Add(this.dataGridViewEmpCost);
            this.panelCost.Location = new System.Drawing.Point(159, 151);
            this.panelCost.Name = "panelCost";
            this.panelCost.Size = new System.Drawing.Size(497, 178);
            this.panelCost.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(398, 146);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dataGridViewEmpCost
            // 
            this.dataGridViewEmpCost.AllowUserToAddRows = false;
            this.dataGridViewEmpCost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmpCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpCost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpSelect,
            this.colEmpName,
            this.colEmpSalary,
            this.colEmpOvertime,
            this.colEmpDaySalary});
            this.dataGridViewEmpCost.Location = new System.Drawing.Point(13, 10);
            this.dataGridViewEmpCost.Name = "dataGridViewEmpCost";
            this.dataGridViewEmpCost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmpCost.Size = new System.Drawing.Size(460, 130);
            this.dataGridViewEmpCost.TabIndex = 0;
            this.dataGridViewEmpCost.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpCost_CellClick);
            this.dataGridViewEmpCost.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpCost_CellContentClick);
            this.dataGridViewEmpCost.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewEmpCost_MouseClick);
            // 
            // colEmpSelect
            // 
            this.colEmpSelect.HeaderText = "Select";
            this.colEmpSelect.Name = "colEmpSelect";
            this.colEmpSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEmpSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colEmpName
            // 
            this.colEmpName.HeaderText = "Name";
            this.colEmpName.Name = "colEmpName";
            // 
            // colEmpSalary
            // 
            this.colEmpSalary.HeaderText = "Salary";
            this.colEmpSalary.Name = "colEmpSalary";
            // 
            // colEmpOvertime
            // 
            this.colEmpOvertime.HeaderText = "Overtime(h)";
            this.colEmpOvertime.Name = "colEmpOvertime";
            // 
            // colEmpDaySalary
            // 
            this.colEmpDaySalary.HeaderText = "Per Day Salary";
            this.colEmpDaySalary.Name = "colEmpDaySalary";
            // 
            // lblRMS
            // 
            this.lblRMS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRMS.Font = new System.Drawing.Font("Amatic SC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRMS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRMS.Location = new System.Drawing.Point(12, 9);
            this.lblRMS.Name = "lblRMS";
            this.lblRMS.Size = new System.Drawing.Size(644, 83);
            this.lblRMS.TabIndex = 3;
            this.lblRMS.Text = "RESTAURANT MANAGEMENT SYSTEM";
            this.lblRMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStripOption
            // 
            this.menuStripOption.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickToolStripMenuItem});
            this.menuStripOption.Location = new System.Drawing.Point(11, 150);
            this.menuStripOption.Name = "menuStripOption";
            this.menuStripOption.Size = new System.Drawing.Size(70, 24);
            this.menuStripOption.TabIndex = 6;
            this.menuStripOption.Text = "menuStrip1";
            // 
            // clickToolStripMenuItem
            // 
            this.clickToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailySellToolStripMenuItem,
            this.dailyCostToolStripMenuItem,
            this.pROFITToolStripMenuItem,
            this.bACKToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.clickToolStripMenuItem.Name = "clickToolStripMenuItem";
            this.clickToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.clickToolStripMenuItem.Text = "Manage";
            // 
            // dailySellToolStripMenuItem
            // 
            this.dailySellToolStripMenuItem.Name = "dailySellToolStripMenuItem";
            this.dailySellToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dailySellToolStripMenuItem.Text = "Daily Sell";
            this.dailySellToolStripMenuItem.Click += new System.EventHandler(this.dailySellToolStripMenuItem_Click);
            // 
            // dailyCostToolStripMenuItem
            // 
            this.dailyCostToolStripMenuItem.Name = "dailyCostToolStripMenuItem";
            this.dailyCostToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dailyCostToolStripMenuItem.Text = "Daily Cost";
            this.dailyCostToolStripMenuItem.Click += new System.EventHandler(this.dailyCostToolStripMenuItem_Click);
            // 
            // pROFITToolStripMenuItem
            // 
            this.pROFITToolStripMenuItem.Name = "pROFITToolStripMenuItem";
            this.pROFITToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pROFITToolStripMenuItem.Text = "PROFIT";
            this.pROFITToolStripMenuItem.Click += new System.EventHandler(this.pROFITToolStripMenuItem_Click);
            // 
            // bACKToolStripMenuItem
            // 
            this.bACKToolStripMenuItem.Name = "bACKToolStripMenuItem";
            this.bACKToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bACKToolStripMenuItem.Text = "BACK";
            this.bACKToolStripMenuItem.Click += new System.EventHandler(this.bACKToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.btnCost);
            this.panel1.Controls.Add(this.txtCost);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtRawCost);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(159, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 129);
            this.panel1.TabIndex = 7;
            // 
            // btnCost
            // 
            this.btnCost.Location = new System.Drawing.Point(398, 92);
            this.btnCost.Name = "btnCost";
            this.btnCost.Size = new System.Drawing.Size(75, 23);
            this.btnCost.TabIndex = 4;
            this.btnCost.Text = "Cost";
            this.btnCost.UseVisualStyleBackColor = true;
            this.btnCost.Click += new System.EventHandler(this.btnCost_Click);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(142, 68);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(174, 20);
            this.txtCost.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "OTHERS COST";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRawCost
            // 
            this.txtRawCost.Location = new System.Drawing.Point(142, 22);
            this.txtRawCost.Name = "txtRawCost";
            this.txtRawCost.Size = new System.Drawing.Size(174, 20);
            this.txtRawCost.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "RAW COST";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(556, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 24);
            this.lblName.TabIndex = 14;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMng
            // 
            this.lblMng.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblMng.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMng.ForeColor = System.Drawing.Color.Crimson;
            this.lblMng.Location = new System.Drawing.Point(12, 99);
            this.lblMng.Name = "lblMng";
            this.lblMng.Size = new System.Drawing.Size(644, 23);
            this.lblMng.TabIndex = 15;
            this.lblMng.Text = "MANAGER";
            this.lblMng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(668, 475);
            this.Controls.Add(this.lblMng);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStripOption);
            this.Controls.Add(this.lblRMS);
            this.Controls.Add(this.panelCost);
            this.Name = "FormCost";
            this.Text = "FormCost";
            this.panelCost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpCost)).EndInit();
            this.menuStripOption.ResumeLayout(false);
            this.menuStripOption.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCost;
        private System.Windows.Forms.Label lblRMS;
        private System.Windows.Forms.MenuStrip menuStripOption;
        private System.Windows.Forms.ToolStripMenuItem clickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailySellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROFITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewEmpCost;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRawCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCost;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMng;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEmpSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpOvertime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpDaySalary;
    }
}