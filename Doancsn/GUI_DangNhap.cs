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
using System.Data;
using System.Data.SqlClient;
namespace Doancsn
{
    public partial class GUI_DangNhap : Form
    {
        public GUI_DangNhap()
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
            Application.Exit(); 
        }

        private void paneltileClose_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AuthoLogin";
                cmd.Parameters.AddWithValue("@UserName", txtUserName.Texts);
                cmd.Parameters.AddWithValue("@Password", txtPass.Texts);
                cmd.Connection = conn;
                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                // admin dang nhap form trang chu full
                if (code == 0)
                {
                    GUI_TrangChu tc = new GUI_TrangChu("Chủ khách sạn",txtUserName.Texts);
                    tc.Show();
                    this.Hide();
                }
                // quan ly dang nhap form trang chu chi xu ly khach san minh
                else if (code == 1)
                {
                    GUI_TrangChu tc = new GUI_TrangChu("Quản lý",txtUserName.Texts);
                    tc.Show();
                    this.Hide();
                }
                // nhan vien dang nhap ben form user
                else if (code == 2)
                {
                    GUI_User us = new GUI_User();
                    us.Show();
                    this.Hide();
                   
                }//
                else if( code == 3)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu  !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPass.Texts = "";
                    txtUserName.Texts = "";
                    txtUserName.Focus();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPass.Texts = "";
                    txtUserName.Texts = "";
                    txtUserName.Focus();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxSaveInfo_CheckedChanged(object sender, EventArgs e)
        {
            if(txtUserName.Texts != "" && txtPass.Texts != "")
            {
                if(cbxSaveInfo.Checked == true)
                {
                    string users = txtUserName.Texts;
                    string pass = txtPass.Texts;    
                    Properties.Settings.Default.username = users;
                    Properties.Settings.Default.password = pass;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }

        private void GUI_DangNhap_Load(object sender, EventArgs e)
        {
            txtUserName.Texts = Properties.Settings.Default.username;
            txtPass.Texts = Properties.Settings.Default.password;
            if(Properties.Settings.Default.username != "")
            {
                cbxSaveInfo.Checked = true;
            }
        }
    }
}
