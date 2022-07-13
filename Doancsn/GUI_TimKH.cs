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
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            GUI_KhachHang kh = new GUI_KhachHang();
            kh.ShowDialog();
        }
        private void GUI_TimKH_Load(object sender, EventArgs e)
        {
            dtgvKhachHang.DataSource = busKH.getKhachHang();
        }

        private void iconPictureBoxFind_Click(object sender, EventArgs e)
        {

        }

        private void dtgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string dt1,dt2,dt3,dt4,dt5;
            bool d3;
            if (dtgvKhachHang.Columns[e.ColumnIndex].Name == "Delete")
            {
                int id = Convert.ToInt32(dtgvKhachHang.Rows[e.RowIndex].Cells["Column1"].FormattedValue);
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    if (busKH.xoaKhachHang(id))
                    {
                        MessageBox.Show("Xóa thành công ");
                        dtgvKhachHang.DataSource = busKH.getKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công ");
                    }
                }
            }
            if (dtgvKhachHang.Columns[e.ColumnIndex].Name == "Edit")
            {
                dt1 =Convert.ToInt32( dtgvKhachHang.Rows[e.RowIndex].Cells["Column1"].FormattedValue).ToString();
                dt2 = dtgvKhachHang.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
                d3 =Convert.ToBoolean( dtgvKhachHang.Rows[e.RowIndex].Cells["Column3"].FormattedValue);
                dt4 = dtgvKhachHang.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString();
                dt5 = dtgvKhachHang.Rows[e.RowIndex].Cells["Column5"].FormattedValue.ToString();
                //GUI_DichVu dv = new GUI_DichVu(madv, tendv, loaidv, dongia);
                //dv.ShowDialog();
                GUI_SuaKH DV = new GUI_SuaKH(dt1,dt2,d3,dt4,dt5);
                DV.ShowDialog();
            }
        }
    }
}
