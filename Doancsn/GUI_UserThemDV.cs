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
using System.Data.SqlClient;
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
        BUS_DatPhong busDP = new BUS_DatPhong();
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

            //loadInfo();
            //loadDatPhong();
            txtMaphong.Texts = lbText;
            lbRoom.Text = lbText;
            dtgvThemDV.DataSource = busDV.getLoadTatCa();
            //add datatable
            tbChondv = new DataTable();
            tbChondv.Columns.Add("Tên dịch vụ");
            tbChondv.Columns.Add("Mã dịch vụ");
            tbChondv.Columns.Add("Giá dịch vụ");
            tbChondv.Columns.Add("Số lượng");
            tbChondv.Columns.Add("Thành tiền");

            dtgvChonDV.DataSource = tbChondv;
            dtgvChonDV.Columns[0].Width = (int)(dtgvChonDV.Width * 0.25);
            dtgvChonDV.Columns[1].Width = (int)(dtgvChonDV.Width * 0.2);
            dtgvChonDV.Columns[2].Width = (int)(dtgvChonDV.Width * 0.2);
            dtgvChonDV.Columns[3].Width = (int)(dtgvChonDV.Width * 0.2);
        }
       
       /* void loadDatPhong()
        {
            txtMaphong.Texts = lbText;

            //GET MAHD
            
            //GET MAKH
            
            // get dpmakh
            cboDPMakh.DisplayMember = "MAKH";
            cboDPMakh.ValueMember = "MAKH";
            cboDPMakh.DataSource = busKH.getMakh();
        }
        */
       /* void loadInfo()
        {
            //DataTable dt = busKH.getInfoKH(cboMakh.Texts);
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
        }*/
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateNgaySinh.Text);
            //loadDatPhong();
            //loadInfo();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            if (dtgvChonDV.RowCount > 1)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T8VO5NK\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
                for (int i = 0; i < dtgvChonDV.Rows.Count - 1; i++)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO CTHOADON(MAHD,MADV,SOLUONG) VALUES ('" + txtMaHD.Texts + "','" + dtgvChonDV.Rows[i].Cells[1].Value + "','" + dtgvChonDV.Rows[i].Cells[3].Value + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            if (dtgvChonDV.RowCount == 1)
            {
                
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T8VO5NK\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
                    //dtgvChonDV.Rows[i].Cells[1].Value
                    SqlCommand cmd = new SqlCommand("INSERT INTO CTHOADON(MAHD) VALUES ('" + txtMaHD.Texts + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    
            }
            GUI_Test n = new GUI_Test();
            n.Show();
        }

        private void btnL_Click(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 1)
            {
                
                int makh = int.Parse(cboDPMakh.Texts);
                DTO_HoaDon hd = new DTO_HoaDon(txtMaHD.Texts, makh);
                DTO_DatPhong dp = new DTO_DatPhong(0,txtMaphong.Texts,makh,D1.Text,D2.Text,cboGioNhan.Texts,cboGioTra.Texts);
                if (busHD.themHoaDon(hd) && busDP.themDatPhong(dp))
                {
                    MessageBox.Show("Đặt phòng thành công!");
                }
                else
                {
                    MessageBox.Show("Đặt phòng không thành công!");
                }
            }
            
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            
            
            cboDPMakh.DisplayMember = "MAKH";
            cboDPMakh.ValueMember = "MAKH";
            cboDPMakh.DataSource = busKH.getMakh();
            
        }
        

        private void btnN_Click(object sender, EventArgs e)
        {
            
            if (tabControl1.SelectedIndex == 0)
            {
                btnL.Visible = true;
                btnTT.Visible = true;
                //btnN.Text = "Thêm hóa đơn";
                btnN.Visible=false;
                //save info customer
                if (btnNam.Checked == true)
                {
                    DTO_KhachHang dt = new DTO_KhachHang(0, txtTenkh.Texts, true, txtCCCD.Texts, dateNgaySinh.Text);
                    if (busKH.themKhachHang(dt))
                    {
                        MessageBox.Show("Nhận phòng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Nhận phòng không thành công!");
                        btnN.Visible = true;
                    }
                }
                else if (btnNu.Checked == true)
                {
                    DTO_KhachHang dt = new DTO_KhachHang(0, txtTenkh.Texts, false, txtCCCD.Texts, dateNgaySinh.Text);
                    if (busKH.themKhachHang(dt))
                    {
                        MessageBox.Show("Nhận phòng thành công!");
                        //MessageBox.Show("Thêm khách hàng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Nhận phòng không thành công!");
                        //MessageBox.Show("Thêm khách hàng không thành công!");
                    }
                }

            }
            /*else if (tabControl1.SelectedIndex == 1)
            {
                DTO_HoaDon dt = new DTO_HoaDon(txtMaHD.Texts, int.Parse(cboDPMakh.Texts));
                if (busHD.themHoaDon(dt))
                {
                    MessageBox.Show("Thêm hóa đơn thành công !");
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn không thành công !");

                }
            }*/

        }
        /*
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                //save info customer
                if (btnNam.Checked == true)
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
                else if (btnNu.Checked == true)
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
        */
        
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
                string madv = dtgvThemDV.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString();
                int gia = int.Parse(dtgvThemDV.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString());
                
                //
                DataRow row;
                
                bool check = true;
                foreach(DataRow item in tbChondv.Rows)
                {
                    if (item[0].ToString() == tendv) 
                    {
                        item[3] = int.Parse(item[3].ToString()) + 1;
                        item[4] = int.Parse(item[2].ToString()) * int.Parse(item[3].ToString());
                        check = false;
                        break;
                    }
                }
                if(check)
                {
                    row = tbChondv.NewRow();
                    row[0] = tendv;
                    row[1] = madv;
                    row[2] = gia;
                    row[3] = 1;
                    row[4] = gia;
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
