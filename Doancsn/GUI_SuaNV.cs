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
    public partial class GUI_SuaNV : Form
    {
        BUS_NhanVien bus = new BUS_NhanVien();
        string d1, d2, d3, d4, d5, d6, d7;

        private void panelThem_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtManv.Texts != "" && txtTennv.Texts != "" && txtSDT.Texts != "" && txtEmail.Texts!="" && txtDiachi.Texts !="" && cboMaks.Texts != "")
            {

                DTO_NhanVien dt = new DTO_NhanVien(txtManv.Texts,txtTennv.Texts,txtSDT.Texts,txtEmail.Texts,dpkNgaysinh.Text,txtDiachi.Texts,cboMaks.Texts);
                if (bus.suaNhanVien(dt))
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

        private void GUI_SuaNV_Load(object sender, EventArgs e)
        {
            txtManv.Texts = d1;
            txtTennv.Texts = d2;
            txtSDT.Texts = d3;
            txtEmail.Texts = d4;
            dpkNgaysinh.Text = d5;
            txtDiachi.Texts = d6;
            cboMaks.Texts = d7;

            // load cbo
            cboMaks.DisplayMember = "MAKS";
            cboMaks.ValueMember = "MAKS";
            cboMaks.DataSource = bus.loadCB();
        }

        public GUI_SuaNV(string dt1,string dt2,string dt3,string dt4,string dt5,string dt6,string dt7)
        {
            InitializeComponent();
            d1 = dt1;
            d2 = dt2;
            d3 = dt3;
            d4 = dt4;
            d5 = dt5;
            d6 = dt6;
            d7 = dt7;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
