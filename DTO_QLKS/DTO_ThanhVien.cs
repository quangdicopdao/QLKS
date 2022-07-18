using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_ThanhVien
    {
        private string _THANHVIEN_TENDANGNHAP;
        private string _THANHVIEN_MATKHAU;
        private string _THANHVIEN_PHANQUYEN;
        private string _THANHVIEN_MAKS;
        public string THANHVIEN_TENDANGNHAP
        {
            get { return _THANHVIEN_TENDANGNHAP; }
            set { _THANHVIEN_TENDANGNHAP = value; }
        }
        public string THANHVIEN_MATKHAU
        {
            get { return _THANHVIEN_MATKHAU; }
            set { _THANHVIEN_MATKHAU = value; }
        }
        public string THANHVIEN_PHANQUYEN
        {
            get { return _THANHVIEN_PHANQUYEN; }
            set { _THANHVIEN_PHANQUYEN = value; }
        }
        public string THANHVIEN_MAKS
        {
            get { return _THANHVIEN_MAKS; }
            set { _THANHVIEN_MAKS = value; }
        }

        public DTO_ThanhVien() { }
        public DTO_ThanhVien(string tendangnhap, string matkhau, string phanquyen, string maks)
        {
            this.THANHVIEN_TENDANGNHAP = tendangnhap;
            this.THANHVIEN_MATKHAU = matkhau;
            this.THANHVIEN_PHANQUYEN = phanquyen;
            this.THANHVIEN_MAKS = maks;
        }
       

    }

}
