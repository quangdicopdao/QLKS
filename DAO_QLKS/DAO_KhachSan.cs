using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QLKS;
namespace DAO_QLKS
{
    public class DAO_KhachSan : DBConnect
    {
        public DataTable getKhachsan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [KHACHSAN]", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getTimKiem(string data)
        {
            SqlDataAdapter da = new SqlDataAdapter(data, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getMAKV()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAKV FROM [KHUVUC]", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// Thêm Khách sạn

        public bool themKhachSan(DTO_KhachSan tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO [KHACHSAN](MAKS,TENKS,DIACHI,SOPHONG,MAKV) VALUES('{0}', '{1}', '{2}','{3}','{4}')", tv.KHACHSAN_MAKS, tv.KHACHSAN_TENKS, tv.KHACHSAN_DIACHI, tv.KHACHSAN_SOPHONG, tv.KHACHSAN_MAKV);
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
        public bool suaKhachSan(DTO_KhachSan tv)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string
                string SQL = string.Format("UPDATE [KHACHSAN] SET TENKS = '{0}',DIACHI = '{1}', SOPHONG = '{2}', MAKV ='{3}' WHERE MAKS = '{4}'", tv.KHACHSAN_TENKS, tv.KHACHSAN_DIACHI, tv.KHACHSAN_SOPHONG, tv.KHACHSAN_MAKV, tv.KHACHSAN_MAKS);
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

        public bool xoaKhachSan(string MAKS)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO-ID là đủ
                string SQL = string.Format("DELETE FROM [KHACHSAN] WHERE MAKS ='{0}'", MAKS);
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
