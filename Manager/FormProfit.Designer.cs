namespace RestaurantManagementSystem
{
    partial class FormProfit
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
            this.menuStripOption = new System.Windows.Forms.MenuStrip();
            this.clickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailySellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelProfit = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewprofit = new System.Windows.Forms.DataGridView();
            this.colProfitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfitEarn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMng = new System.Windows.Forms.Label();
            this.menuStripOption.SuspendLayout();
            this.panelProfit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprofit)).BeginInit();
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
            this.menuStripOption.Location = new System.Drawing.Point(9, 165);
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
            // panelProfit
            // 
            this.panelProfit.Controls.Add(this.label2);
            this.panelProfit.Controls.Add(this.dataGridViewprofit);
            this.panelProfit.Location = new System.Drawing.Point(144, 165);
            this.panelProfit.Name = "panelProfit";
            this.panelProfit.Size = new System.Drawing.Size(512, 276);
            this.panelProfit.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(11, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "PROFIT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewprofit
            // 
            this.dataGridViewprofit.AllowUserToAddRows = false;
            this.dataGridViewprofit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewprofit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewprofit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProfitDate,
            this.colProfitEarn,
            this.colProfitCost,
            this.colProfit});
            this.dataGridViewprofit.Location = new System.Drawing.Point(14, 43);
            this.dataGridViewprofit.Name = "dataGridViewprofit";
            this.dataGridViewprofit.Size = new System.Drawing.Size(488, 206);
            this.dataGridViewprofit.TabIndex = 0;
            // 
            // colProfitDate
            // 
            this.colProfitDate.HeaderText = "Date";
            this.colProfitDate.Name = "colProfitDate";
            // 
            // colProfitEarn
            // 
            this.colProfitEarn.HeaderText = "Sell";
            this.colProfitEarn.Name = "colProfitEarn";
            // 
            // colProfitCost
            // 
            this.colProfitCost.HeaderText = "Cost";
            this.colProfitCost.Name = "colProfitCost";
            // 
            // colProfit
            // 
            this.colProfit.HeaderText = "Profit";
            this.colProfit.Name = "colProfit";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(556, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 14;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMng
            // 
            this.lblMng.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblMng.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMng.ForeColor = System.Drawing.Color.Crimson;
            this.lblMng.Location = new System.Drawing.Point(12, 103);
            this.lblMng.Name = "lblMng";
            this.lblMng.Size = new System.Drawing.Size(644, 30);
            this.lblMng.TabIndex = 15;
            this.lblMng.Text = "MANAGER";
            this.lblMng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(668, 475);
            this.Controls.Add(this.lblMng);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panelProfit);
            this.Controls.Add(this.menuStripOption);
            this.Controls.Add(this.lblRMS);
            this.Name = "FormProfit";
            this.Text = "FormProfit";
            this.menuStripOption.ResumeLayout(false);
            this.menuStripOption.PerformLayout();
            this.panelProfit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprofit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRMS;
        private System.Windows.Forms.MenuStrip menuStripOption;
        private System.Windows.Forms.ToolStripMenuItem clickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailySellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROFITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem;
        private System.Windows.Forms.Panel panelProfit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewprofit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfitEarn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfit;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMng;
    }
}