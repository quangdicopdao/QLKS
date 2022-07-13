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
    public partial class GUI_DichVu : Form
    {
        BUS_DichVu busDV  = new BUS_DichVu();
        public GUI_DichVu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public GUI_DichVu(string dt1,string dt2,string dt3,string dt4)
        {
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

        private void GUI_DichVu_Load(object sender, EventArgs e)
        {
            
        }

        private void iconPictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMadv.Texts = null;
            txtTendv.Texts = null;
            txtDonGia.Texts = null;
            cboLoaidv.Texts = null;
            txtMadv.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMadv.Texts != "" && txtTendv.Texts != ""  && txtDonGia.Texts != "" && cboLoaidv.Texts != "")
            {
                DTO_DichVu dt = new DTO_DichVu(txtMadv.Texts, txtTendv.Texts, cboLoaidv.Texts, Convert.ToInt32(txtDonGia.Texts));
                if (busDV.themDichVu(dt))
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
    }
}
