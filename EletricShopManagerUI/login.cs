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
    public partial class login : Form
    {
        config con = new config();

        int TogMove;
        int MValX;
        int MValy;

        public login()
        {
            InitializeComponent();
        }

        Button_Animation animate = new Button_Animation();
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void Btn_log_in_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && cbo_user_type.SelectedIndex != -1 && ((cbo_user_type.SelectedItem.ToString() == "Employee" || cbo_user_type.SelectedItem.ToString() == "Administrator")))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM users WHERE username='" + textBox1.Text + "' AND password='" + textBox2.Text + "' AND role='"+cbo_user_type.SelectedItem+"'", con.ActiveCon());
                DataTable dt = new DataTable();

                da.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                   SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[activeusers]
           ([username]
           ,[full_name]
           ,[role])VALUES('" + textBox1.Text + "','" + item["full_name"].ToString() + "', '"+cbo_user_type.SelectedItem+"')", con.ActiveCon());
                   cmd.ExecuteNonQuery();
                }

                if (dt.Rows.Count == 1)
                {
                    if (cbo_user_type.SelectedItem.ToString() == "Administrator")
                    {
                        home hm = new home();
                        hm.Show();
                        this.Hide();
                    }
                    else
                    {
                        employee_home ehm = new employee_home();
                        ehm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    error_message.ForeColor = Color.DarkSalmon;
                    error_message.Text = "Invalid username or password!";
                    textBox1.Focus();
                }

            }
            else
            {
                error_message.ForeColor = Color.DarkSalmon;
                error_message.Text = "Please provide all the details for the fields!";
                textBox1.Focus();
            }
           

        }

        #region login page manover.
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValy = e.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValy);
            }
        }

        private void Btn_log_in_MouseHover(object sender, EventArgs e)
        {
            
            animate.Show();
        }
        #endregion

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            login login = new login();
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void cbo_user_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }
    }
}
