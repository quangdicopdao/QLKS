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
    public partial class GUI_TimP : Form
    {
        BUS_Phong busP = new BUS_Phong();
        public GUI_TimP()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_Phong p = new GUI_Phong();
            p.ShowDialog();
        }

        private void GUI_TimP_Load(object sender, EventArgs e)
        {
            dtgvPhong.DataSource = busP.getPhong();
        }

    }
}
