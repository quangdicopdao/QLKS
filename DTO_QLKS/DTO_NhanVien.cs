using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_NhanVien
    {
        private string _NHANVIEN_MANV;
        private string _NHANVIEN_TENNV;
        private string _NHANVIEN_SDT;
        private string _NHANVIEN_EMAIL;
        private string _NHANVIEN_NGAYSINH;
        private string _NHANVIEN_DIACHI;
        private string _NHANVIEN_MAKS;

        public string NHANVIEN_MANV
        {
            get { return _NHANVIEN_MANV; }
            set { _NHANVIEN_MANV = value; }
        }
        public string NHANVIEN_TENNV
        {
            get { return _NHANVIEN_TENNV; }
            set { _NHANVIEN_TENNV = value; }
        }
        public string NHANVIEN_SDT
        {
            get { return _NHANVIEN_SDT; }
            set { _NHANVIEN_SDT = value; }
        }
        public string NHANVIEN_EMAIL
        {
            get { return _NHANVIEN_EMAIL; }
            set { _NHANVIEN_EMAIL = value; }
        }
        public string NHANVIEN_NGAYSINH
        {
            get { return _NHANVIEN_NGAYSINH; }
            set { _NHANVIEN_NGAYSINH = value; }
        }
        public string NHANVIEN_DIACHI
        {
            get { return _NHANVIEN_DIACHI; }
            set { _NHANVIEN_DIACHI = value; }
        }
        public string NHANVIEN_MAKS
        {
            get { return _NHANVIEN_MAKS; }
            set { _NHANVIEN_MAKS = value; }
        }
        public DTO_NhanVien()
        {
        }
        public DTO_NhanVien(string manv, string tennv, string sdt, string email, string ngaysinh, string diachi, string maks)
        {
            this.NHANVIEN_MANV = manv;
            this.NHANVIEN_TENNV = tennv;
            this.NHANVIEN_SDT = sdt;
            this.NHANVIEN_EMAIL = email;
            this.NHANVIEN_NGAYSINH = ngaysinh;
            this.NHANVIEN_DIACHI = diachi;
            this.NHANVIEN_MAKS = maks;
        }
    }
}
