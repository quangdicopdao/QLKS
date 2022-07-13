using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_KhachHang
    {
        private int _KHACHHANG_MAKH;
        private string _KHACHHANG_TENKH;
        private bool _KHACHHANG_GIOITINH;
        private string _KHACHHANG_CCCD;
        private string _KHACHHANG_NGAYSINH;

        public int KHACHHANG_MAKH
        {
            get { return _KHACHHANG_MAKH; }
            set { _KHACHHANG_MAKH = value; }
        }
        public string KHACHHANG_TENKH
        {
            get { return _KHACHHANG_TENKH; }
            set { _KHACHHANG_TENKH = value; }
        }
        public bool KHACHHANG_GIOITINH
        {
            get { return _KHACHHANG_GIOITINH; }
            set { _KHACHHANG_GIOITINH = value; }
        }
        public string KHACHHANG_CCCD
        {
            get { return _KHACHHANG_CCCD; }
            set { _KHACHHANG_CCCD = value; }
        }
        public string KHACHHANG_NGAYSINH
        {
            get { return _KHACHHANG_NGAYSINH; }
            set { _KHACHHANG_NGAYSINH = value; }
        }

        public DTO_KhachHang()
        {

        }
        public DTO_KhachHang(int id, string tenkh, bool gt, string cccd, string ngaysinh)
        {
            this.KHACHHANG_MAKH = id;
            this.KHACHHANG_TENKH = tenkh;
            this.KHACHHANG_GIOITINH = gt;
            this.KHACHHANG_CCCD = cccd;
            this.KHACHHANG_NGAYSINH = ngaysinh;
        }
    }
}
