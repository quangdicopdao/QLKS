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
    public class DAO_DichVu : DBConnect
    {
        public DataTable getDichVu()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [DICHVU]", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getTimKiem(string data)
        {
            SqlDataAdapter da = new SqlDataAdapter(data,_conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// Thêm Khách sạn

        public bool themDichVu(DTO_DichVu tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO [DICHVU](MADV,TENDV,LOAIDV,DONGIA) VALUES('{0}', '{1}', N'{2}','{3}')", tv.DICHVU_MADV, tv.DICHVU_TENDV, tv.DICHVU_LOAIDV, tv.DICHVU_DONGIA);
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
        public bool suaDichVu(DTO_DichVu tv)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string
                string SQL = string.Format("UPDATE [DICHVU] SET TENDV = '{0}',LOAIDV = N'{1}', DONGIA = '{2}' WHERE MADV = '{3}'", tv.DICHVU_TENDV, tv.DICHVU_LOAIDV, tv.DICHVU_DONGIA, tv.DICHVU_MADV);
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

        public bool xoaDichVu(string MADV)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO-ID là đủ
                string SQL = string.Format("DELETE FROM [DICHVU] WHERE MADV ='{0}'", MADV);
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
