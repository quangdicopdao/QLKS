using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLKS;
using BUS_QLKS;
using System.Runtime.InteropServices;

namespace Doancsn
{
    public partial class GUI_SuaKH : Form
    {
        BUS_KhachHang bus = new BUS_KhachHang();
        string dt1, dt2, dt3, dt4, dt5;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool d13;
        private void GUI_SuaKH_Load(object sender, EventArgs e)
        {
            txtMakh.Texts = dt1;
            txtTenkh.Texts = dt2;
            btnNam.Checked = d13;
            txtCCCD.Texts = dt4;
            dpkNgaysinh.Text = dt5;

        }

        private void panelThem_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public GUI_SuaKH(string d1, string d2, bool d3, string d4, string d5)
        {
            InitializeComponent();
            dt1 = d1;
            dt2 = d2;
            d13 = d3;
            dt4 = d4;
            dt5 = d5;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMakh.Texts != "" && txtTenkh.Texts != "" && txtCCCD.Texts !="" && dpkNgaysinh.Text != "" )
            {


                DTO_KhachHang dt = new DTO_KhachHang(Convert.ToInt32( txtMakh.Texts), txtTenkh.Texts, btnNam.Checked, txtCCCD.Texts, dpkNgaysinh.Text) ;
                if (bus.suaKhachHang(dt))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }
    }
}
