using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS_QLKS;
namespace Doancsn
{
    public partial class GUI_InHoaDon : Form
    {
        public GUI_InHoaDon()
        {
            InitializeComponent();
        }
       
        //SqlDataAdapter da;
        private void GUI_InHoaDon_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T8VO5NK\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT HOADON.MAHD, KHACHHANG.MAKH, KHACHHANG.TENKH, DICHVU.MADV, DICHVU.TENDV, CTHOADON.SOLUONG, DICHVU.DONGIA, DATPHONG.MADP, PHONG.MAPHONG, PHONG.DONGIA AS Expr1 FROM            CTHOADON INNER JOIN DICHVU ON CTHOADON.MADV = DICHVU.MADV INNER JOIN HOADON ON CTHOADON.MAHD = HOADON.MAHD INNER JOIN KHACHHANG ON HOADON.MAKH = KHACHHANG.MAKH INNER JOIN DATPHONG ON KHACHHANG.MAKH = DATPHONG.MAKH INNER JOIN PHONG ON DATPHONG.MAPHONG = PHONG.MAPHONG where HOADON.MAHD =N'"+GUI_Test.MaHD.ToString()+"'", con);
            //SqlDataAdapter da = new SqlDataAdapter("select *from [HOADON]",con);
            // SqlDataAdapter da = new SqlDataAdapter("SELECT HOADON.MAHD, KHACHHANG.MAKH, KHACHHANG.TENKH, DICHVU.MADV, DICHVU.TENDV, CTHOADON.SOLUONG, DICHVU.DONGIA, DATPHONG.MADP, PHONG.MAPHONG FROM  CTHOADON INNER JOIN DICHVU ON CTHOADON.MADV = DICHVU.MADV INNER JOIN HOADON ON CTHOADON.MAHD = HOADON.MAHD INNER JOIN KHACHHANG ON HOADON.MAKH = KHACHHANG.MAKH INNER JOIN DATPHONG ON KHACHHANG.MAKH = DATPHONG.MAKH INNER JOIN PHONG ON DATPHONG.MAPHONG = PHONG.MAPHONG" , con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //da.SelectCommand.CommandText = "SELECT CTHOADON.*,HOADON.MAKH FROM CTHOADON INNER JOIN HOADON ON CTHOADON.MAHD=HOADON.MAHD";
           // DataTable dtHD = new DataTable();
           // da.Fill(dtHD);

             Inhoadon rpt = new Inhoadon();
             rpt.SetDataSource(dt.DefaultView);
             crystalReportViewer1.ReportSource = rpt;
                con.Close();
                con.Dispose();
            //MessageBox.Show(GUI_Test.MaHD.ToString());//WHERE HOADON.MAHD = N'"+ GUI_Test.MaHD.ToString()+"'"
        }
    }
}
