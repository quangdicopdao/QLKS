using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLKS;
using DTO_QLKS;

namespace Doancsn
{
    public partial class GUI_TimKH : Form
    {
        BUS_KhachHang busKH = new BUS_KhachHang();
        public GUI_TimKH()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_KhachHang kh = new GUI_KhachHang();
            kh.ShowDialog();
        }

        private void GUI_TimKH_Load(object sender, EventArgs e)
        {
            dtgvKhachHang.DataSource = busKH.getKhachHang();
        }
    }
}
