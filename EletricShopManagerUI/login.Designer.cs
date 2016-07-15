namespace EletricShopManagerUI
{
    partial class login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.Btn_log_in = new System.Windows.Forms.Button();
            this.cbo_user_type = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.error_message = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_exit);
            this.groupBox1.Controls.Add(this.Btn_log_in);
            this.groupBox1.Controls.Add(this.cbo_user_type);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(46, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log in";
            // 
            // Btn_exit
            // 
            this.Btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_exit.ForeColor = System.Drawing.Color.Firebrick;
            this.Btn_exit.Location = new System.Drawing.Point(220, 243);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(75, 30);
            this.Btn_exit.TabIndex = 6;
            this.Btn_exit.Text = "Exit";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Btn_log_in
            // 
            this.Btn_log_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_log_in.ForeColor = System.Drawing.Color.Firebrick;
            this.Btn_log_in.Location = new System.Drawing.Point(129, 243);
            this.Btn_log_in.Name = "Btn_log_in";
            this.Btn_log_in.Size = new System.Drawing.Size(75, 30);
            this.Btn_log_in.TabIndex = 6;
            this.Btn_log_in.Text = "Log in";
            this.Btn_log_in.UseVisualStyleBackColor = true;
            this.Btn_log_in.Click += new System.EventHandler(this.Btn_log_in_Click);
            this.Btn_log_in.MouseHover += new System.EventHandler(this.Btn_log_in_MouseHover);
            // 
            // cbo_user_type
            // 
            this.cbo_user_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_user_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_user_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cbo_user_type.ForeColor = System.Drawing.Color.Firebrick;
            this.cbo_user_type.FormattingEnabled = true;
            this.cbo_user_type.Items.AddRange(new object[] {
            "Administrator",
            "Employee"});
            this.cbo_user_type.Location = new System.Drawing.Point(129, 187);
            this.cbo_user_type.Name = "cbo_user_type";
            this.cbo_user_type.Size = new System.Drawing.Size(166, 29);
            this.cbo_user_type.TabIndex = 5;
            this.cbo_user_type.Text = "Administrator";
            this.cbo_user_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_user_type_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.textBox2.Location = new System.Drawing.Point(129, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(166, 29);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "caddae";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.textBox1.Location = new System.Drawing.Point(129, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "makafui";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(123, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Copyright 2016, Bitwise Coperation.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(166, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "All rights reserved.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 44);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 41);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label6.Location = new System.Drawing.Point(68, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "ELECTRIC SHOP MANAGER";
            // 
            // error_message
            // 
            this.error_message.AutoSize = true;
            this.error_message.BackColor = System.Drawing.Color.Transparent;
            this.error_message.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_message.ForeColor = System.Drawing.Color.Transparent;
            this.error_message.Location = new System.Drawing.Point(55, 461);
            this.error_message.Name = "error_message";
            this.error_message.Size = new System.Drawing.Size(0, 17);
            this.error_message.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EletricShopManagerUI.Properties.Resources.admin_icon;
            this.pictureBox1.Location = new System.Drawing.Point(169, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(420, 546);
            this.Controls.Add(this.error_message);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbo_user_type;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_log_in;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label error_message;
    }
}