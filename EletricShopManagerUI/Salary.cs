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
    public partial class Salary : Form
    {
        config con = new config();
        public Salary()
        {
            InitializeComponent();
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            insert_data();
            MessageBox.Show("Records saved successully");
            this.Close();
        }


        private void insert_data()
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[salary]
           ([employeeid]
           ,[name]
           ,[salary]
           ,[date])
            VALUES('" + TxtEmployeeID.Text + "', '" + cboEmployee.SelectedValue + "', '" + System.Convert.ToDecimal(TxtSalaryAmount.Text) + "', '" + TxtDateTime.Text + "')", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }

        void New_id()
        {
            SqlDataAdapter sda = new SqlDataAdapter("proc_new_user", con.ActiveCon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TxtEmployeeID.Text = dt.Rows[0][0].ToString();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            //New_id();
            cboData();
           // TxtSalaryAmount.Text = "0.00";
           
        }

        private void cboData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT full_name FROM users ", con.ActiveCon());
            //SqlCommand cmd = new SqlCommand(sda, con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);

            cboEmployee.DisplayMember = "full_name";
            cboEmployee.ValueMember = "full_name";
            cboEmployee.DataSource = dt;
        }

        private void cboEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("SELECT user_id, salary FROM users WHERE full_name='" + cboEmployee.SelectedValue.ToString() + "'", con.ActiveCon());
            //SqlCommand cmd = new SqlCommand(sda, con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
          //  int i = 0;
            foreach (DataRow item in dt.Rows)
            {
                TxtSalaryAmount.Text = item["salary"].ToString();
                TxtEmployeeID.Text = item["user_id"].ToString();
                TxtDateTime.Text = DateTime.Now.ToString();
              //  i++;
            }
        }

        private void TxtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void cboEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void TxtSalaryAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }
    }
}
