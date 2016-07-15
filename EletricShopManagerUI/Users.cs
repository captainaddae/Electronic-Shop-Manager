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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        string img_file = null;
        config con = new config();

        #region view all users
        private void Users_Load(object sender, EventArgs e)
        {
            New_id();
            GridView();
        }

        #endregion

        #region select user picture
        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.Cancel)
            {
                img_file = ofd.FileName;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
        #endregion

        #region create new user
        private void Btn_New_Click(object sender, EventArgs e)
        {
            New_id();
            Clear_Fields();
        }

        #endregion

        #region Save users
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Save_Records();
            Clear_Fields();
            GridView();
            //Clear_Fields();
        }
        #endregion


        #region update user list
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            update_Records();
            GridView();
        }
        #endregion

        #region delete users
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete_Records();
            Clear_Fields();
            GridView();
        }
        #endregion

        //Method declarations
        //---------------------------------------------------------------
        #region Save_Record()
        //--------------------------------------------Save_Records()
//        void Save_Records()
//        {
//            FileStream fs = new FileStream(img_file, FileMode.Open, FileAccess.Read);
//            byte[] image = new byte[fs.Length];
//            //to be taken care of
//            fs.Read(image, 0, System.Convert.ToInt32(fs.Length));
//            fs.Close();
//            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[users]
//           ([users_id]
//           ,[image]
//           ,[first_name]
//           ,[last_name]
//           ,[gender]
//           ,[age]
//           ,[salary]
//           ,[date_employed]
//           ,[date_employed])
//     VALUES
//           ('" + Txt_ID.Text + "', @pic, '" + Txt_FirstName.Text + "', '" + Txt_LastName.Text + "', '" + Combo_Gender.SelectedItem + "','" + Txt_Age.Text + "', '" + System.Convert.ToDecimal(Txt_Salary.Text) + "', '" + System.Convert.ToDateTime(Txt_Date_Employed.Text) + "', '" + Txt_Username.Text + "', '" + Txt_Password.Text + "')", con.ActiveCon());
//            SqlParameter param = new SqlParameter("@pic", SqlDbType.VarBinary, /*must be taken care of*/image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);
//            param.SqlDbType = SqlDbType.Image;
//            param.ParameterName = "pic";
//            param.Value = image;
//            cmd.Parameters.Add(param);
//            cmd.ExecuteNonQuery();
//        }
        #endregion

        //-------------------------------------------------------New_Records()
        #region New_Record()
        void New_id()
        {
            SqlDataAdapter sda = new SqlDataAdapter("proc_new_user", con.ActiveCon());
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
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[users]
           ([user_id]
           ,[image]
           ,[full_name]
           ,[role]
           ,[gender]
           ,[age]
           ,[salary]
           ,[date_employed]
           ,[username]
           ,[password]) VALUES('" + Txt_ID.Text + "', @pic, '" + Txt_FullName.Text + "', '"+ cbo_Role.SelectedItem +"', '" + Combo_Gender.SelectedItem + "', '" + Txt_Age.Text + "', '" + System.Convert.ToDecimal(Txt_Salary.Text) + "', '" + Txt_Date_Employed.Text + "','" + Txt_Username.Text + "','" + Txt_Password.Text + "')", con.ActiveCon());
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            Txt_ID.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            Txt_FullName.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            cbo_Role.SelectedItem = dataGridView1.Rows[n].Cells[3].Value.ToString();
            Combo_Gender.SelectedItem = dataGridView1.Rows[n].Cells[4].Value.ToString();
            Txt_Age.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
            Txt_Salary.Text = dataGridView1.Rows[n].Cells[6].Value.ToString();
            Txt_Date_Employed.Text = dataGridView1.Rows[n].Cells[7].Value.ToString();
            Txt_Username.Text = dataGridView1.Rows[n].Cells[8].Value.ToString();
            Txt_Password.Text = dataGridView1.Rows[n].Cells[9].Value.ToString();
            var data = (Byte[])(dataGridView1.Rows[n].Cells[1].Value);
            var stream = new MemoryStream(data);
            pictureBox1.Image = Image.FromStream(stream);
        }

        #endregion
        //***************************************************************DataGridView()
        #region DataGridView for users
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //Txt_Username.Text         = dataGridView1.Rows[n].Cells[8].Value.ToString();
         

        }
        #endregion
        //--------------------------------------------------------
        #region Update_Record()
        void update_Records()
        {
            try
            {
                if (img_file != null)
                {
                    FileStream fs = new FileStream(img_file, FileMode.Open, FileAccess.Read);
                    byte[] image = new byte[fs.Length];
                    //to be taken care of
                    fs.Read(image, 0, System.Convert.ToInt32(fs.Length));
                    fs.Close();
                    SqlCommand cmd = new SqlCommand(@"UPDATE users
                SET [user_id] = '" + Txt_ID.Text + "', [image] = @pic,  [full_name] = '" + Txt_FullName.Text + "', [role] = '" + cbo_Role.SelectedItem + "', [gender] = '" + Combo_Gender.SelectedItem + "', [age] = '" + Txt_Age.Text + "', [salary] = '" + System.Convert.ToDecimal(Txt_Salary.Text) + "', [date_employed] = '" + System.Convert.ToDateTime(Txt_Date_Employed.Text) + "', [username] = '" + Txt_Username.Text + "', [password] = '" + Txt_Password.Text + "' WHERE [user_id] = '" + Txt_ID.Text + "' ", con.ActiveCon());
                    SqlParameter param = new SqlParameter("@pic", SqlDbType.VarBinary, image.Length, ParameterDirection.Input,
                                                       false, 0, 0, null, DataRowVersion.Current, image);
                    param.SqlDbType = SqlDbType.Image;
                    param.ParameterName = "pic";
                    param.Value = image;
                    cmd.Parameters.Add(param);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(@"UPDATE users
                SET [user_id] = '" + Txt_ID.Text + "', [full_name] = '" + Txt_FullName.Text + "', [role] = '" + cbo_Role.SelectedItem + "', [gender] = '" + Combo_Gender.SelectedItem + "', [age] = '" + Txt_Age.Text + "', [salary] = '" + System.Convert.ToDecimal(Txt_Salary.Text) + "', [date_employed] = '" + System.Convert.ToDateTime(Txt_Date_Employed.Text) + "', [username] = '" + Txt_Username.Text + "', [password] = '" + Txt_Password.Text + "' WHERE [user_id] = '" + Txt_ID.Text + "' ", con.ActiveCon());
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error:", e.Message);
            }
        }
        #endregion

        //---------------------------------------------------------

        #region Delete_Record()
        void Delete_Records()
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"DELETE FROM [users] WHERE user_id ='" + Txt_ID.Text + "'", con.ActiveCon());
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error:", e.Message);
            }
        }
        #endregion

        //.------------------------------------------------------------------------Gridview
        #region Grid_View()

        void GridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM users", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            // dataGridView1.DataSource = dt;
            //DataGridViewImageCell img = new DataGridViewImageCell();
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["user_id"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["image"];
                dataGridView1.Rows[n].Cells[2].Value = item["full_name"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["role"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["gender"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["age"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = (Decimal)item["salary"];
                dataGridView1.Rows[n].Cells[7].Value = item["date_employed"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["username"].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item["password"].ToString();
                //dataGridView1.Rows[n].Height = 100;


            }
        }

        //***********************************************************Clear All
        #region Clear_Fields()
        void Clear_Fields()
        {
            //Txt_ID.Clear();
            Txt_FullName.Clear();
            cbo_Role.SelectedItem = -1;
            Txt_Age.Clear();
            Combo_Gender.SelectedIndex = -1;
            Txt_Date_Employed.Clear();
            Txt_Salary.Clear();
            Txt_Username.Clear();
            pictureBox1.Image = null;
        }
        #endregion

        #endregion

        private void Txt_Date_Employed_Click(object sender, EventArgs e)
        {
            Txt_Date_Employed.Text = DateTime.Now.ToString();
        }

        private void Txt_FullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void Combo_Gender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void Txt_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void cbo_Role_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void Txt_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void Txt_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void Txt_PasswordConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }


        /*
         * 
         * protected override void OnResize(EventArgs e)
            {
                 this.WindowState = FormWindowState.Maximized;
         * Point NewLoc = Screen.FromControl(this).WorkingArea.Location;
        //Modifiy the location so any toolbars & taskbar can be easily accessed.
        NewLoc.X += 1;
        NewLoc.Y += 1;
        this.Location = NewLoc;

        Size NewSize = Screen.FromControl(this).WorkingArea.Size;
        //Modifiy the size so any toolbars & taskbar can be easily accessed.
        NewSize.Height -= 1;
        NewSize.Width -= 1;
        this.Size = NewSize;

        this.MinimumSize = this.Size;
        this.MaximumSize = this.MinimumSize;
            }
         * 
         * */
    }
}
