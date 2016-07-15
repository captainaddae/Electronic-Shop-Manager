using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EletricShopManagerUI
{
    public partial class Other_Expenses : Form
    {
        config con = new config();
        public Other_Expenses()
        {
            InitializeComponent();
        }

        private void Other_Expenses_Load(object sender, EventArgs e)
        {
            get_users_name();
        }

        private void get_users_name()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT full_name FROM activeusers", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach(DataRow item in dt.Rows)
            {
                TxtUser.Text = item["full_name"].ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[expenses]
           ([name]
           ,[amount]
           ,[description])
            VALUES('" + TxtUser.Text + "', '" +System.Convert.ToDecimal( TxtAmount.Text) + "', '" + RTxtDescription.Text + "')", con.ActiveCon());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Transaction saved successfully");
            this.Close();
        }

        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void RTxtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }
    }
}
