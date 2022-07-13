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
    public class DAO_KhuVuc : DBConnect
    {
        public DataTable getKhuVuc()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [KHUVUC]", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool themKhuVuc(DTO_KhuVuc tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO [KHUVUC](MAKV,TENKV) VALUES('{0}', '{1}')", tv.KHUVUC_MAKV, tv.KHUVUC_TENKV);
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
        public bool suaKhuVuc(DTO_KhuVuc tv)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string
                string SQL = string.Format("UPDATE [KHUVUC] SET TENKV = '{0}' WHERE MAKV = '{1}'", tv.KHUVUC_TENKV, tv.KHUVUC_MAKV);
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

        public bool xoaKhuVuc(string MAKV)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO-ID là đủ
                string SQL = string.Format("DELETE FROM [KHUVUC] WHERE MAKV ='{0}'", MAKV);
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
