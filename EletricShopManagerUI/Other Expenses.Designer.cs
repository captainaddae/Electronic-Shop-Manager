namespace EletricShopManagerUI
{
    partial class Other_Expenses
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
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RTxtDescription = new System.Windows.Forms.RichTextBox();
            this.BtnSave = new EletricShopManagerUI.Animated_Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(68, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "User\r\n";
            // 
            // TxtUser
            // 
            this.TxtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtUser.BackColor = System.Drawing.Color.Maroon;
            this.TxtUser.Enabled = false;
            this.TxtUser.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.Color.White;
            this.TxtUser.Location = new System.Drawing.Point(129, 23);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(435, 29);
            this.TxtUser.TabIndex = 1;
            this.TxtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUser_KeyPress);
            // 
            // TxtAmount
            // 
            this.TxtAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtAmount.BackColor = System.Drawing.Color.Maroon;
            this.TxtAmount.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAmount.ForeColor = System.Drawing.Color.White;
            this.TxtAmount.Location = new System.Drawing.Point(129, 78);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(435, 29);
            this.TxtAmount.TabIndex = 1;
            this.TxtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(40, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(14, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description";
            // 
            // RTxtDescription
            // 
            this.RTxtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTxtDescription.BackColor = System.Drawing.Color.Maroon;
            this.RTxtDescription.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtDescription.ForeColor = System.Drawing.Color.White;
            this.RTxtDescription.Location = new System.Drawing.Point(132, 133);
            this.RTxtDescription.Name = "RTxtDescription";
            this.RTxtDescription.Size = new System.Drawing.Size(432, 163);
            this.RTxtDescription.TabIndex = 2;
            this.RTxtDescription.Text = "";
            this.RTxtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RTxtDescription_KeyPress);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.Maroon;
            this.BtnSave.IsMouseDown = false;
            this.BtnSave.IsMouseOver = false;
            this.BtnSave.Location = new System.Drawing.Point(471, 320);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(93, 31);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Other_Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(628, 384);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.RTxtDescription);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(644, 423);
            this.MinimumSize = new System.Drawing.Size(644, 423);
            this.Name = "Other_Expenses";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Expenses";
            this.Load += new System.EventHandler(this.Other_Expenses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RTxtDescription;
        private Animated_Button BtnSave;
    }
}