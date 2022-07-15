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
    public partial class GUI_SuaP : Form
    {
        string dt1,dt2,dt3,dt4,dt5;
        BUS_Phong bus = new BUS_Phong();
        public GUI_SuaP(string d1,string d2,string d3,string d4,string d5)
        {
            InitializeComponent();
            dt1 = d1;
            dt2 = d2;
            dt3 = d3;
            dt4 = d4;
            dt5 = d5;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void GUI_SuaP_Load(object sender, EventArgs e)
        {
            txtMaphong.Texts = dt1;
            cboLoaiphong.Texts = dt2;
            txtDongia.Texts = dt3;
            cboTrangthai.Texts = dt4;
            cboMaks.Texts = dt5;

            // get cbo

            cboMaks.DisplayMember = "MAKS";
            cboMaks.ValueMember = "MAKS";
            cboMaks.DataSource = bus.getMAKS();
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelThem_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaphong.Texts != "" && txtDongia.Texts != "" && cboLoaiphong.Texts != "" && cboMaks.Texts != "" && cboTrangthai.Texts != "")
            {
                DTO_Phong DT = new DTO_Phong(txtMaphong.Texts, cboLoaiphong.Texts, Convert.ToInt32(txtDongia.Texts), cboTrangthai.Texts, cboMaks.Texts);
                if (bus.suaPhong(DT))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
            }
        }
    }
}
