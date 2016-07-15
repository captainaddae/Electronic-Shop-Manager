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
using System.IO;

namespace EletricShopManagerUI
{
    public partial class Purchase : Form
    {
       
        public Purchase()
        {
            InitializeComponent();

        }

        config con = new config();
        string img_file = null;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            Txt_ID.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            Txt_Name.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            cbo_Category.SelectedItem = dataGridView1.Rows[n].Cells[3].Value.ToString();
            Txt_Price.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();

            var data = (Byte[])(dataGridView1.Rows[n].Cells[1].Value);
            var stream = new MemoryStream(data);
            pictureBox1.Image = Image.FromStream(stream);
        }
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

        void Save_Records()
        {
            FileStream fs = new FileStream(img_file, FileMode.Open, FileAccess.Read);
            byte[] image = new byte[fs.Length];
            //to be taken care of
            fs.Read(image, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[products]
           ([product_id]
           ,[image]
           ,[name]
           ,[category]
           ,[unit_price])
     VALUES
           ('" + Txt_CustomerName.Text + "', @pic, '" + Txt_Name.Text + "', '" + cbo_Category.SelectedItem + "', '" + System.Convert.ToDecimal(Txt_Price.Text) + "')", con.ActiveCon());
            SqlParameter param = new SqlParameter("@pic", SqlDbType.VarBinary, /*must be taken care of*/image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);
            param.SqlDbType = SqlDbType.Image;
            param.ParameterName = "pic";
            param.Value = image;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            //call a new transaction id
            New_id();
            Calculate_Quantity_Left();
            GetVendor_DateTime();
            GridView();
            //SalesGridView();
            DashedLines.Visible = false;


        }

        //override the OnFormClosing event
        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (e.CloseReason == CloseReason.UserClosing)
        //    {
        //        Welcome wlc = new Welcome();
        //        wlc.Show();
        //    }
        //}



        private void Purchase_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT role FROM activeusers", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (item["role"].ToString() == "Employee")
                    {
                        Employee_Front_Desk ewlc = new Employee_Front_Desk();

                        ewlc.Show();
                        ewlc.MdiParent = MdiParent;
                        // wlc.ShowInTaskbar = false;
                    }
                    else
                    {
                        Welcome wlc = new Welcome();
                        wlc.Show();
                        wlc.MdiParent = MdiParent;
                    }
                }
            }
        }
        private void Calculated_Amount()
        {
            try
            {
                double dtot = 0;
                //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM products", con.ActiveCon());
                //DataTable dt = new DataTable();
                //sda.Fill(dt);

                //foreach (DataRow item in dt.Rows)
                //{
                int n = dataGridView1.SelectedRows[0].Index;
                dtot = double.Parse(dataGridView1.Rows[n].Cells[4].Value.ToString()) * double.Parse(Txt_Quantity.Text);
                Txt_Amount.Text = dtot.ToString();

            }
            catch
            {
                Txt_Amount.Text = "0.00";
            }

        }

        private void Txt_Price_TextChanged(object sender, EventArgs e)
        {
            Calculated_Amount();
        }

        private void Txt_Quantity_TextChanged(object sender, EventArgs e)
        {
            Calculated_Amount();
        }

        void New_id()
        {
            SqlDataAdapter sda = new SqlDataAdapter("proc_new_transanction", con.ActiveCon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Txt_TransID.Text = dt.Rows[0][0].ToString();
        }

        //save transanction to database
        private void Btn_Buy_Click(object sender, EventArgs e)
        {
            if (Txt_ID.Text != "" && Txt_Name.Text != "" && Txt_CustomerName.Text != "" && Txt_Price.Text != "" && Txt_Quantity.Text != "" && Txt_TransDate.Text != "" && Txt_TransID.Text != "" && Txt_Vendor.Text != "" && cbo_Category.SelectedIndex != -1)
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[sales]
           ([product_id]
           ,[name]
           ,[vendor]
           ,[category]
           ,[price]
           ,[tranzaction_id]
           ,[date]
           ,[customer]
           ,[quantity]
           ,[amount])
     VALUES
           ('" + Txt_ID.Text + "', '" + Txt_Name.Text + "', '" + Txt_Vendor.Text + "', '" + cbo_Category.SelectedItem + "', '" + System.Convert.ToDecimal(Txt_Price.Text) + "', '" + Txt_TransID.Text + "',  '" + Txt_TransDate.Text + "','" + Txt_CustomerName.Text + "', '" + System.Convert.ToDecimal(Txt_Quantity.Text) + "', '" + System.Convert.ToDecimal(Txt_Amount.Text) + "' )", con.ActiveCon());

                cmd.ExecuteNonQuery();
                Calculate_Quantity_Left();
                ViewShoppingCart();
                Clear_Fields();
                New_id();
                GetVendor_DateTime();
            }
            else
            {
                MessageBox.Show("Complete all the fields, please!");
            }

            //ShoppingCart shop = new ShoppingCart();
            //shop.Show();
            //shop.MdiParent = MdiParent;
            //shop.ShowInTaskbar = false;
        }

        private void Calculate_Quantity_Left()
        {
            //int quantity = 0;
            int quantity_left = 0;
            int quantity_bought = 0;
            int quantity_in_stock = 0;
            

            SqlDataAdapter sda = new SqlDataAdapter("SELECT quantity, tranzaction_id FROM sales WHERE product_id = '" + Txt_ID.Text + "'", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach(DataRow item in dt.Rows)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT quantity FROM product WHERE product_id = '" + Txt_ID.Text + "'", con.ActiveCon());
                DataTable table = new DataTable();
                da.Fill(table);
                
                foreach(DataRow name in table.Rows)
                {
                    quantity_bought = int.Parse(item["quantity"].ToString());
                    quantity_in_stock = int.Parse(name["quantity"].ToString());
                    //quantity += quantity;

                    quantity_left = quantity_in_stock - quantity_bought;

                    SqlCommand cmd = new SqlCommand("UPDATE product SET quantitybought = '" + quantity_bought + "', quantityleft='" + quantity_left + "'  WHERE product_id = '" + Txt_ID.Text + "'", con.ActiveCon());
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
         private void ViewShoppingCart()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM sales WHERE customer = '" + Txt_CustomerName.Text + "'", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            // dataGridView1.DataSource = dt;
            //DataGridViewImageCell img = new DataGridViewImageCell();
            dataGridView2.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item["product_id"].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item["name"].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item["vendor"].ToString();
                dataGridView2.Rows[n].Cells[3].Value = item["category"].ToString();
                dataGridView2.Rows[n].Cells[4].Value = item["price"].ToString();
                dataGridView2.Rows[n].Cells[5].Value = item["tranzaction_id"].ToString();
                dataGridView2.Rows[n].Cells[6].Value = item["date"].ToString();
                dataGridView2.Rows[n].Cells[7].Value = item["customer"].ToString();
                dataGridView2.Rows[n].Cells[8].Value = item["quantity"].ToString();
                dataGridView2.Rows[n].Cells[9].Value = item["amount"].ToString();

            }
        }

        private void Btn_NewTranz_Click(object sender, EventArgs e)
        {
            try
            {
                New_id();
                Calculate_Quantity_Left();
                //Txt_Vendor.Clear();
                //Txt_TransDate.Clear();
                GetVendor_DateTime();

                Clear_Fields();
            }
            catch(Exception s)
            {
                MessageBox.Show("An Error occured please close this page and start again from the Desk", s.Message);
            }
        }

        void Clear_Fields()
        {
            Txt_ID.Clear();
            Txt_Name.Clear();
           // Txt_Vendor.Clear();
            cbo_Category.SelectedIndex = -1;
            Txt_Price.Clear();
            //Txt_TransID.Clear();
            Txt_TransDate.Text = DateTime.Now.ToString();
            //Txt_CustomerName.Clear();
            Txt_Quantity.Clear();
            Txt_Amount.Clear();
            pictureBox1.Image = null;
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (Txt_ID.Text != "" && Txt_Name.Text != "" && Txt_Price.Text != "" && Txt_Amount.Text != "" && Txt_CustomerName.Text != "" && Txt_Quantity.Text != "" && Txt_TransDate.Text != "" && Txt_TransID.Text != "" && cbo_Category.SelectedIndex != -1)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[sales]
   SET [product_id] = '" + Txt_ID.Text + "',[name] = '" + Txt_Name.Text + "',[vendor] = '" + Txt_Vendor.Text + "', [category] = '" + cbo_Category.SelectedItem + "', [price] = '" + Txt_Price.Text + "', [tranzaction_id] = '" + Txt_TransID.Text + "',[date] = '" + Txt_TransDate.Text + "',[customer] = '" + Txt_CustomerName.Text + "', [quantity] = '" + Txt_Quantity.Text + "', [amount] = '" + Txt_Amount.Text + "' WHERE [tranzaction_id] = '" + dataGridView2.SelectedRows[0].Cells[5].Value + "'", con.ActiveCon());
                    cmd.ExecuteNonQuery();
                    Calculate_Quantity_Left();
                    ViewShoppingCart();
                    Clear_Fields();
                }
                catch (Exception s)
                {
                    MessageBox.Show("An error occured, please close this page and return later:", s.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the shopping cart and update accordingly!");
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Txt_ID.Text != "")
            {
                SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[sales] WHERE [tranzaction_id] = '" + dataGridView2.SelectedRows[0].Cells[5].Value + "' AND customer='" + Txt_CustomerName.Text + "'", con.ActiveCon());
                cmd.ExecuteNonQuery();
                Calculate_Quantity_Left();
                ViewShoppingCart();
                Clear_Fields();
                //SalesGridView();
            }
            else
            {
                MessageBox.Show("Please select an item from the shopping cart! or click \"View\"");
            }
        }

       private void GetVendor_DateTime()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT username, role FROM users ", con.ActiveCon());
            DataTable datatable = new DataTable();
            da.Fill(datatable);
            foreach (DataRow item in datatable.Rows)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT full_name FROM activeusers WHERE username='" + item["username"].ToString() + "' AND role='"+item["role"].ToString()+"'", con.ActiveCon());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow name in dt.Rows)
                {
                    Txt_Vendor.Text = name["full_name"].ToString();
                }
            }

            Txt_TransDate.Text = DateTime.Now.ToString();
        }

        //private void Btn_New_Click(object sender, EventArgs e)
        //{
        //    Print_Receipt print = new Print_Receipt();
        //    print.Show();
        //}

        private void BtnViewCart_Click(object sender, EventArgs e)
        {
            //int n = dataGridView2.SelectedRows[0].Index;
            //Txt_Name.Text = dataGridView2.Rows[n].Cells[1].Value.ToString();
            SalesGridView();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = null;
            int n = dataGridView2.SelectedRows[0].Index;
            Txt_ID.Text = dataGridView2.Rows[n].Cells[0].Value.ToString();
            Txt_Name.Text = dataGridView2.Rows[n].Cells[1].Value.ToString();
            Txt_Vendor.Text = dataGridView2.Rows[n].Cells[2].Value.ToString();
            cbo_Category.SelectedItem = dataGridView2.Rows[n].Cells[3].Value.ToString();
            Txt_Price.Text = dataGridView2.Rows[n].Cells[4].Value.ToString();
            Txt_TransID.Text = dataGridView2.Rows[n].Cells[5].Value.ToString();
            Txt_TransDate.Text = dataGridView2.Rows[n].Cells[6].Value.ToString();
            Txt_CustomerName.Text = dataGridView2.Rows[n].Cells[7].Value.ToString();
            Txt_Quantity.Text = dataGridView2.Rows[n].Cells[8].Value.ToString();
            Txt_Amount.Text = dataGridView2.Rows[n].Cells[9].Value.ToString();
        }

        void SalesGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM sales", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            // dataGridView1.DataSource = dt;
            //DataGridViewImageCell img = new DataGridViewImageCell();
            dataGridView2.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item["product_id"].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item["name"].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item["vendor"].ToString();
                dataGridView2.Rows[n].Cells[3].Value = item["category"].ToString();
                dataGridView2.Rows[n].Cells[4].Value = item["price"].ToString();
                dataGridView2.Rows[n].Cells[5].Value = item["tranzaction_id"].ToString();
                dataGridView2.Rows[n].Cells[6].Value = item["date"].ToString();
                dataGridView2.Rows[n].Cells[7].Value = item["customer"].ToString();
                dataGridView2.Rows[n].Cells[8].Value = item["quantity"].ToString();
                dataGridView2.Rows[n].Cells[9].Value = item["amount"].ToString();
            }

        }

        private void PrintReceiptDoc_Click(object sender, EventArgs e)
        {
            if (Txt_CustomerName.Text != "")
            {
                DVPrintPreviewDialog.Document = DVPrintDocument;
                DVPrintPreviewDialog.ShowDialog();
                //DVPrintDialog.Document = DVPrintDocument;
                //DVPrintDialog.ShowDialog();

                //DVPrintDocument.Print();
            }
            else
            {
                MessageBox.Show("Please click on \"view\", and select an item from the shopping cart! ");
            }
        }

        private void DVPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Courier New", 12, FontStyle.Regular);
            float fontHeight = font.GetHeight();
            string padding = "";
            padding = padding.PadRight(5);
            int startX = 75;
            int startY = 320;
            int offset = 10;

            Bitmap bmp = Properties.Resources.DASS_B_ELECcolor;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 75, 25, newImage.Width, newImage.Height);

            e.Graphics.DrawString("Customer Name: " + Txt_CustomerName.Text, font, Brushes.Black, new Point(75, 190));
            e.Graphics.DrawString("Print Date: " + DateTime.Now, font, Brushes.Black, new Point(440, 190));
            e.Graphics.DrawString("Vendor: " + Txt_Vendor.Text, font, Brushes.Black, new Point(75, 220));
            e.Graphics.DrawString(DashedLines.Text, font, Brushes.Black, new Point(75, 250));
            e.Graphics.DrawString("Product Name", font, Brushes.Black, new Point(75, 280));
            e.Graphics.DrawString("Tranzaction ID", font, Brushes.Black, new Point(280, 280));
            e.Graphics.DrawString("Qty", font, Brushes.Black, new Point(500, 280));
            e.Graphics.DrawString("Price", font, Brushes.Black, new Point(600, 280));
            e.Graphics.DrawString("Amt GH¢", font, Brushes.Black, new Point(700, 280));
            e.Graphics.DrawString(DashedLines.Text, font, Brushes.Black, new Point(75, 300));

            int i = 0;
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                int n = dataGridView2.Rows[0].Index;
                e.Graphics.DrawString(((row.Cells[1].Value.ToString().PadRight(20) + row.Cells[5].Value.ToString().PadRight(22) + row.Cells[8].Value.ToString().PadRight(9) + row.Cells[4].Value.ToString().PadRight(10) + row.Cells[9].Value.ToString()).PadRight(10)), font, Brushes.Black, startX, startY + offset);
                //e.Graphics.DrawString((dataGridView2.Rows[n].Cells[1].Value.ToString().PadRight(10)) , font, Brushes.Black, startX, startY + offset);
                //e.Graphics.DrawString((dataGridView2.Rows[n].Cells[6].Value.ToString().PadRight(10)),     font, Brushes.Black, startX, startY + offset);
                //e.Graphics.DrawString(dataGridView2.Rows[n].Cells[8].Value.ToString().PadRight(10),     font, Brushes.Black, startX, startY + offset);
                //e.Graphics.DrawString(dataGridView2.Rows[n].Cells[4].Value.ToString().PadRight(10),    font, Brushes.Black, startX, startY + offset);
                //e.Graphics.DrawString(dataGridView2.Rows[n].Cells[9].Value.ToString().PadRight(10),      font, Brushes.Black, startX, startY + offset);
                i++;
                offset = offset + (int)fontHeight + 20;
                total += decimal.Parse(row.Cells[9].Value.ToString());
            }
            e.Graphics.DrawString(DashedLines.Text, font, Brushes.Black, startX, startY + offset);
            offset = offset + (int)fontHeight + 2;
            e.Graphics.DrawString("Total GH¢", font, Brushes.Black, startX, startY + offset);
            e.Graphics.DrawString(string.Format("{0:#,##0.00;(#,##0.00)}", total), font, Brushes.Black, 705, startY + offset);
        }

        private void Txt_Vendor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);

            }
        }

        private void Txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void Txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void Txt_TransID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void Txt_CustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void Txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }
    }
}
