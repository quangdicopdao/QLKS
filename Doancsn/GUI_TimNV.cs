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
    public partial class GUI_TimNV : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        public GUI_TimNV()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_NhanVien nv = new GUI_NhanVien();
            nv.ShowDialog();
        }

        private void GUI_TimNV_Load(object sender, EventArgs e)
        {
            dtgvNhanVien.DataSource = busNV.getNhanVien();
        }
    }
}
