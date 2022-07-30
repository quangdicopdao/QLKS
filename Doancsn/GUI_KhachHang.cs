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
using DTO_QLKS;
using BUS_QLKS;
namespace Doancsn
{
    public partial class GUI_KhachHang : Form
    {
        BUS_KhachHang bus = new BUS_KhachHang();
        public GUI_KhachHang()
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

        private void panelThem_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaKH.Texts = null;
            txtCCCD.Texts = null;
            txtTenkh.Texts = null;
            dpkNgaySinh.Text = null;
            btnNam.Checked = false;
            btnNu.Checked = false;
            txtMaKH.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ( txtTenkh.Texts != "" && (btnNam.Checked == true || btnNu.Checked == true) && txtCCCD.Texts != "")
            {
                DTO_KhachHang t;
                if (btnNam.Checked)
                {
                    t = new DTO_KhachHang(0, txtTenkh.Texts, true, txtCCCD.Texts, dpkNgaySinh.Text);
                }
                else
                {
                    t = new DTO_KhachHang(0, txtTenkh.Texts, false, txtCCCD.Texts, dpkNgaySinh.Text);
                }
                if (bus.themKhachHang(t))
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
        }

        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
