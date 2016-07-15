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
    public partial class Welcome : Form
    {
        //DropShadow ds = new DropShadow();
        public Welcome()
        {
            InitializeComponent();
        }

        config con = new config();

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView2.Columns["R.No."].DefaultCellStyle.ForeColor = Color.Transparent;
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {

            Purchase pch = new Purchase();
            Welcome wlc = new Welcome();
            pch.Show();
            pch.MdiParent = MdiParent;

            this.Hide();
           // pch.MdiParent = this;

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        void GridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM sales", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            // dataGridView1.DataSource = dt;
            //DataGridViewImageCell img = new DataGridViewImageCell();
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["product_id"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["name"].ToString();   
                dataGridView1.Rows[n].Cells[2].Value = item["price"].ToString();
                dataGridView1.Rows[n].Cells[0].Value = item["tranzaction_id"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["date"].ToString();         
                dataGridView1.Rows[n].Cells[3].Value = item["quantity"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["amount"].ToString();
            }
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            GridView();
            CalcToRe_Amt();
            //total_sales.Text = 
        }

        private void CalcToRe_Amt()
        {
            int counting;
            decimal Out_Amt = 0.00M;
            int no1 = 0;
            counting = dataGridView1.Rows.Count;
            for (int i = 0; i < counting; i++)
            {
                no1 += 1;
                Out_Amt += decimal.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());

            }
            Record_count.Text = no1.ToString();
            total_sales.Text = "GH" + " " + string.Format("{0:¢#,##0.00;(¢#,##0.00); Zero}", Out_Amt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Products products = new Add_Products();
            products.Show();
        }

        private void total_sales_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
            //Add_Products add = new Add_Products();
            //add.Hide();
            //stock.MdiParent = MdiParent;
        }
    }
}
            //this.Shown += new EventHandler(Form1_Shown);
            //this.Resize += new EventHandler(Form1_Resize);
            //this.LocationChanged += new EventHandler(Form1_Resize);

    //public class DropShadow : Form
    //{
    //    public DropShadow()
    //    {
    //        this.Opacity = 0.5;
    //        this.BackColor = Color.Gray;
    //        this.ShowInTaskbar = false;
    //        this.FormBorderStyle = FormBorderStyle.None;
    //        this.StartPosition = FormStartPosition.Manual;
    //    }
    //    private const int WS_EX_TRANSPARENT = 0x20;
    //    private const int WS_EX_NOACTIVATE = 0x8000000;
    //    protected override System.Windows.Forms.CreateParams CreateParams
    //    {
    //        get
    //        {
    //            CreateParams cp = base.CreateParams;
    //            cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT | WS_EX_NOACTIVATE;
    //            return cp;
    //        }
    //    }

    //}
        //void Form1_Shown(object sender, EventArgs e)
        //{
        //    Rectangle rc = this.Bounds;
        //    rc.Inflate(10, 10);
        //    ds.Bounds = rc;
        //    ds.Show();
        //    this.BringToFront();
        //}
        //void Form1_Resize(object sender, EventArgs e)
        //{
        //    ds.Visible = (this.WindowState == FormWindowState.Normal);
        //    if (ds.Visible)
        //    {
        //        Rectangle rc = this.Bounds;
        //        rc.Inflate(10, 10);
        //        ds.Bounds = rc;
        //    }
        //    this.BringToFront();
        //}
