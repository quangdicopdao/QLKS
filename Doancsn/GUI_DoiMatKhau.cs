using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using DTO_QLKS;
using BUS_QLKS;

namespace Doancsn
{
    public partial class GUI_DoiMatKhau : Form
    {
        BUS_ThanhVien bus = new BUS_ThanhVien();
        public GUI_DoiMatKhau()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPass.Checked)
            {
                txtPassNewAgain.PasswordChar = false;
                txtPassNew.PasswordChar = false;
                txtPassOld.PasswordChar = false;
            }
            else
            {
                txtPassNewAgain.PasswordChar = true;
                txtPassNew.PasswordChar = true;
                txtPassOld.PasswordChar = true;
            }
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public bool Check()
        {
            if (txtUserName.Texts == "") 
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập !");
                txtUserName.Focus();
                return false;
            }
            else if(txtPassOld.Texts == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại !");
                txtPassOld.Focus();
                return false;
            }
            else if (txtPassNew.Texts == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới !");
                txtPassNew.Focus();
                return false;
            }
            else if (txtPassNewAgain.Texts == "")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới  !");
                txtPassNewAgain.Focus();
                return false;
            }
            else if(txtPassNew.Texts != txtPassNewAgain.Texts)
            {
                MessageBox.Show("Nhập lại mật khẩu k chính xác  !");
                txtPassNew.Focus();
                txtPassNewAgain.Select();
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DoiMatKhau";
                    cmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = txtUserName.Texts;
                    cmd.Parameters.Add("@OldPass", SqlDbType.NVarChar).Value = txtPassOld.Texts;
                    cmd.Parameters.Add("@NewPass", SqlDbType.NVarChar).Value = txtPassNew.Texts;
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.GetInt32(0) == 1)
                    {
                        MessageBox.Show(dr.GetString(1));
                        txtPassOld.Texts = "";
                        txtPassNew.Text = "";
                        txtPassOld.Focus();
                    }
                    else
                    {
                        MessageBox.Show(dr.GetString(1));
                        txtPassOld.Focus();
                        txtPassOld.Select();
                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void GUI_DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
