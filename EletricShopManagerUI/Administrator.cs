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
    public partial class Administrator : Form
    {
        string img_file = null;
        config con = new config();

        public Administrator()
        {
            InitializeComponent();
        }
   

        /*Load admin page*/
        private void Administrator_Load(object sender, EventArgs e)
        {
           // New_id();
            GridView();
        }
        //Load load profile pic
        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.Cancel)
            {
                img_file = ofd.FileName;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        //create new admin
        private void Btn_New_Click(object sender, EventArgs e)
        {
            New_id();
            Clear_Fields();
            GridView();
        }

        //save admin profile
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Save_Records();
            Clear_Fields();
            Txt_ID.Clear();
            GridView();
        }

        //update admin info
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            update_Records();
            Clear_Fields();
            Txt_ID.Clear();
            GridView();
        }


        //delete an admin
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete_Records();
            Clear_Fields();
            Txt_ID.Clear();
            GridView();
        }

        //*********************************************************************/
        /*                                                                     *
         *                  METHOD DECLARATION BLOCK                           *
         *                                                                     *
         * *********************************************************************/

        //-------------------------------------------------------New_Records()
        #region New_Record()
        void New_id()
        {
            SqlDataAdapter sda = new SqlDataAdapter("proc_new_admin", con.ActiveCon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Txt_ID.Text = dt.Rows[0][0].ToString();
        }
        #endregion

        //--------------------------------------------------------Save_Records()
        #region Save_Records()
        void Save_Records()
        {
            if (img_file != null)
            {
                FileStream fs = new FileStream(img_file, FileMode.Open, FileAccess.Read);
                byte[] image = new byte[fs.Length];
                //to be taken care of
                fs.Read(image, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[admin]
           ([admin_id]
           ,[image]
           ,[first_name]
           ,[last_name]
           ,[gender]
           ,[age]
           ,[salary]
           ,[username]
            ,[password])
     VALUES
           ('" + Txt_ID.Text + "', @pic, '" + Txt_FirstName.Text + "', '" + Txt_LastName.Text + "', '" + Combo_Gender.SelectedItem + "', '" + Txt_Age.Text + "', '" + System.Convert.ToDecimal(Txt_Salary.Text) + "', '" + Txt_Username.Text + "','" + Txt_Password.Text + "')", con.ActiveCon());
                SqlParameter param = new SqlParameter("@pic", SqlDbType.VarBinary, /*must be taken care of*/image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);
                param.SqlDbType = SqlDbType.Image;
                param.ParameterName = "pic";
                param.Value = image;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Please upload an image!");
            }
        }

        

        #endregion
        //***************************************************************DataGridView()
        #region DataGridView for admin
        
        //--------------------------------------------------------
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            Txt_ID.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            Txt_FirstName.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            Txt_LastName.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            Combo_Gender.SelectedItem = dataGridView1.Rows[n].Cells[4].Value.ToString();
            Txt_Age.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
            Txt_Salary.Text = dataGridView1.Rows[n].Cells[6].Value.ToString();

            Txt_Username.Text = dataGridView1.Rows[n].Cells[7].Value.ToString();

            var data = (Byte[])(dataGridView1.Rows[n].Cells[1].Value);
            var stream = new MemoryStream(data);
            pictureBox1.Image = Image.FromStream(stream);
        }

        #endregion


        #region Update_Record()
        void update_Records()
        {

            //if (img_file == null)
            //{
            //    FileStream fs = new FileStream(img_file, FileMode.Open, FileAccess.Read);
            //    byte[] image = new byte[fs.Length];
            //    //to be taken care of
            //    fs.Read(image, 0, System.Convert.ToInt32(fs.Length));
            //    fs.Close();
            SqlCommand cmd = new SqlCommand(@"UPDATE admin
                SET [admin_id] = '" + Txt_ID.Text + "', [first_name] = '" + Txt_FirstName.Text + "', [last_name] = '" + Txt_LastName.Text + "', [gender] = '" + Combo_Gender.SelectedItem + "', [age] = '" + Txt_Age.Text + "', [salary] = '" + System.Convert.ToDecimal(Txt_Salary.Text) + "',  [username] = '" + Txt_Username.Text + "', [password] = '" + Txt_Password.Text + "' WHERE [admin_id] = '" + Txt_ID.Text + "' ", con.ActiveCon());
            //SqlParameter param = new SqlParameter("@pic", SqlDbType.VarBinary, image.Length, ParameterDirection.Input,
            //                                   false, 0, 0, null, DataRowVersion.Current, image);
            //param.SqlDbType = SqlDbType.Image;
            //param.ParameterName = "pic";
            //param.Value = image;
            //cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            //}
        }
        #endregion

        //---------------------------------------------------------Delete_Records() - Delete Admin recors.

        #region Delete_Record()
        void Delete_Records()
        {
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [admin] WHERE admin_id ='" + Txt_ID.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        #endregion

        //.------------------------------------------------------------------------Gridview
        #region Grid_View()

        void GridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM admin", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            // dataGridView1.DataSource = dt;
            //DataGridViewImageCell img = new DataGridViewImageCell();
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["admin_id"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["image"];
                dataGridView1.Rows[n].Cells[2].Value = item["first_name"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["last_name"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["gender"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["age"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = /*(Decimal)*/item["salary"];
                //dataGridView1.Rows[n].Cells[7].Value = item["date_employed"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["username"].ToString();

                //dataGridView1.Rows[n].Height = 100;


            }
        }

        //***********************************************************Clear All
        #region Clear_Fields()
        void Clear_Fields()
        {
            //Txt_ID.Clear();
            Txt_FirstName.Clear();
            Txt_LastName.Clear();
            Txt_Age.Clear();
            Txt_Salary.Clear();
            Combo_Gender.SelectedIndex = -1;
            Txt_Username.Clear();
            pictureBox1.Image = null;
        }
        #endregion

    }
        #endregion
}
