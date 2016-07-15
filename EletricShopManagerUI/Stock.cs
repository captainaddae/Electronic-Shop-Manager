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
    public partial class Stock : Form
    {
        config con = new config();
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            GridView();
        }

        //Gridview of all products in stock
        void GridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM product", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            // dataGridView1.DataSource = dt;
            //DataGridViewImageCell img = new DataGridViewImageCell();
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["product_id"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["image"];
                dataGridView1.Rows[n].Cells[2].Value = item["name"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["category"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = (Decimal)item["unit_price"];
                dataGridView1.Rows[n].Cells[5].Value = item["quantity"].ToString();
                //dataGridView1.Rows[n].Height = 100;


            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add_Products add_a_product = new Add_Products();
            add_a_product.Show();
           // add_a_product.MdiParent = MdiParent;
        }

        private void BtnReportViewer_Click(object sender, EventArgs e)
        {
            Stock_Report stock_report = new Stock_Report();
            stock_report.Show();
            stock_report.ShowInTaskbar = false;
            // stock_report.MdiParent = MdiParent;
        }
    }
}
