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

namespace Doancsn
{
    public partial class GUI_DoiMatKhau : Form
    {
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
                txtPassOld.PasswordChar = false;
            }
            else
            {
                txtPassNewAgain.PasswordChar = true;
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
                lbThongBao.Text = "Vui lòng nhập tên đăng nhập !";
                txtUserName.Focus();
                return false;
            }
            else if(txtPassOld.Texts == "")
            {
                lbThongBao.Text = "Vui lòng nhập mật khẩu hiện tại !";
                txtPassOld.Focus();
                return false;
            }
            else if (txtPassNew.Texts == "")
            {
                lbThongBao.Text = "Vui lòng nhập mật khẩu mới !";
                txtPassNew.Focus();
                return false;
            }
            else if (txtPassNewAgain.Texts == "")
            {
                lbThongBao.Text = "Vui lòng nhập lại mật khẩu mới !";
                txtPassNewAgain.Focus();
                return false;
            }
            else if(txtPassNew.Texts != txtPassNewAgain.Texts)
            {
                lbThongBao.Text = "Mật khẩu mới và xác nhận mật khẩu k chính xác !";
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

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
