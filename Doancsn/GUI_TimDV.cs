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
    public partial class GUI_TimDV : Form
    {
        BUS_DichVu busDV = new BUS_DichVu();
        public GUI_TimDV()
        {
            InitializeComponent();
            
        }
         string madv, tendv, loaidv, dongia;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_DichVu dv = new GUI_DichVu();
            dv.ShowDialog();
        }
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dtgvDichVu.DataSource = busDV.getDichVu();

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void iconPictureBoxFind_Click(object sender, EventArgs e)
        {
            txtFind.Texts.ToUpper();
           dtgvDichVu.DataSource = busDV.getTimKiem("SELECT * FROM DICHVU WHERE TENDV LIKE '%"+txtFind.Texts.Trim()+"'");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dtgvDichVu.DataSource = busDV.getDichVu();
        }
        private void GUI_TimDV_Load(object sender, EventArgs e)
        {
            //
            dtgvDichVu.DataSource = busDV.getDichVu();
        }

        private void dtgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDichVu.Columns[e.ColumnIndex].Name == "Delete")
            {
                string id = dtgvDichVu.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    if (busDV.xoaDichVu(id))
                    {
                        MessageBox.Show("Xóa thành công ");
                        dtgvDichVu.DataSource = busDV.getDichVu();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công ");
                    }
                }
            }
            if(dtgvDichVu.Columns[e.ColumnIndex].Name == "Edit")
            {
                madv = dtgvDichVu.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                tendv = dtgvDichVu.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
                loaidv = dtgvDichVu.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString();
                dongia = dtgvDichVu.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString();

                //GUI_DichVu dv = new GUI_DichVu(madv, tendv, loaidv, dongia);
                //dv.ShowDialog();
                GUI_SuaDV DV = new GUI_SuaDV(madv,tendv,loaidv,dongia);
                DV.ShowDialog();
            }
            
        }
    }
    }

