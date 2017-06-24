namespace Harrison.Inventory.WinForm
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.districtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rPSVendorMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clustersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clusterDistrictMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialYearsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem,
            this.transationsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taxDetailsToolStripMenuItem,
            this.stateToolStripMenuItem,
            this.districtsToolStripMenuItem,
            this.bankToolStripMenuItem,
            this.vendorsToolStripMenuItem,
            this.rPSToolStripMenuItem,
            this.rPSVendorMappingToolStripMenuItem,
            this.clustersToolStripMenuItem,
            this.clusterDistrictMappingToolStripMenuItem,
            this.financialYearsToolStripMenuItem});
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // taxDetailsToolStripMenuItem
            // 
            this.taxDetailsToolStripMenuItem.Name = "taxDetailsToolStripMenuItem";
            this.taxDetailsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.taxDetailsToolStripMenuItem.Text = "Tax Details";
            this.taxDetailsToolStripMenuItem.Click += new System.EventHandler(this.taxDetailsToolStripMenuItem_Click);
            // 
            // stateToolStripMenuItem
            // 
            this.stateToolStripMenuItem.Name = "stateToolStripMenuItem";
            this.stateToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.stateToolStripMenuItem.Text = "State";
            // 
            // districtsToolStripMenuItem
            // 
            this.districtsToolStripMenuItem.Name = "districtsToolStripMenuItem";
            this.districtsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.districtsToolStripMenuItem.Text = "Districts";
            this.districtsToolStripMenuItem.Click += new System.EventHandler(this.districtsToolStripMenuItem_Click);
            // 
            // bankToolStripMenuItem
            // 
            this.bankToolStripMenuItem.Name = "bankToolStripMenuItem";
            this.bankToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.bankToolStripMenuItem.Text = "Bank";
            // 
            // vendorsToolStripMenuItem
            // 
            this.vendorsToolStripMenuItem.Name = "vendorsToolStripMenuItem";
            this.vendorsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.vendorsToolStripMenuItem.Text = "Vendors";
            this.vendorsToolStripMenuItem.Click += new System.EventHandler(this.vendorsToolStripMenuItem_Click);
            // 
            // rPSToolStripMenuItem
            // 
            this.rPSToolStripMenuItem.Name = "rPSToolStripMenuItem";
            this.rPSToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.rPSToolStripMenuItem.Text = "RPS";
            // 
            // rPSVendorMappingToolStripMenuItem
            // 
            this.rPSVendorMappingToolStripMenuItem.Name = "rPSVendorMappingToolStripMenuItem";
            this.rPSVendorMappingToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.rPSVendorMappingToolStripMenuItem.Text = "RPS-Vendor-Mapping";
            // 
            // clustersToolStripMenuItem
            // 
            this.clustersToolStripMenuItem.Name = "clustersToolStripMenuItem";
            this.clustersToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.clustersToolStripMenuItem.Text = "Clusters";
            // 
            // clusterDistrictMappingToolStripMenuItem
            // 
            this.clusterDistrictMappingToolStripMenuItem.Name = "clusterDistrictMappingToolStripMenuItem";
            this.clusterDistrictMappingToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.clusterDistrictMappingToolStripMenuItem.Text = "Cluster-District Mapping";
            // 
            // transationsToolStripMenuItem
            // 
            this.transationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.transationToolStripMenuItem});
            this.transationsToolStripMenuItem.Name = "transationsToolStripMenuItem";
            this.transationsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.transationsToolStripMenuItem.Text = "Transations";
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.invoiceToolStripMenuItem.Text = "Invoice Details";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // transationToolStripMenuItem
            // 
            this.transationToolStripMenuItem.Name = "transationToolStripMenuItem";
            this.transationToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.transationToolStripMenuItem.Text = "Transportation&Barrel  Issue & Recipt";
            this.transationToolStripMenuItem.Click += new System.EventHandler(this.transationToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // financialYearsToolStripMenuItem
            // 
            this.financialYearsToolStripMenuItem.Name = "financialYearsToolStripMenuItem";
            this.financialYearsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.financialYearsToolStripMenuItem.Text = "Financial Years";
            this.financialYearsToolStripMenuItem.Click += new System.EventHandler(this.financialYearsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(757, 521);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem districtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clustersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clusterDistrictMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rPSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rPSVendorMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financialYearsToolStripMenuItem;
    }
}