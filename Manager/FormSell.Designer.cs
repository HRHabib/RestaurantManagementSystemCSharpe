namespace RestaurantManagementSystem
{
    partial class FormSell
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
            this.panelDailySell = new System.Windows.Forms.Panel();
            this.dataGridViewFoodSell = new System.Windows.Forms.DataGridView();
            this.colSellId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStripOption = new System.Windows.Forms.MenuStrip();
            this.clickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailySellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMng = new System.Windows.Forms.Label();
            this.panelDailySell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoodSell)).BeginInit();
            this.menuStripOption.SuspendLayout();
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
            this.lblRMS.TabIndex = 2;
            this.lblRMS.Text = "RESTAURANT MANAGEMENT SYSTEM";
            this.lblRMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDailySell
            // 
            this.panelDailySell.Controls.Add(this.dataGridViewFoodSell);
            this.panelDailySell.Controls.Add(this.btnClose);
            this.panelDailySell.Location = new System.Drawing.Point(173, 164);
            this.panelDailySell.Name = "panelDailySell";
            this.panelDailySell.Size = new System.Drawing.Size(483, 267);
            this.panelDailySell.TabIndex = 5;
            // 
            // dataGridViewFoodSell
            // 
            this.dataGridViewFoodSell.AllowUserToAddRows = false;
            this.dataGridViewFoodSell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFoodSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFoodSell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSellId,
            this.colSellAmount});
            this.dataGridViewFoodSell.Location = new System.Drawing.Point(3, 11);
            this.dataGridViewFoodSell.Name = "dataGridViewFoodSell";
            this.dataGridViewFoodSell.Size = new System.Drawing.Size(476, 179);
            this.dataGridViewFoodSell.TabIndex = 0;
            // 
            // colSellId
            // 
            this.colSellId.HeaderText = "Sell ID";
            this.colSellId.Name = "colSellId";
            // 
            // colSellAmount
            // 
            this.colSellAmount.HeaderText = "Amount";
            this.colSellAmount.Name = "colSellAmount";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(336, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuStripOption
            // 
            this.menuStripOption.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickToolStripMenuItem});
            this.menuStripOption.Location = new System.Drawing.Point(15, 164);
            this.menuStripOption.Name = "menuStripOption";
            this.menuStripOption.Size = new System.Drawing.Size(70, 24);
            this.menuStripOption.TabIndex = 0;
            this.menuStripOption.Text = "menuStrip1";
            // 
            // clickToolStripMenuItem
            // 
            this.clickToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailySellToolStripMenuItem,
            this.dailyCostToolStripMenuItem,
            this.pROFITToolStripMenuItem,
            this.bACKToolStripMenuItem,
            this.lOGOUTToolStripMenuItem1});
            this.clickToolStripMenuItem.Name = "clickToolStripMenuItem";
            this.clickToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.clickToolStripMenuItem.Text = "Manage";
            this.clickToolStripMenuItem.Click += new System.EventHandler(this.clickToolStripMenuItem_Click);
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
            this.lblName.Location = new System.Drawing.Point(554, 136);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 13;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblMng
            // 
            this.lblMng.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblMng.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMng.ForeColor = System.Drawing.Color.Crimson;
            this.lblMng.Location = new System.Drawing.Point(12, 102);
            this.lblMng.Name = "lblMng";
            this.lblMng.Size = new System.Drawing.Size(644, 30);
            this.lblMng.TabIndex = 14;
            this.lblMng.Text = "MANAGER";
            this.lblMng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(668, 475);
            this.Controls.Add(this.lblMng);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panelDailySell);
            this.Controls.Add(this.menuStripOption);
            this.Controls.Add(this.lblRMS);
            this.MainMenuStrip = this.menuStripOption;
            this.Name = "FormSell";
            this.Text = "FormPayment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.panelDailySell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoodSell)).EndInit();
            this.menuStripOption.ResumeLayout(false);
            this.menuStripOption.PerformLayout();
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
        private System.Windows.Forms.Panel panelDailySell;
        private System.Windows.Forms.DataGridView dataGridViewFoodSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellAmount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMng;
    }
}