using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLKS;
using BUS_QLKS;

namespace Doancsn
{
    public partial class GUI_TimKS : Form
    {
        BUS_KhachSan busKS = new BUS_KhachSan();
        public GUI_TimKS()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_KhachSan KS = new GUI_KhachSan();
            KS.ShowDialog();
        }
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dtgvKhachSan.DataSource = busKS.getKhachsan();
        }
        private void GUI_TimKS_Load(object sender, EventArgs e)
        {
            dtgvKhachSan.DataSource = busKS.getKhachsan();
        }

        private void iconPictureBoxFind_Click(object sender, EventArgs e)
        {
            txtFind.Texts.ToUpper();
            dtgvKhachSan.DataSource = busKS.getTimKiem("SELECT * FROM KHACHSAN WHERE TENKS LIKE N'%" + txtFind.Texts.Trim() + "%'");
        }

        private void dtgvKhachSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string dt1,dt2,dt3,dt4,dt5;
            if (dtgvKhachSan.Columns[e.ColumnIndex].Name == "Delete")
            {
                string id = dtgvKhachSan.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    if (busKS.xoaKhachSan(id))
                    {
                        MessageBox.Show("Xóa thành công ");
                        dtgvKhachSan.DataSource = busKS.getKhachsan();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công ");
                    }
                }
            }
            if (dtgvKhachSan.Columns[e.ColumnIndex].Name == "Edit")
            {
                dt1 = dtgvKhachSan.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                dt2 = dtgvKhachSan.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
                dt3 = dtgvKhachSan.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString();
                dt4 = dtgvKhachSan.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString();
                dt5 = dtgvKhachSan.Rows[e.RowIndex].Cells["Column5"].FormattedValue.ToString();
                //GUI_DichVu dv = new GUI_DichVu(madv, tendv, loaidv, dongia);
                //dv.ShowDialog();
                GUI_SuaKS DV = new GUI_SuaKS(dt1, dt2, dt3, dt4, dt5);
                DV.ShowDialog();
            }
        }

        private void dtgvKhachSan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
