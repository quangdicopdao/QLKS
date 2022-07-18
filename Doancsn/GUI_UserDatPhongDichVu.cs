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
    public partial class GUI_UserDatPhongDichVu : Form
    {
        private string btnText;
        private int dem = 0;
        string row1,row2,row3,row4;
        DataTable tbHienThi;
        public GUI_UserDatPhongDichVu(string r1,string r2,string r3,string r4)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            row1 = r1;
            row2 = r2;
            row3 = r3;
            row4 = r4;  
        }

        public GUI_UserDatPhongDichVu(string data)
        {
            InitializeComponent();
            this.btnText = data; 
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void iconButtonPrevious_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       
        private void GUI_DatPhongDichVu_Load(object sender, EventArgs e)
        {
            lbRoom.Text = btnText;
            tbHienThi = new DataTable();
            tbHienThi.Columns.Add("Tên dịch vụ");
            tbHienThi.Columns.Add("Giá dịch vụ");
            tbHienThi.Columns.Add("Số lượng");
            tbHienThi.Columns.Add("Thành tiền");

            dtgvHienThi.DataSource = tbHienThi;
            dtgvHienThi.Columns[0].Width = (int)(dtgvHienThi.Width * 0.3);
            dtgvHienThi.Columns[1].Width = (int)(dtgvHienThi.Width * 0.3);
            dtgvHienThi.Columns[2].Width = (int)(dtgvHienThi.Width * 0.3);

            DataRow row;
            row = tbHienThi.NewRow();
            row[0] = row1;
            row[1] = row2;
            row[2] = row3;
            row[3] = row4;
        }

        private void btnNhanPhongThanhToan_Click(object sender, EventArgs e)
        {
            dem++;
            if (dem == 1)
            {
                btnThemDV.Visible = true;
            }
            else
            {
                btnNhanPhongThanhToan.Text = "Thanh toán";
            }
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            GUI_UserThemDV themdv = new GUI_UserThemDV(btnText);
            themdv.Show();
            this.Hide();
        }
    }
}
