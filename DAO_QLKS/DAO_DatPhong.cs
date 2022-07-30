using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKS;
using System.Data;
using System.Data.SqlClient;
namespace DAO_QLKS
{
    public class DAO_DatPhong:DBConnect
    {
        public bool themDatPhong(DTO_DatPhong tv)
        {
            try
            {
                // Ket noi
                _conn.Open();
                string SQL = string.Format("INSERT INTO [DATPHONG](MAPHONG,MAKH,NGAYDATPHONG,NGAYTRAPHONG,GIODATPHONG,GIOTRAPHONG) VALUES('{0}', '{1}','{2}','{3}','{4}','{5}')",tv.MaPhong,tv.MaKhachHang,tv.Ngaydatphong,tv.Ngaytraphong,tv.Giodatphong,tv.Giotraphong);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                _conn.Close(); // Đóng kết nối
            }
            return false;
        }
    }
}
