namespace EletricShopManagerUI
{
    partial class Stock
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
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnAdd = new EletricShopManagerUI.Animated_Button();
            this.BtnReportViewer = new EletricShopManagerUI.Animated_Button();
            this.BtnDelete = new EletricShopManagerUI.Animated_Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Search
            // 
            this.Txt_Search.BackColor = System.Drawing.Color.Maroon;
            this.Txt_Search.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Search.ForeColor = System.Drawing.Color.White;
            this.Txt_Search.Location = new System.Drawing.Point(128, 13);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(805, 29);
            this.Txt_Search.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productid,
            this.img,
            this.name,
            this.category,
            this.price,
            this.qty,
            this.choose});
            this.dataGridView1.Location = new System.Drawing.Point(20, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(912, 500);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(58, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // productid
            // 
            this.productid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productid.HeaderText = "Product ID";
            this.productid.Name = "productid";
            this.productid.ReadOnly = true;
            this.productid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productid.Width = 64;
            // 
            // img
            // 
            this.img.HeaderText = "Image";
            this.img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.img.Name = "img";
            this.img.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // choose
            // 
            this.choose.HeaderText = "Select";
            this.choose.Name = "choose";
            this.choose.ReadOnly = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.Maroon;
            this.BtnAdd.IsMouseDown = false;
            this.BtnAdd.IsMouseOver = false;
            this.BtnAdd.Location = new System.Drawing.Point(684, 558);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(106, 29);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnReportViewer
            // 
            this.BtnReportViewer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReportViewer.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportViewer.ForeColor = System.Drawing.Color.Maroon;
            this.BtnReportViewer.IsMouseDown = false;
            this.BtnReportViewer.IsMouseOver = false;
            this.BtnReportViewer.Location = new System.Drawing.Point(545, 558);
            this.BtnReportViewer.Name = "BtnReportViewer";
            this.BtnReportViewer.Size = new System.Drawing.Size(106, 29);
            this.BtnReportViewer.TabIndex = 3;
            this.BtnReportViewer.Text = "Report";
            this.BtnReportViewer.UseVisualStyleBackColor = true;
            this.BtnReportViewer.Click += new System.EventHandler(this.BtnReportViewer_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.BtnDelete.IsMouseDown = false;
            this.BtnDelete.IsMouseOver = false;
            this.BtnDelete.Location = new System.Drawing.Point(830, 558);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(103, 29);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(945, 599);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnReportViewer);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_Search);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(961, 638);
            this.Name = "Stock";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Animated_Button BtnDelete;
        private Animated_Button BtnReportViewer;
        private Animated_Button BtnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewImageColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewCheckBoxColumn choose;
    }
}