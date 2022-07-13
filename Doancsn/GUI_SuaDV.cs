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
    public partial class GUI_SuaDV : Form
    {
        BUS_DichVu bus = new BUS_DichVu();
        string madv,tendv,loaidv,dongia;
        public GUI_SuaDV(string data1,string data2,string data3,string data4)
        {
            InitializeComponent();
            madv = data1;
            tendv = data2;
            loaidv = data3;
            dongia = data4;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMadv.Texts != "" && txtTendv.Texts != "" && cboLoaidv.Texts != "" && txtDonGia.Texts != "")
            {
                

                DTO_DichVu dt = new DTO_DichVu(txtMadv.Texts, txtTendv.Texts, cboLoaidv.Texts, Convert.ToInt32(txtDonGia.Texts));
                if (bus.suaDichVu(dt))
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void GUI_SuaDV_Load(object sender, EventArgs e)
        {
            txtMadv.Texts = madv;
            txtTendv.Texts = tendv;
            txtDonGia.Texts = dongia;
            
        }
    }
}
