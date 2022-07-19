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
    public class DAO_KhachHang : DBConnect
    {
        public DataTable getKhachHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHACHHANG", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        // get makh

        public DataTable getMakh()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Makh FROM KHACHHANG", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // get info khach hang theo makh
        public DataTable getInfoKH(string data)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHACHHANG WHERE MAKH ='"+data+"'", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Them
        public bool themKhachHang(DTO_KhachHang tv)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string – chú ý TV_ID là giá trị tự tăng dần nên ko cần phải thêm ID
                string SQL = string.Format("INSERT INTO [KHACHHANG](TENKH,GIOITINH,CCCD,NGAYSINH) VALUES(N'{0}', '{1}', '{2}','{3}')", tv.KHACHHANG_TENKH, tv.KHACHHANG_GIOITINH, tv.KHACHHANG_CCCD, tv.KHACHHANG_NGAYSINH);
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
        public bool suaKhachHang(DTO_KhachHang tv)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string
                string SQL = string.Format("UPDATE [KHACHHANG] SET TENKH = N'{0}',GIOITINH = '{1}', CCCD = '{2}',NGAYSINH='{3}' WHERE MAKH = '{4}'", tv.KHACHHANG_TENKH, tv.KHACHHANG_GIOITINH, tv.KHACHHANG_CCCD, tv.KHACHHANG_NGAYSINH, tv.KHACHHANG_MAKH);
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

        public bool xoaKhachHang(int MAKH)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO-ID là đủ
                string SQL = string.Format("DELETE FROM [KHACHHANG] WHERE MAKH ='{0}'", MAKH);
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
