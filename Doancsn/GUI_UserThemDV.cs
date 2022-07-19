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
using System.Data;
using BUS_QLKS;
using DTO_QLKS;
namespace Doancsn
{
    public partial class GUI_UserThemDV : Form
    {
        string lbText,makh;
        int dem = 0;
        DataTable tbChondv;
        string row1,row2,row3,row4;
        BUS_KhachHang busKH = new BUS_KhachHang();
        BUS_DichVu busDV = new BUS_DichVu();
        BUS_KhachSan busKS = new BUS_KhachSan();
        BUS_HoaDon busHD = new BUS_HoaDon();
        BUS_Phong busP = new BUS_Phong();
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
            this.Hide();
            
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void GUI_UserThemDV_Load(object sender, EventArgs e)
        {
            loadInfo();
            loadDatPhong();
            lbRoom.Text = lbText;
            dtgvThemDV.DataSource = busDV.getLoadTatCa();
            //add datatable
            tbChondv = new DataTable();
            tbChondv.Columns.Add("Tên dịch vụ");
            tbChondv.Columns.Add("Giá dịch vụ");
            tbChondv.Columns.Add("Số lượng");
            tbChondv.Columns.Add("Thành tiền");

            dtgvChonDV.DataSource = tbChondv;
            dtgvChonDV.Columns[0].Width = (int)(dtgvChonDV.Width * 0.25);
            dtgvChonDV.Columns[1].Width = (int)(dtgvChonDV.Width * 0.2);
            dtgvChonDV.Columns[2].Width = (int)(dtgvChonDV.Width * 0.2);
            dtgvChonDV.Columns[3].Width = (int)(dtgvChonDV.Width * 0.2);
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            btnThanhToan.Visible = true;
            btnSave.Visible = true;
            btnNhanPhong.Visible = false;
        }
        void loadDatPhong()
        {
            txtMaphong.Texts = lbText;

            //GET MAHD
            cboMahd.DisplayMember = "MAHD";
            cboMahd.ValueMember = "MAHD";
            cboMahd.DataSource = busHD.getMahd();
            //GET MAKH
            cboMakh.DisplayMember = "MAKH";
            cboMakh.ValueMember = "MAKH";
            cboMakh.DataSource = busKH.getMakh();
            // get dpmakh
            cboDPMakh.DisplayMember = "MAKH";
            cboDPMakh.ValueMember = "MAKH";
            cboDPMakh.DataSource = busKH.getMakh();
        }
        void loadInfo()
        {
            DataTable dt = busKH.getInfoKH(cboMakh.Texts);
            DataTable dp = busP.getInfoDatPhong(lbText);
            if (dp.Rows.Count > 0)
            {
                cboDPMakh.Texts = dp.Rows[0]["MAKH"].ToString();
                dpkNgaydat.Text = dp.Rows[0]["NGAYDATPHONG"].ToString();
                dpkNgaydat.Text = dp.Rows[0]["NGAYTRAPHONG"].ToString();
                cboGioNhan.Texts =dp.Rows[0]["GIODATPHONG"].ToString();
                cboGioTra.Texts = dp.Rows[0]["GIOTRAPHONG"].ToString();
            }
            if (dt.Rows.Count > 0)
            {
                txtTenkh.Texts = dt.Rows[0]["TENKH"].ToString();
                txtCCCD.Texts = dt.Rows[0]["CCCD"].ToString();
                dpkNgaysinh.Text = dt.Rows[0]["NGAYSINH"].ToString();

            }
        }
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            //loadDatPhong();
            loadInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                //save info customer
                if(btnNam.Checked == true)
                {
                    DTO_KhachHang dt = new DTO_KhachHang(0, txtTenkh.Texts, true, txtCCCD.Texts, dpkNS.Text);
                    if (busKH.themKhachHang(dt))
                    {
                        MessageBox.Show("Thêm khách hàng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng không thành công!");
                    }
                }
                else if(btnNu.Checked == true)
                {
                    DTO_KhachHang dt = new DTO_KhachHang(0, txtTenkh.Texts, false, txtCCCD.Texts, dpkNS.Text);
                    if (busKH.themKhachHang(dt))
                    {
                        MessageBox.Show("Thêm khách hàng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng không thành công!");
                    }
                }
                
            }
            else
            {

            }
        }

        private void cboLoaidv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLoaidv.SelectedIndex == 0)
            {
                dtgvThemDV.DataSource = busDV.getLoadTatCa();
            }
            else{
                dtgvThemDV.DataSource = busDV.getThemdv(cboLoaidv.Text);
            }
        }

        private void dtgvThemDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgvThemDV.Columns[e.ColumnIndex].Name == "Add")
            {
                string tendv = dtgvThemDV.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
                int gia = int.Parse(dtgvThemDV.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString());
                
                //
                DataRow row;
                
                bool check = true;
                foreach(DataRow item in tbChondv.Rows)
                {
                    if (item[0].ToString() == tendv) 
                    {
                        item[2] = int.Parse(item[2].ToString()) + 1;
                        item[3] = int.Parse(item[1].ToString()) * int.Parse(item[2].ToString());
                        check = false;
                        break;
                    }
                }
                if(check)
                {
                    row = tbChondv.NewRow();
                    row[0] = tendv;
                    row[1] = gia;
                    row[2] = 1;
                    row[3] = gia;
                    tbChondv.Rows.Add(row);
                    row1 = row[0].ToString();
                    row2 = row[1].ToString();
                    row3 = row[2].ToString();
                    row4 = row[3].ToString();
                }
                

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbChondv.Rows.Clear();

        }

        
    }
}
