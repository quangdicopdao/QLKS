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
    public class DAO_ThanhVien : DBConnect
    {
        //GET USER
        public DataTable getInHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT HOADON.MAHD, KHACHHANG.MAKH, KHACHHANG.TENKH, DICHVU.MADV, DICHVU.TENDV, CTHOADON.SOLUONG, DICHVU.DONGIA, DATPHONG.MADP, PHONG.MAPHONG, PHONG.DONGIA AS DONGIAPHONG FROM  CTHOADON INNER JOIN DICHVU ON CTHOADON.MADV = DICHVU.MADV INNER JOIN HOADON ON CTHOADON.MAHD = HOADON.MAHD INNER JOIN KHACHHANG ON HOADON.MAKH = KHACHHANG.MAKH INNER JOIN DATPHONG ON KHACHHANG.MAKH = DATPHONG.MAKH INNER JOIN PHONG ON DATPHONG.MAPHONG = PHONG.MAPHONG ", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getThanhVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [THANHVIEN] ", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // GET USER NAME
        public DataTable getTenDangNhap()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TENDANGNHAP FROM [THANHVIEN] ", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //GET PASS
        public DataTable getMatKhau()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MATKHAU FROM [THANHVIEN] ", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //GET MAKS
        public DataTable getMAKS()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAKS FROM [THANHVIEN]", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getPhanQuyen(string data)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT PHANQUYEN FROM [THANHVIEN] WHERE TENDANGNHAP = '"+data+"'", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getMaks(string data)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAKS FROM [THANHVIEN] WHERE TENDANGNHAP = '" + data + "'", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Them user
        public bool themThanhVien(DTO_ThanhVien us)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO THANHVIEN(TENDANGNHAP,MATKHAU,PHANQUYEN,MAKS) VALUES('{0}','{1}','{2}','{3}')", us.THANHVIEN_TENDANGNHAP, us.THANHVIEN_MATKHAU, us.THANHVIEN_PHANQUYEN, us.THANHVIEN_MAKS);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        //sua user
        public bool suaThanhVien(DTO_ThanhVien us)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE [THANHVIEN] SET TENDANGNHAP = '{0}', MATKHAU = '{1}', PHANQUYEN = '{2}' WHERE MAKS = '{3}'", us.THANHVIEN_TENDANGNHAP,us.THANHVIEN_MATKHAU, us.THANHVIEN_PHANQUYEN, us.THANHVIEN_MAKS);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        //XOA USER
        public bool xoaThanhVien(string Id)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM[THANHVIEN] WHERE TENDANGNHAP = '{0}'", Id);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        //doi mk
        
    }
}
