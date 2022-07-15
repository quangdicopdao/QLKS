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
    public partial class GUI_Phong : Form
    {

        BUS_Phong BUS = new BUS_Phong();
        public GUI_Phong()
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
            txtMaphong.Texts = null;
            txtDonGia.Texts = null;
            cboLoaiPhong.Texts = null;
            cboMaks.Texts = null;
            cboTrangThai.Texts = null;
            txtMaphong.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMaphong.Texts != "" && txtDonGia.Texts != "" && cboLoaiPhong.Texts !="" && cboMaks.Texts!="" && cboTrangThai.Texts != "")
            {
                DTO_Phong DT = new DTO_Phong(txtMaphong.Texts, cboLoaiPhong.Texts, Convert.ToInt32(txtDonGia.Texts), cboTrangThai.Texts, cboMaks.Texts);
                if (BUS.themPhong(DT))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
            }
        }

        private void GUI_Phong_Load(object sender, EventArgs e)
        {
            cboMaks.DisplayMember = "MAKS";
            cboMaks.ValueMember = "MAKS";
            cboMaks.DataSource = BUS.getMAKS();
        }
    }
}
