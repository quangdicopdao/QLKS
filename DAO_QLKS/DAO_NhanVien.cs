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
    public class DAO_NhanVien : DBConnect
    {
        public DataTable loadCB()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAKS FROM [KHACHSAN]", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //load nhan vien theo maks
        public DataTable loadNhanVienTheoKS(string data)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [NHANVIEN] WHERE MAKS = '"+data+"'", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [NHANVIEN]", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //tim nhan vien
        public DataTable getTimNV(string data)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHANVIEN WHERE TENNV LIKE N'%"+data+"%'", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// Thêm Khách sạn

         public bool themNhanVien(DTO_NhanVien tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO [NHANVIEN](MANV,TENNV,SDT,EMAIL,NGAYSINH,DIACHI,MAKS) VALUES('{0}', N'{1}', '{2}','{3}','{4}',N'{5}','{6}')", tv.NHANVIEN_MANV,tv.NHANVIEN_TENNV,tv.NHANVIEN_SDT,tv.NHANVIEN_EMAIL,tv.NHANVIEN_NGAYSINH,tv.NHANVIEN_DIACHI,tv.NHANVIEN_MAKS);
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
        public bool suaNhanVien(DTO_NhanVien tv)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string
                string SQL = string.Format("UPDATE [NHANVIEN] SET TENNV = '{0}',SDT = '{1}', EMAIL = '{2}', NGAYSINH ='{3}',DIACHI='{4}', MAKS = '{5}' WHERE MANV='{6}'", tv.NHANVIEN_TENNV, tv.NHANVIEN_SDT, tv.NHANVIEN_EMAIL, tv.NHANVIEN_NGAYSINH, tv.NHANVIEN_DIACHI, tv.NHANVIEN_MAKS, tv.NHANVIEN_MANV);
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

        public bool xoaNhanVien(string MANV)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO-ID là đủ
                string SQL = string.Format("DELETE FROM [NHANVIEN] WHERE MANV ='{0}'", MANV);
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
