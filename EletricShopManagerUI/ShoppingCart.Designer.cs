namespace EletricShopManagerUI
{
    partial class ShoppingCart
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
            this.ProductList = new System.Windows.Forms.ListBox();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.BackColor = System.Drawing.Color.Maroon;
            this.ProductList.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductList.ForeColor = System.Drawing.Color.White;
            this.ProductList.FormattingEnabled = true;
            this.ProductList.ItemHeight = 27;
            this.ProductList.Location = new System.Drawing.Point(579, 12);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(360, 463);
            this.ProductList.TabIndex = 0;
            // 
            // txtEdit
            // 
            this.txtEdit.BackColor = System.Drawing.Color.Maroon;
            this.txtEdit.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdit.Location = new System.Drawing.Point(16, 12);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(557, 35);
            this.txtEdit.TabIndex = 2;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Maroon;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(12, 488);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(317, 43);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(649, 486);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 46);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Maroon;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(777, 488);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(162, 40);
            this.txtTotal.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(329, 488);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(318, 43);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.Maroon;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(541, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Items";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 419);
            this.tabControl1.TabIndex = 1;
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(948, 538);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ProductList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(964, 577);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(964, 577);
            this.Name = "ShoppingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Cart";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
    }
}