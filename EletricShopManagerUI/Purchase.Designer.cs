namespace EletricShopManagerUI
{
    partial class Purchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMG_ = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Amount = new System.Windows.Forms.TextBox();
            this.Txt_Quantity = new System.Windows.Forms.TextBox();
            this.Txt_TransDate = new System.Windows.Forms.TextBox();
            this.Txt_CustomerName = new System.Windows.Forms.TextBox();
            this.Txt_TransID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_Price = new System.Windows.Forms.TextBox();
            this.cbo_Category = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Vendor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Buy = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tranzactid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_NewTranz = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.PrintReceiptDoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DVPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.DVPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.DVPrintDialog = new System.Windows.Forms.PrintDialog();
            this.DashedLines = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.IMG_,
            this.name,
            this.category,
            this.price,
            this.quantity});
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(8, 416);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(507, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.Maroon;
            this.id.DefaultCellStyle = dataGridViewCellStyle47;
            this.id.HeaderText = "Product ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // IMG_
            // 
            this.IMG_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IMG_.HeaderText = "IMG";
            this.IMG_.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.IMG_.Name = "IMG_";
            this.IMG_.ReadOnly = true;
            this.IMG_.Width = 47;
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
            this.price.HeaderText = "Price GH¢";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Qty in Stock";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Txt_Amount);
            this.panel2.Controls.Add(this.Txt_Quantity);
            this.panel2.Controls.Add(this.Txt_TransDate);
            this.panel2.Controls.Add(this.Txt_CustomerName);
            this.panel2.Controls.Add(this.Txt_TransID);
            this.panel2.Location = new System.Drawing.Point(535, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 288);
            this.panel2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tranzaction ID:";
            // 
            // Txt_Amount
            // 
            this.Txt_Amount.BackColor = System.Drawing.Color.Maroon;
            this.Txt_Amount.Enabled = false;
            this.Txt_Amount.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Amount.ForeColor = System.Drawing.Color.White;
            this.Txt_Amount.Location = new System.Drawing.Point(149, 200);
            this.Txt_Amount.Name = "Txt_Amount";
            this.Txt_Amount.Size = new System.Drawing.Size(300, 29);
            this.Txt_Amount.TabIndex = 10;
            // 
            // Txt_Quantity
            // 
            this.Txt_Quantity.BackColor = System.Drawing.Color.Maroon;
            this.Txt_Quantity.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Quantity.ForeColor = System.Drawing.Color.White;
            this.Txt_Quantity.Location = new System.Drawing.Point(149, 156);
            this.Txt_Quantity.Name = "Txt_Quantity";
            this.Txt_Quantity.Size = new System.Drawing.Size(300, 29);
            this.Txt_Quantity.TabIndex = 9;
            this.Txt_Quantity.TextChanged += new System.EventHandler(this.Txt_Quantity_TextChanged);
            this.Txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Quantity_KeyPress);
            // 
            // Txt_TransDate
            // 
            this.Txt_TransDate.BackColor = System.Drawing.Color.Maroon;
            this.Txt_TransDate.Enabled = false;
            this.Txt_TransDate.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TransDate.ForeColor = System.Drawing.Color.White;
            this.Txt_TransDate.Location = new System.Drawing.Point(149, 75);
            this.Txt_TransDate.Name = "Txt_TransDate";
            this.Txt_TransDate.Size = new System.Drawing.Size(300, 29);
            this.Txt_TransDate.TabIndex = 7;
            // 
            // Txt_CustomerName
            // 
            this.Txt_CustomerName.BackColor = System.Drawing.Color.Maroon;
            this.Txt_CustomerName.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CustomerName.ForeColor = System.Drawing.Color.White;
            this.Txt_CustomerName.Location = new System.Drawing.Point(149, 113);
            this.Txt_CustomerName.Name = "Txt_CustomerName";
            this.Txt_CustomerName.Size = new System.Drawing.Size(300, 29);
            this.Txt_CustomerName.TabIndex = 8;
            this.Txt_CustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_CustomerName_KeyPress);
            // 
            // Txt_TransID
            // 
            this.Txt_TransID.BackColor = System.Drawing.Color.Maroon;
            this.Txt_TransID.Enabled = false;
            this.Txt_TransID.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TransID.ForeColor = System.Drawing.Color.White;
            this.Txt_TransID.Location = new System.Drawing.Point(149, 33);
            this.Txt_TransID.Name = "Txt_TransID";
            this.Txt_TransID.Size = new System.Drawing.Size(300, 29);
            this.Txt_TransID.TabIndex = 6;
            this.Txt_TransID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_TransID_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Product ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Category:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Price:";
            // 
            // Txt_ID
            // 
            this.Txt_ID.BackColor = System.Drawing.Color.Maroon;
            this.Txt_ID.Enabled = false;
            this.Txt_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ID.ForeColor = System.Drawing.Color.White;
            this.Txt_ID.Location = new System.Drawing.Point(126, 25);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(169, 29);
            this.Txt_ID.TabIndex = 1;
            // 
            // Txt_Name
            // 
            this.Txt_Name.BackColor = System.Drawing.Color.Maroon;
            this.Txt_Name.Enabled = false;
            this.Txt_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Name.ForeColor = System.Drawing.Color.White;
            this.Txt_Name.Location = new System.Drawing.Point(126, 72);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(169, 29);
            this.Txt_Name.TabIndex = 2;
            this.Txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Name_KeyPress);
            // 
            // Txt_Price
            // 
            this.Txt_Price.BackColor = System.Drawing.Color.Maroon;
            this.Txt_Price.Enabled = false;
            this.Txt_Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Price.ForeColor = System.Drawing.Color.White;
            this.Txt_Price.Location = new System.Drawing.Point(126, 229);
            this.Txt_Price.Name = "Txt_Price";
            this.Txt_Price.Size = new System.Drawing.Size(169, 29);
            this.Txt_Price.TabIndex = 5;
            this.Txt_Price.TextChanged += new System.EventHandler(this.Txt_Price_TextChanged);
            this.Txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Price_KeyPress);
            // 
            // cbo_Category
            // 
            this.cbo_Category.BackColor = System.Drawing.Color.Maroon;
            this.cbo_Category.Enabled = false;
            this.cbo_Category.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Category.ForeColor = System.Drawing.Color.White;
            this.cbo_Category.FormattingEnabled = true;
            this.cbo_Category.Items.AddRange(new object[] {
            "General Goods",
            "Electronics",
            "Gadgets"});
            this.cbo_Category.Location = new System.Drawing.Point(126, 178);
            this.cbo_Category.Name = "cbo_Category";
            this.cbo_Category.Size = new System.Drawing.Size(169, 29);
            this.cbo_Category.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbo_Category);
            this.panel1.Controls.Add(this.Txt_Price);
            this.panel1.Controls.Add(this.Txt_Vendor);
            this.panel1.Controls.Add(this.Txt_Name);
            this.panel1.Controls.Add(this.Txt_ID);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(29, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 288);
            this.panel1.TabIndex = 3;
            // 
            // Txt_Vendor
            // 
            this.Txt_Vendor.BackColor = System.Drawing.Color.Maroon;
            this.Txt_Vendor.Enabled = false;
            this.Txt_Vendor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Vendor.ForeColor = System.Drawing.Color.White;
            this.Txt_Vendor.Location = new System.Drawing.Point(126, 126);
            this.Txt_Vendor.Name = "Txt_Vendor";
            this.Txt_Vendor.Size = new System.Drawing.Size(169, 29);
            this.Txt_Vendor.TabIndex = 3;
            this.Txt_Vendor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Vendor_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "Vendor:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EletricShopManagerUI.Properties.Resources.download;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(344, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Buy
            // 
            this.Btn_Buy.BackColor = System.Drawing.Color.DarkSalmon;
            this.Btn_Buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Buy.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Btn_Buy.FlatAppearance.BorderSize = 2;
            this.Btn_Buy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_Buy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.Btn_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buy.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buy.ForeColor = System.Drawing.Color.White;
            this.Btn_Buy.Location = new System.Drawing.Point(234, 710);
            this.Btn_Buy.Name = "Btn_Buy";
            this.Btn_Buy.Size = new System.Drawing.Size(212, 59);
            this.Btn_Buy.TabIndex = 12;
            this.Btn_Buy.Text = "Add To Cart";
            this.Btn_Buy.UseVisualStyleBackColor = false;
            this.Btn_Buy.Click += new System.EventHandler(this.Btn_Buy_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle49.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle49;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.vendor,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.tranzactid,
            this.date,
            this.cust,
            this.quant,
            this.amt});
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(521, 416);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(507, 269);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle50;
            this.dataGridViewTextBoxColumn1.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 78;
            // 
            // vendor
            // 
            this.vendor.HeaderText = "Vendor";
            this.vendor.Name = "vendor";
            this.vendor.ReadOnly = true;
            this.vendor.Width = 88;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 103;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price GH¢";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 107;
            // 
            // tranzactid
            // 
            this.tranzactid.HeaderText = "Tranzaction ID";
            this.tranzactid.Name = "tranzactid";
            this.tranzactid.ReadOnly = true;
            this.tranzactid.Width = 138;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 69;
            // 
            // cust
            // 
            this.cust.HeaderText = "Customer";
            this.cust.Name = "cust";
            this.cust.ReadOnly = true;
            this.cust.Width = 106;
            // 
            // quant
            // 
            this.quant.HeaderText = "Qty";
            this.quant.Name = "quant";
            this.quant.ReadOnly = true;
            this.quant.Width = 61;
            // 
            // amt
            // 
            this.amt.HeaderText = "Amt GH¢";
            this.amt.Name = "amt";
            this.amt.ReadOnly = true;
            this.amt.Width = 102;
            // 
            // Btn_NewTranz
            // 
            this.Btn_NewTranz.BackColor = System.Drawing.Color.DarkSalmon;
            this.Btn_NewTranz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NewTranz.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Btn_NewTranz.FlatAppearance.BorderSize = 2;
            this.Btn_NewTranz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_NewTranz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.Btn_NewTranz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NewTranz.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NewTranz.ForeColor = System.Drawing.Color.White;
            this.Btn_NewTranz.Location = new System.Drawing.Point(85, 710);
            this.Btn_NewTranz.Name = "Btn_NewTranz";
            this.Btn_NewTranz.Size = new System.Drawing.Size(143, 59);
            this.Btn_NewTranz.TabIndex = 11;
            this.Btn_NewTranz.Text = "New";
            this.Btn_NewTranz.UseVisualStyleBackColor = false;
            this.Btn_NewTranz.Click += new System.EventHandler(this.Btn_NewTranz_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.DarkSalmon;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Btn_Delete.FlatAppearance.BorderSize = 2;
            this.Btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.Location = new System.Drawing.Point(881, 711);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(137, 60);
            this.Btn_Delete.TabIndex = 16;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.DarkSalmon;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Btn_Update.FlatAppearance.BorderSize = 2;
            this.Btn_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.ForeColor = System.Drawing.Color.White;
            this.Btn_Update.Location = new System.Drawing.Point(738, 710);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(137, 59);
            this.Btn_Update.TabIndex = 15;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // PrintReceiptDoc
            // 
            this.PrintReceiptDoc.BackColor = System.Drawing.Color.DarkSalmon;
            this.PrintReceiptDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintReceiptDoc.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.PrintReceiptDoc.FlatAppearance.BorderSize = 2;
            this.PrintReceiptDoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.PrintReceiptDoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.PrintReceiptDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintReceiptDoc.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintReceiptDoc.ForeColor = System.Drawing.Color.White;
            this.PrintReceiptDoc.Location = new System.Drawing.Point(452, 709);
            this.PrintReceiptDoc.Name = "PrintReceiptDoc";
            this.PrintReceiptDoc.Size = new System.Drawing.Size(137, 61);
            this.PrintReceiptDoc.TabIndex = 13;
            this.PrintReceiptDoc.Text = "Print";
            this.PrintReceiptDoc.UseVisualStyleBackColor = false;
            this.PrintReceiptDoc.Click += new System.EventHandler(this.PrintReceiptDoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Products  Currently in Stock";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(754, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 21);
            this.label12.TabIndex = 9;
            this.label12.Text = "Shopping Cart";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(596, 709);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 61);
            this.button1.TabIndex = 14;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnViewCart_Click);
            // 
            // DVPrintPreviewDialog
            // 
            this.DVPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.DVPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.DVPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.DVPrintPreviewDialog.Enabled = true;
            this.DVPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("DVPrintPreviewDialog.Icon")));
            this.DVPrintPreviewDialog.Name = "DVPrintPreviewDialog";
            this.DVPrintPreviewDialog.Visible = false;
            // 
            // DVPrintDocument
            // 
            this.DVPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.DVPrintDocument_PrintPage);
            // 
            // DVPrintDialog
            // 
            this.DVPrintDialog.UseEXDialog = true;
            // 
            // DashedLines
            // 
            this.DashedLines.AutoSize = true;
            this.DashedLines.ForeColor = System.Drawing.Color.Black;
            this.DashedLines.Location = new System.Drawing.Point(102, 777);
            this.DashedLines.Name = "DashedLines";
            this.DashedLines.Size = new System.Drawing.Size(418, 21);
            this.DashedLines.TabIndex = 10;
            this.DashedLines.Text = "--------------------------------------------------------------------";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1036, 797);
            this.Controls.Add(this.DashedLines);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PrintReceiptDoc);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_NewTranz);
            this.Controls.Add(this.Btn_Buy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1036, 754);
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Purchase_FormClosed);
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Amount;
        private System.Windows.Forms.TextBox Txt_Quantity;
        private System.Windows.Forms.TextBox Txt_TransDate;
        private System.Windows.Forms.TextBox Txt_CustomerName;
        private System.Windows.Forms.TextBox Txt_TransID;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn IMG_;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.TextBox Txt_Price;
        private System.Windows.Forms.ComboBox cbo_Category;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_Vendor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_Buy;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranzactid;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn cust;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn amt;
        private System.Windows.Forms.Button Btn_NewTranz;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button PrintReceiptDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog DVPrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument DVPrintDocument;
        private System.Windows.Forms.PrintDialog DVPrintDialog;
        private System.Windows.Forms.Label DashedLines;
    }
}