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
namespace Doancsn
{
    public partial class GUI_InHoaDon : Form
    {
        public GUI_InHoaDon()
        {
            InitializeComponent();
        }

        private void GUI_InHoaDon_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T8VO5NK\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select *from [HOADON]", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            XuatHoaDon rpt = new XuatHoaDon();
            rpt.SetDataSource(dt.DefaultView);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
