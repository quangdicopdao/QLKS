using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_Phong
    {
        private string _PHONG_MAPHONG;
        private string _PHONG_LOAIPHONG;
        private string _PHONG_MAKS;
        private int _PHONG_DONGIA;
        private bool _PHONG_TRANGTHAI;

        public string PHONG_MAPHONG
        {
            get { return _PHONG_MAPHONG; }
            set { _PHONG_MAPHONG = value; }
        }
        public string PHONG_LOAIPHONG
        {
            get { return _PHONG_LOAIPHONG; }
            set { _PHONG_LOAIPHONG = value; }
        }
        public int PHONG_DONGIA
        {
            get { return _PHONG_DONGIA; }
            set { _PHONG_DONGIA = value; }
        }
        public bool PHONG_TRANGTHAI
        {
            get { return _PHONG_TRANGTHAI; }
            set { _PHONG_TRANGTHAI = value; }
        }
        public string PHONG_MAKS
        {
            get { return _PHONG_MAKS; }
            set { _PHONG_MAKS = value; }
        }

        public DTO_Phong()
        {

        }
        public DTO_Phong(string maphong, string loaiphong, int dongia, bool trangthai, string maks)
        {
            this.PHONG_MAPHONG = maphong;
            this.PHONG_LOAIPHONG = loaiphong;
            this.PHONG_DONGIA = dongia;
            this.PHONG_TRANGTHAI = trangthai;
            this.PHONG_MAKS = maks;
        }
    }
}
