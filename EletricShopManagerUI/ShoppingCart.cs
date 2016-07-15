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
    public partial class ShoppingCart : Form
    {
        config con = new config();
        public ShoppingCart()
        {
            InitializeComponent();
           // CreatePanelTabPages();
            AddProductToTabbedPanel();
        }

        //private void CreatePanelTabPages()
        //{

        //    SqlDataAdapter sda = new SqlDataAdapter("SELECT name FROM products GROUP BY category", con.ActiveCon());
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
            
        //    foreach(DataRow row in dt.Rows)
        //    {
        //        tabControl1.TabPages.Add(row[0].ToString());
        //    }
        //}

        private void AddProductToTabbedPanel()
        {
            //int i = 0;
            foreach (TabPage tp in tabControl1.TabPages)
            {
               

                SqlDataAdapter sda = new SqlDataAdapter("SELECT name, unit_price FROM products", con.ActiveCon());
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //string currentProduct = dt.Rows[0]["name"].ToString();
                //SqlDataAdapter sda2 = new SqlDataAdapter("SELECT DISTINCT category FROM products WHERE name = " + currentProduct + i, con.ActiveCon());
                //DataTable dt2 = new DataTable();
                //sda2.Fill(dt2);

                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Dock = DockStyle.Fill;

                foreach(DataRow row in dt.Rows)
                {
                    Button btn = new Button();
                    btn.Size = new Size(100, 100);
                    btn.Text = row["name"].ToString() + "\n" + row["unit_price"].ToString();
                    //btn.Image = (Image)row["image"];
                    //btn.Tag = row[2].ToString();
                    flp.Controls.Add(btn);
                }
                //i++;
                tp.Controls.Add(flp);
            }
        }
    }
}
