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

//using System.Windows.Forms.DataGridViewImageColumn;

namespace EletricShopManagerUI
{
    public partial class Add_Products : Form
    {
       private config con = new config();
       private string img_file = null;

        public Add_Products()
        {
            InitializeComponent();
        }

        private void Add_Products_Load(object sender, EventArgs e)
        {
            New_id();
           // track_product_stock();
            Txt_Name.Focus();
            GridView();
            this.ShowInTaskbar = false;
            
        }

        void New_id ()
        {
            SqlDataAdapter sda = new SqlDataAdapter("proc_new_product", con.ActiveCon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Txt_Name.Text != "" && comboBox1.SelectedIndex != -1 && Txt_price.Text != "")
            {
                if (img_file != null)
                {
                    Save_Records();
                    //track_product_stock();
                    GridView();
                    label7.Text = "Records added successfully";
                    label7.ForeColor = Color.Green;

                    clear_fields();
            
                    //pictureBox1.Image = Image.FromFile("");
                }

                else
                {
                    label7.Text = "Please upload a picture!";
                    label7.ForeColor = Color.Red;
                }
            }
            else
            {
                label7.Text = "Please Complete all the fields in this section";
                label7.ForeColor = Color.Red;
            }
        }

        void Save_Records()
        {
            try
            {
                int total = 0;
                int price = int.Parse(Txt_price.Text);
                int qty = 0;
                    qty += int.Parse(Txt_Quantity.Text);
                total = price * qty;

                int quantitybought = 0;
                int quantityleft = 0;

                //SqlDataAdapter sda = new SqlDataAdapter("SELECT quantity FROM sales WHERE product_id = '" + textBox1.Text + "'", con.ActiveCon());
                //DataTable dt = new DataTable();
                //sda.Fill(dt);

                FileStream fs = new FileStream(img_file, FileMode.Open, FileAccess.Read);
                byte[] image = new byte[fs.Length];
                //to be taken care of
                fs.Read(image, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();

                //foreach (DataRow item in dt.Rows)
                //{
                    //quantitybought = int.Parse(item["quantity"].ToString());

                    quantityleft = qty - quantitybought;
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[product]
           ([product_id]
           ,[image]
           ,[name]
           ,[category]
           ,[unit_price]
           ,[quantity]
           ,[totalamount])VALUES('" + textBox1.Text + "', @pic, '" + Txt_Name.Text + "', '" + comboBox1.SelectedItem + "', '" + System.Convert.ToDecimal(Txt_price.Text) + "', '" + qty + "', '" + total + "')", con.ActiveCon());
                    SqlParameter param = new SqlParameter("@pic", SqlDbType.VarBinary, /*must be taken care of*/image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);
                    param.SqlDbType = SqlDbType.Image;
                    param.ParameterName = "pic";
                    param.Value = image;
                    cmd.Parameters.Add(param);
                    cmd.ExecuteNonQuery();
                //}
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

        }

        void GridView()
        {
            try
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
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        
        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() != DialogResult.Cancel)
            {
                img_file = ofd.FileName;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }

        }



        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            textBox1.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            Txt_Name.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            Txt_price.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.Rows[n].Cells[3].Value.ToString();
            Txt_Quantity.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
            var data = (Byte[])(dataGridView1.Rows[n].Cells[1].Value);
            var stream = new MemoryStream(data);
            pictureBox1.Image = Image.FromStream(stream);
        }

        private void Txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            if (e.KeyChar == (char)13)
            {
                Txt_price.Text = string.Format("{0:n0}", double.Parse(Txt_price.Text));
            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            
                update_Records();
                GridView();
            
        }

      

        void update_Records()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT quantity FROM product", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            if (img_file != null)
            {
                try
                {
                    FileStream fs = new FileStream(img_file, FileMode.Open, FileAccess.Read);
                    byte[] image = new byte[fs.Length];
                    //to be taken care of
                    fs.Read(image, 0, System.Convert.ToInt32(fs.Length));
                    fs.Close();
                    foreach (DataRow item in dt.Rows)
                    {
                        int db_item_quantity;
                        int txtfield_qty;
                        int update_prd_qty;
                        db_item_quantity = (int)item["quantity"];
                        txtfield_qty = int.Parse(Txt_Quantity.Text);
                        update_prd_qty = db_item_quantity + txtfield_qty;
                        
                        SqlCommand cmd = new SqlCommand(@"UPDATE product
                SET [product_id] = '" + textBox1.Text + "', [image] = @pic,  [name] = '" + Txt_Name.Text + "',[category] = '" + comboBox1.SelectedItem + "', [unit_price] = '" + Txt_price.Text + "', [quantity]= '" + update_prd_qty + "' WHERE [product_id] = '" + dataGridView1.SelectedRows[0].Cells[0].Value + "'", con.ActiveCon());
                        SqlParameter param = new SqlParameter("@pic", SqlDbType.VarBinary, image.Length, ParameterDirection.Input,
                                                           false, 0, 0, null, DataRowVersion.Current, image);
                        param.SqlDbType = SqlDbType.Image;
                        param.ParameterName = "pic";
                        param.Value = image;
                        cmd.Parameters.Add(param);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show("Error:", e.Message);
                }
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(@"UPDATE product
                SET [product_id] = '" + textBox1.Text + "', [name] = '" + Txt_Name.Text + "',[category] = '" + comboBox1.SelectedItem + "', [unit_price] = '" + Txt_price.Text + "', [quantity]= '" + Txt_Quantity.Text + "' WHERE [product_id] = '" + dataGridView1.SelectedRows[0].Cells[0].Value + "'", con.ActiveCon());
                    cmd.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    MessageBox.Show("Error:", e.Message);
                }
            }
        }

        private void Delete_Records()
        {
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [product] WHERE product_id ='" + textBox1.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            New_id();
            clear_fields();
        }


        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete_Records();
            GridView();
            clear_fields();
        }

        private void clear_fields()
        {
            Txt_Name.Clear();
            Txt_price.Clear();
            comboBox1.SelectedIndex = -1;
            pictureBox1.Image = null;
        }

        private void track_product_stock()
        {
            decimal total_amount = 0;
            decimal price = 0;
            int quantity = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int n = dataGridView1.Rows[0].Index;
                price = decimal.Parse(dataGridView1.Rows[n].Cells[4].Value.ToString());
                quantity = int.Parse(dataGridView1.Rows[n].Cells[5].Value.ToString());
                total_amount = price * quantity;
                SqlCommand cmd = new SqlCommand("INSERT INTO product (totalamount) VALUES('" + total_amount.ToString() + "')", con.ActiveCon());
                cmd.ExecuteNonQuery();
            }
                
        }
        private void Add_Products_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //Stock stock = new Stock();
                //this.Hide();
                //stock.ShowDialog();
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


    }
}
