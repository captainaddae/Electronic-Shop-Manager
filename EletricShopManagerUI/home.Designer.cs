namespace EletricShopManagerUI
{
    partial class home
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paySalariesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payUtilityBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenditureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 491);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(935, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSalmon;
            this.menuStrip1.BackgroundImage = global::EletricShopManagerUI.Properties.Resources.ele_sh_man_new;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.manageProductsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.fileToolStripMenuItem.Text = "Manage";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addUserToolStripMenuItem.Text = "Users";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // manageProductsToolStripMenuItem
            // 
            this.manageProductsToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.manageProductsToolStripMenuItem.Name = "manageProductsToolStripMenuItem";
            this.manageProductsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manageProductsToolStripMenuItem.Text = "Products";
            this.manageProductsToolStripMenuItem.Click += new System.EventHandler(this.manageProductsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyProductToolStripMenuItem,
            this.paySalariesToolStripMenuItem,
            this.payUtilityBillsToolStripMenuItem});
            this.manageToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.manageToolStripMenuItem.Text = "Transactions";
            // 
            // buyProductToolStripMenuItem
            // 
            this.buyProductToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.buyProductToolStripMenuItem.Name = "buyProductToolStripMenuItem";
            this.buyProductToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.buyProductToolStripMenuItem.Text = "Buy ";
            this.buyProductToolStripMenuItem.Click += new System.EventHandler(this.buyProductToolStripMenuItem_Click);
            // 
            // paySalariesToolStripMenuItem
            // 
            this.paySalariesToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.paySalariesToolStripMenuItem.Name = "paySalariesToolStripMenuItem";
            this.paySalariesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.paySalariesToolStripMenuItem.Text = "Pay Salaries";
            this.paySalariesToolStripMenuItem.Click += new System.EventHandler(this.paySalariesToolStripMenuItem_Click);
            // 
            // payUtilityBillsToolStripMenuItem
            // 
            this.payUtilityBillsToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.payUtilityBillsToolStripMenuItem.Name = "payUtilityBillsToolStripMenuItem";
            this.payUtilityBillsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.payUtilityBillsToolStripMenuItem.Text = "Expenses";
            this.payUtilityBillsToolStripMenuItem.Click += new System.EventHandler(this.payUtilityBillsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allProductsToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.salesSummaryToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.authorInfoToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // allProductsToolStripMenuItem
            // 
            this.allProductsToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.allProductsToolStripMenuItem.Name = "allProductsToolStripMenuItem";
            this.allProductsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.allProductsToolStripMenuItem.Text = "All Products";
            this.allProductsToolStripMenuItem.Click += new System.EventHandler(this.allProductsToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // salesSummaryToolStripMenuItem
            // 
            this.salesSummaryToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.salesSummaryToolStripMenuItem.Name = "salesSummaryToolStripMenuItem";
            this.salesSummaryToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.salesSummaryToolStripMenuItem.Text = "Sales Summary";
            this.salesSummaryToolStripMenuItem.Click += new System.EventHandler(this.salesSummaryToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem1,
            this.salaryToolStripMenuItem,
            this.expenditureToolStripMenuItem});
            this.salesToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.salesToolStripMenuItem.Text = "Report";
            // 
            // salesToolStripMenuItem1
            // 
            this.salesToolStripMenuItem1.ForeColor = System.Drawing.Color.Maroon;
            this.salesToolStripMenuItem1.Name = "salesToolStripMenuItem1";
            this.salesToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.salesToolStripMenuItem1.Text = "Sales";
            this.salesToolStripMenuItem1.Click += new System.EventHandler(this.salesToolStripMenuItem1_Click);
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.salaryToolStripMenuItem.Text = "Salary";
            this.salaryToolStripMenuItem.Click += new System.EventHandler(this.salaryToolStripMenuItem_Click);
            // 
            // expenditureToolStripMenuItem
            // 
            this.expenditureToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.expenditureToolStripMenuItem.Name = "expenditureToolStripMenuItem";
            this.expenditureToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.expenditureToolStripMenuItem.Text = "Expenditure";
            this.expenditureToolStripMenuItem.Click += new System.EventHandler(this.expenditureToolStripMenuItem_Click);
            // 
            // authorInfoToolStripMenuItem
            // 
            this.authorInfoToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.authorInfoToolStripMenuItem.Name = "authorInfoToolStripMenuItem";
            this.authorInfoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.authorInfoToolStripMenuItem.Text = "Author Info";
            this.authorInfoToolStripMenuItem.Click += new System.EventHandler(this.authorInfoToolStripMenuItem_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(935, 513);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Electric Shop Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.home_FormClosed);
            this.Load += new System.EventHandler(this.home_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorInfoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paySalariesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payUtilityBillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenditureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductsToolStripMenuItem;
    }
}