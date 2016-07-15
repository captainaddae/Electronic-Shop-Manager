namespace EletricShopManagerUI
{
    partial class Salary
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
            this.TxtSalaryAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDateTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEmployeeID = new System.Windows.Forms.TextBox();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.BtnPay = new EletricShopManagerUI.Animated_Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(34, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(46, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount:";
            // 
            // TxtSalaryAmount
            // 
            this.TxtSalaryAmount.BackColor = System.Drawing.Color.Maroon;
            this.TxtSalaryAmount.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalaryAmount.ForeColor = System.Drawing.Color.White;
            this.TxtSalaryAmount.Location = new System.Drawing.Point(131, 101);
            this.TxtSalaryAmount.Name = "TxtSalaryAmount";
            this.TxtSalaryAmount.Size = new System.Drawing.Size(338, 29);
            this.TxtSalaryAmount.TabIndex = 2;
            this.TxtSalaryAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSalaryAmount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(73, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date:";
            // 
            // TxtDateTime
            // 
            this.TxtDateTime.BackColor = System.Drawing.Color.Maroon;
            this.TxtDateTime.Enabled = false;
            this.TxtDateTime.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDateTime.ForeColor = System.Drawing.Color.White;
            this.TxtDateTime.Location = new System.Drawing.Point(131, 139);
            this.TxtDateTime.Name = "TxtDateTime";
            this.TxtDateTime.Size = new System.Drawing.Size(184, 29);
            this.TxtDateTime.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Employee ID:";
            // 
            // TxtEmployeeID
            // 
            this.TxtEmployeeID.BackColor = System.Drawing.Color.Maroon;
            this.TxtEmployeeID.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmployeeID.ForeColor = System.Drawing.Color.White;
            this.TxtEmployeeID.Location = new System.Drawing.Point(131, 25);
            this.TxtEmployeeID.Name = "TxtEmployeeID";
            this.TxtEmployeeID.Size = new System.Drawing.Size(338, 29);
            this.TxtEmployeeID.TabIndex = 0;
            this.TxtEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmployeeID_KeyPress);
            // 
            // cboEmployee
            // 
            this.cboEmployee.BackColor = System.Drawing.Color.Maroon;
            this.cboEmployee.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmployee.ForeColor = System.Drawing.Color.White;
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Items.AddRange(new object[] {
            "Select an Employee"});
            this.cboEmployee.Location = new System.Drawing.Point(131, 62);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(335, 29);
            this.cboEmployee.TabIndex = 1;
            this.cboEmployee.SelectedIndexChanged += new System.EventHandler(this.cboEmployee_SelectedIndexChanged);
            this.cboEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboEmployee_KeyPress);
            // 
            // BtnPay
            // 
            this.BtnPay.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPay.ForeColor = System.Drawing.Color.Maroon;
            this.BtnPay.IsMouseDown = false;
            this.BtnPay.IsMouseOver = false;
            this.BtnPay.Location = new System.Drawing.Point(366, 140);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(100, 30);
            this.BtnPay.TabIndex = 4;
            this.BtnPay.Text = "Pay";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 194);
            this.Controls.Add(this.cboEmployee);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.TxtDateTime);
            this.Controls.Add(this.TxtSalaryAmount);
            this.Controls.Add(this.TxtEmployeeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 233);
            this.MinimumSize = new System.Drawing.Size(468, 190);
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSalaryAmount;
        private Animated_Button BtnPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEmployeeID;
        private System.Windows.Forms.ComboBox cboEmployee;
    }
}