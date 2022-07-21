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
    public partial class GUI_Setting : Form
    {
        BUS_ThanhVien bus = new BUS_ThanhVien();
        public GUI_Setting()
        {
            InitializeComponent();
        }

        private void GUI_Setting_Load(object sender, EventArgs e)
        {
            dtgvUser.DataSource = bus.getThanhVien();
            cboMaks.DisplayMember = "MAKS";
            cboMaks.ValueMember = "MAKS";
            cboMaks.DataSource = bus.getMAKS();
            //cboPQ.DisplayMember = "PHANQUYEN";
           // cboPQ.ValueMember = "PHANQUYEN";
           // cboPQ.DataSource = bus.getThanhVien();
        }

        private void dtgvUser_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgvUser.SelectedRows[0];
            // Chuyển giá trị lên form
            txtUserName.Texts = row.Cells[0].Value.ToString();
            txtPass.Texts = row.Cells[1].Value.ToString();
            cboPQ.Texts = row.Cells[2].Value.ToString();
            cboMaks.Texts = row.Cells[3].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Texts != "" && txtPass.Texts != "" && cboPQ.Texts != "" && cboMaks.Texts!="")
            {
                // Tạo DTo
                DTO_ThanhVien tv = new DTO_ThanhVien(txtUserName.Texts,txtPass.Texts,cboPQ.Texts,cboMaks.Texts); // Vì ID tự tăng nên để ID số gì cũng dc
                                              // Them
                if (bus.themThanhVien(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dtgvUser.DataSource = bus.getThanhVien(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtgvUser.SelectedRows.Count > 0)
            {
                if (txtUserName.Texts != "" && txtPass.Texts != "" && cboPQ.Texts != "" && cboMaks.Texts != "")
                {
                   
                    DTO_ThanhVien tv = new DTO_ThanhVien(txtUserName.Texts, txtPass.Texts, cboPQ.Texts, cboMaks.Texts);
                    // Sửa
                    if (bus.suaThanhVien(tv))
                        
                    {
                        MessageBox.Show("Sửa thành công");
                        dtgvUser.DataSource = bus.getThanhVien(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgvUser.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dtgvUser.SelectedRows[0];
                string ID = row.Cells[0].Value.ToString();
                // Xóa
                if (bus.xoaThanhVien(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    
                    dtgvUser.DataSource = bus.getThanhVien(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }
    }
}

