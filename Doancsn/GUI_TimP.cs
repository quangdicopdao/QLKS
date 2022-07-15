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
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dtgvPhong.DataSource = busP.getPhong();
        }
        private void GUI_TimP_Load(object sender, EventArgs e)
        {
            dtgvPhong.DataSource = busP.getPhong();
        }

        private void iconPictureBoxFInd_Click(object sender, EventArgs e)
        {

        }

        private void dtgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string dt1, dt2, dt3, dt4, dt5;
            if (dtgvPhong.Columns[e.ColumnIndex].Name == "Delete")
            {
                string id = dtgvPhong.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    if (busP.xoaPhong(id))
                    {
                        MessageBox.Show("Xóa thành công ");
                        dtgvPhong.DataSource = busP.getPhong();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công ");
                    }
                }
            }
            if (dtgvPhong.Columns[e.ColumnIndex].Name == "Edit")
            {
                dt1 = dtgvPhong.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                dt2 = dtgvPhong.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
                dt3 = dtgvPhong.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString();
                dt4 = dtgvPhong.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString();
                dt5 = dtgvPhong.Rows[e.RowIndex].Cells["Column5"].FormattedValue.ToString();
                //GUI_DichVu dv = new GUI_DichVu(madv, tendv, loaidv, dongia);
                //dv.ShowDialog();
                GUI_SuaP DV = new GUI_SuaP(dt1, dt2, dt3, dt4, dt5);
                DV.ShowDialog();
            }
        }
    }
}
