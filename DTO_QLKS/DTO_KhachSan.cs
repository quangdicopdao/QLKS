using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_KhachSan
    {
        private string _KHACHSAN_MAKS;
        private string _KHACHSAN_TENKS;
        private string _KHACHSAN_DIACHI;
        private string _KHACHSAN_MAKV;
        private int _KHACHSAN_SOPHONG;

        public string KHACHSAN_MAKS
        {
            get { return _KHACHSAN_MAKS; }
            set { _KHACHSAN_MAKS = value; }
        }
        public string KHACHSAN_TENKS
        {
            get { return _KHACHSAN_TENKS; }
            set { _KHACHSAN_TENKS = value; }
        }
        public string KHACHSAN_DIACHI
        {
            get { return _KHACHSAN_DIACHI; }
            set { _KHACHSAN_DIACHI = value; }
        }
        public string KHACHSAN_MAKV
        {
            get { return _KHACHSAN_MAKV; }
            set { _KHACHSAN_MAKV = value; }
        }
        public int KHACHSAN_SOPHONG
        {
            get { return _KHACHSAN_SOPHONG; }
            set { _KHACHSAN_SOPHONG = value; }
        }
        public DTO_KhachSan()
        {

        }
        public DTO_KhachSan(string maks, string tenks, string diachi, int sophong, string makv)
        {
            this.KHACHSAN_TENKS = tenks;
            this.KHACHSAN_MAKS = maks;
            this.KHACHSAN_DIACHI = diachi;
            this.KHACHSAN_MAKV = makv;
            this.KHACHSAN_SOPHONG = sophong;
        }
    }
}
