using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_DatPhong
    {
        private int MaDP;
        private string MaP;
        private int MaKH;
        private string NgayDatPhong,NgayTraPhong,GioDatPhong,GioTraPhong;
        

        public int MaDatPhong
        {
            get { return MaDP; }
            set { MaDP = value; }
        }
        public string MaPhong
        {
            get { return MaP; }
            set { MaP = value; }
        }
        public int MaKhachHang
        {
            get { return MaKH; }
            set { MaKH = value; }
        }
        public string Ngaydatphong
        {
            get { return NgayDatPhong; }
            set { NgayDatPhong = value; }
        }
        public string Ngaytraphong
        {
            get { return NgayTraPhong; }
            set { NgayTraPhong = value; }
        }
        public string Giodatphong
        {
            get { return GioDatPhong; }
            set { GioDatPhong = value; }
        }
        public string Giotraphong
        {
            get { return GioTraPhong; }
            set { GioTraPhong = value; }
        }
        public DTO_DatPhong()
        {

        }
        public DTO_DatPhong(int madp, string maphong, int makh, string ngaydatphong, string ngaytraphong, string giodatphong, string giotraphong)
        {
            this.MaDatPhong = madp;
            this.MaPhong = maphong;
            this.MaKhachHang = makh;
            this.Ngaydatphong = ngaydatphong;
            this.Ngaytraphong = ngaytraphong;
            this.Giodatphong = giodatphong;
            this.Giotraphong = giotraphong;
        }
    }
}
