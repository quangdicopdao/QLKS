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
            GUI_TrangChu tc = new GUI_TrangChu();
            tc.Show();
            this.Hide();
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
