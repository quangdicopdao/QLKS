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
    public class DAO_Phong : DBConnect
    {
        public DataTable getPhong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [PHONG]", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //get LOAIPHONG
        public DataTable getLoaiPhong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT LOAIPHONG FROM [PHONG]", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //get MAKS
        public DataTable getMAKS()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAKS FROM [KHACHSAN]", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// Thêm Khách sạn

        public bool themPhong(DTO_Phong tv)
        {
            try
            {
                // Ket noi
                _conn.Open();
                string SQL = string.Format("INSERT INTO [PHONG](MAPHONG,LOAIPHONG,DONGIA,TRANGTHAI,MAKS) VALUES('{0}', '{1}', N'{2}',N'{3}','{4}')", tv.PHONG_MAPHONG, tv.PHONG_LOAIPHONG, tv.PHONG_DONGIA, tv.PHONG_TRANGTHAI, tv.PHONG_MAKS);
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
        //Sửa Khách sạn
        public bool suaPhong(DTO_Phong tv)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string
                string SQL = string.Format("UPDATE [PHONG] SET LOAIPHONG = N'{0}',DONGIA = '{1}', TRANGTHAI = N'{2}', MAKS ='{3}' WHERE MAPHONG = '{4}'", tv.PHONG_LOAIPHONG, tv.PHONG_DONGIA, tv.PHONG_TRANGTHAI, tv.PHONG_MAKS, tv.PHONG_MAPHONG);
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
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }
        // Xóa thành viên

        public bool xoaPhong(string MAPHONG)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO-ID là đủ
                string SQL = string.Format("DELETE FROM [PHONG] WHERE MAPHONG ='{0}'", MAPHONG);
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
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }
    }
}
