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
        string d1, d2, d3, d4, d5, d6, d7;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_NhanVien nv = new GUI_NhanVien();
            nv.ShowDialog();
        }
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dtgvNhanVien.DataSource = busNV.getNhanVien();
        }
        private void GUI_TimNV_Load(object sender, EventArgs e)
        {
            dtgvNhanVien.DataSource = busNV.getNhanVien();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dtgvNhanVien.DataSource = busNV.getTimNV(txtFind.Texts);
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvNhanVien.Columns[e.ColumnIndex].Name == "Delete")
            {
                string id = dtgvNhanVien.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    if (busNV.xoaNhanVien(id))
                    {
                        MessageBox.Show("Xóa thành công ");
                        dtgvNhanVien.DataSource = busNV.getNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công ");
                    }
                }
            }
            if (dtgvNhanVien.Columns[e.ColumnIndex].Name == "Edit")
            {
                d1 = dtgvNhanVien.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                d2 = dtgvNhanVien.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
                d3 = dtgvNhanVien.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString();
                d4 = dtgvNhanVien.Rows[e.RowIndex].Cells["Column9"].FormattedValue.ToString();
                d5 = dtgvNhanVien.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString();
                d6 = dtgvNhanVien.Rows[e.RowIndex].Cells["Column5"].FormattedValue.ToString();
                d7 = dtgvNhanVien.Rows[e.RowIndex].Cells["Column8"].FormattedValue.ToString();
                //GUI_DichVu dv = new GUI_DichVu(madv, tendv, loaidv, dongia);
                //dv.ShowDialog();
                GUI_SuaNV DV = new GUI_SuaNV(d1,d2,d3,d4,d5,d6,d7);
                DV.ShowDialog();
            }
        }
    }
}
