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
    public partial class home : Form
    {

        config con = new config();
        public home()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();

            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.Maroon;
                } 
            }
        }


        private void home_Load(object sender, EventArgs e)
        {

            Welcome wlc = new Welcome();
            wlc.MdiParent = this;
            wlc.Show();
            wlc.StartPosition = FormStartPosition.CenterScreen;
            //start_page st = new start_page();
            //st.MdiParent = this;
            //st.Show();

            //GridView();
            //this.reportViewer1.RefreshReport();
        }

       
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get
                {
                    return Color.DarkSalmon;
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return Color.Orange;
                }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return Color.Maroon;
                }
            }
        }

        //private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    login lgn = new login();
        //    this.Hide();
        //    lgn.Show();
        //}

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                delete_user();

            }
        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Products ap = new Add_Products();
            ap.StartPosition = FormStartPosition.CenterScreen;
            ap.Show();
            ap.MdiParent = this;
            //ap.BringToFront();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {
            //GridView();
        }

        private void buyProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase pc = new Purchase();
            pc.MdiParent = this;
            pc.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.MdiParent = this;
            user.Show();
            user.StartPosition = FormStartPosition.CenterScreen;
        }

        private void newAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            admin.MdiParent = this;
            admin.Show();
            admin.StartPosition = FormStartPosition.CenterScreen;
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.StartPosition = FormStartPosition.CenterScreen;
            stock.ShowDialog();
            stock.ShowInTaskbar = false;
           // ap.MdiParent = this;

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.StartPosition = FormStartPosition.CenterScreen;
            stock.ShowDialog();
            //stock.MdiParent = this;
        }

        private void payUtilityBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Other_Expenses otherexpenses = new Other_Expenses();
            otherexpenses.ShowDialog();
            //otherexpenses.MdiParent = this;
        }

        private void paySalariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            salary.ShowInTaskbar = false;
            salary.ShowDialog();
            salary.StartPosition = FormStartPosition.CenterScreen;
        }

        private void salesSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesSummary summary = new SalesSummary();
            summary.Show();
            summary.ShowInTaskbar = false;
            summary.StartPosition = FormStartPosition.CenterScreen;
            summary.BackColor = Color.MistyRose;
        }

        private void authorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abt_author author = new Abt_author();
            author.ShowDialog();
            author.BackColor = Color.MistyRose;
            author.ShowInTaskbar = false;
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_user();
        }
        
        private void delete_user()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT username FROM activeusers", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM activeusers WHERE username='" + item["username"].ToString() + "'", con.ActiveCon());
                cmd.ExecuteNonQuery();
            }
            login login = new login();
            this.Hide();
            login.Show();
        }

        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Products products = new Add_Products();
            products.Show();
            products.MdiParent = this;
        }

        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sales_Report report = new Sales_Report();
            report.ShowDialog();
            report.ShowInTaskbar = false;
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_Payment salary = new Salary_Payment();
            salary.ShowDialog();
            salary.MdiParent = this;
        }

        private void expenditureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expenditure_Report expenses = new Expenditure_Report();
            expenses.ShowDialog();
            expenses.MdiParent = this;
        }
    }
}
