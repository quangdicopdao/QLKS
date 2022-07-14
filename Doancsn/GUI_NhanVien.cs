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
    public partial class GUI_NhanVien : Form
    {
        BUS_NhanVien bus = new BUS_NhanVien();  
        public GUI_NhanVien()
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
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmail.Texts = null;
            txtDiaChi.Texts = null;
            txtManv.Texts = null;
            txtSDT.Texts = null;
            txtTennv.Texts = null;
            dpkNgaySinh.Text = null;
            cboMaks.Text = null;
            txtManv.Focus();
        }

        private void panelThem_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtManv.Texts != "" && txtTennv.Texts != "" && txtSDT.Texts != "" && txtDiaChi.Texts != "")
            {
                string s = txtManv.Texts + "@gmail.com";
                DTO_NhanVien dTO_NhanVien = new DTO_NhanVien(txtManv.Texts, txtTennv.Texts, txtSDT.Texts, s, dpkNgaySinh.Text, txtDiaChi.Texts, cboMaks.Texts);

                if (bus.themNhanVien(dTO_NhanVien))
                {
                    MessageBox.Show("Thêm thành công");
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

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            cboMaks.DisplayMember = "MAKS";
            cboMaks.ValueMember = "MAKS";
            cboMaks.DataSource = bus.loadCB();
        }
    }
}
