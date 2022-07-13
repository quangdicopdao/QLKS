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
    public partial class GUI_KhachSan : Form
    {
        BUS_KhachSan bus = new BUS_KhachSan();
        public GUI_KhachSan()
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelThem_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDiaChi.Texts = null;
            txtMaks.Texts = null;
            txtSoPhong.Texts = null;
            txtTenks.Texts = null;
            cboMakv.Texts = null;
            txtMaks.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaks.Texts != "" && txtTenks.Texts != "" && txtDiaChi.Texts !="" && txtSoPhong.Texts !="" && cboMakv.Texts != "")
            {
                DTO_KhachSan dt = new DTO_KhachSan(txtMaks.Texts,txtTenks.Texts,txtDiaChi.Texts,Convert.ToInt32(txtSoPhong.Texts),cboMakv.Texts);
                if (bus.themKhachSan(dt))
                {
                    MessageBox.Show("Thêm thành công");
                    //dtgv.DataSource = bus.getDichVu();
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

        private void GUI_KhachSan_Load(object sender, EventArgs e)
        {
            cboMakv.DisplayMember = "MAKV";
            cboMakv.DataSource = bus.getMAKV();
        }
    }
}
