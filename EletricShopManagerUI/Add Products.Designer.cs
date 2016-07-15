namespace EletricShopManagerUI
{
    partial class Add_Products
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Txt_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Quantity = new System.Windows.Forms.TextBox();
            this.Btn_New = new EletricShopManagerUI.Animated_Button();
            this.Btn_Delete = new EletricShopManagerUI.Animated_Button();
            this.Btn_update = new EletricShopManagerUI.Animated_Button();
            this.Btn_Save = new EletricShopManagerUI.Animated_Button();
            this.Btn_Browse = new EletricShopManagerUI.Animated_Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(62, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(37, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(69, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Maroon;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(162, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 29);
            this.textBox1.TabIndex = 11;
            // 
            // Txt_Name
            // 
            this.Txt_Name.BackColor = System.Drawing.Color.Maroon;
            this.Txt_Name.ForeColor = System.Drawing.Color.White;
            this.Txt_Name.Location = new System.Drawing.Point(162, 68);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(259, 29);
            this.Txt_Name.TabIndex = 1;
            this.Txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Name_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Choose one.....",
            "General Goods",
            "Electronics",
            "Gadgets"});
            this.comboBox1.BackColor = System.Drawing.Color.Maroon;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "General Goods",
            "Electronics",
            "Gadgets"});
            this.comboBox1.Location = new System.Drawing.Point(163, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 29);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Tag = "Choose one........";
            // 
            // Txt_price
            // 
            this.Txt_price.BackColor = System.Drawing.Color.Maroon;
            this.Txt_price.ForeColor = System.Drawing.Color.White;
            this.Txt_price.Location = new System.Drawing.Point(162, 162);
            this.Txt_price.Name = "Txt_price";
            this.Txt_price.Size = new System.Drawing.Size(259, 29);
            this.Txt_price.TabIndex = 3;
            this.Txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_price_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Maroon;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(158, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 21);
            this.label7.TabIndex = 0;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.image,
            this.name,
            this.category,
            this.price,
            this.quantity});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(15, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(607, 202);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // id
            // 
            this.id.HeaderText = "Product ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.image.HeaderText = "Image";
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.image.Name = "image";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            // 
            // price
            // 
            this.price.HeaderText = "Price GH¢";
            this.price.Name = "price";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Qty";
            this.quantity.Name = "quantity";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::EletricShopManagerUI.Properties.Resources.DASS_B_ELEC;
            this.pictureBox1.Location = new System.Drawing.Point(447, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity:";
            // 
            // Txt_Quantity
            // 
            this.Txt_Quantity.BackColor = System.Drawing.Color.Maroon;
            this.Txt_Quantity.ForeColor = System.Drawing.Color.White;
            this.Txt_Quantity.Location = new System.Drawing.Point(163, 205);
            this.Txt_Quantity.Name = "Txt_Quantity";
            this.Txt_Quantity.Size = new System.Drawing.Size(259, 29);
            this.Txt_Quantity.TabIndex = 4;
            this.Txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_price_KeyPress);
            // 
            // Btn_New
            // 
            this.Btn_New.ForeColor = System.Drawing.Color.White;
            this.Btn_New.IsMouseDown = false;
            this.Btn_New.IsMouseOver = false;
            this.Btn_New.Location = new System.Drawing.Point(43, 265);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(100, 30);
            this.Btn_New.TabIndex = 5;
            this.Btn_New.Text = "New";
            this.Btn_New.UseVisualStyleBackColor = true;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.IsMouseDown = false;
            this.Btn_Delete.IsMouseOver = false;
            this.Btn_Delete.Location = new System.Drawing.Point(400, 266);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(100, 30);
            this.Btn_Delete.TabIndex = 8;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_update
            // 
            this.Btn_update.ForeColor = System.Drawing.Color.White;
            this.Btn_update.IsMouseDown = false;
            this.Btn_update.IsMouseOver = false;
            this.Btn_update.Location = new System.Drawing.Point(279, 265);
            this.Btn_update.Name = "Btn_update";
            this.Btn_update.Size = new System.Drawing.Size(100, 30);
            this.Btn_update.TabIndex = 7;
            this.Btn_update.Text = "Update";
            this.Btn_update.UseVisualStyleBackColor = true;
            this.Btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.IsMouseDown = false;
            this.Btn_Save.IsMouseOver = false;
            this.Btn_Save.Location = new System.Drawing.Point(157, 265);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(100, 30);
            this.Btn_Save.TabIndex = 6;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Browse
            // 
            this.Btn_Browse.ForeColor = System.Drawing.Color.White;
            this.Btn_Browse.IsMouseDown = false;
            this.Btn_Browse.IsMouseOver = false;
            this.Btn_Browse.Location = new System.Drawing.Point(525, 266);
            this.Btn_Browse.Name = "Btn_Browse";
            this.Btn_Browse.Size = new System.Drawing.Size(97, 29);
            this.Btn_Browse.TabIndex = 9;
            this.Btn_Browse.Text = "Browse";
            this.Btn_Browse.UseVisualStyleBackColor = true;
            this.Btn_Browse.Click += new System.EventHandler(this.Btn_Browse_Click);
            // 
            // Add_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(639, 548);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_update);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Browse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txt_Quantity);
            this.Controls.Add(this.Txt_price);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(655, 587);
            this.Name = "Add_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Products";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Products_FormClosed);
            this.Load += new System.EventHandler(this.Add_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Animated_Button Btn_Browse;
        private Animated_Button Btn_Save;
        private Animated_Button Btn_update;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Txt_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private Animated_Button Btn_Delete;
        private Animated_Button Btn_New;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Quantity;
    }
}