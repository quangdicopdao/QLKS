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
using BUS_QLKS;
using DTO_QLKS;
namespace Doancsn
{
    public partial class GUI_UserThemDV : Form
    {
        string lbText;
        BUS_DichVu bus = new BUS_DichVu();
        public GUI_UserThemDV()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public GUI_UserThemDV(string data)
        {
            this.lbText = data;
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

        private void iconButtonPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
            GUI_UserDatPhongDichVu pdv = new GUI_UserDatPhongDichVu(lbText);
            pdv.ShowDialog();
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void GUI_ThemDV_Load(object sender, EventArgs e)
        {
            dtgvThemDV.DataSource = bus.getLoadTatCa();
        }

        private void cboLoaidv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLoaidv.SelectedIndex == 0)
            {
                dtgvThemDV.DataSource = bus.getLoadTatCa();
            }
            else
            {
                dtgvThemDV.DataSource = bus.getThemdv(cboLoaidv.Text);
            }
        }
        int soluong = 0;
        private void dtgvThemDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgvThemDV.Columns[e.ColumnIndex].Name == "Add")
            {

            }
        }
    }
}
