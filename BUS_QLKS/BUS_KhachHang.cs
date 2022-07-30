using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKS;
using DAO_QLKS;
using System.Data;
namespace BUS_QLKS
{
    public class BUS_KhachHang
    {
        DAO_KhachHang dao = new DAO_KhachHang();
        public DataTable getKhachHang()
        {
            return dao.getKhachHang();
        }
        public DataTable getMakh()
        {
            return dao.getMakh();
        }
        public DataTable getInfoKH(string data)
        {
            return dao.getInfoKH(data);
                }
        public bool themKhachHang(DTO_KhachHang tv)
        {
            return dao.themKhachHang(tv);
        }
        public bool suaKhachHang(DTO_KhachHang tv)
        {
            return dao.suaKhachHang(tv);
        }
        public bool xoaKhachHang(int MAKH)
        {
            return dao.xoaKhachHang(MAKH);
        }
        public DataTable TimKhachHang(string sql)
        {
            return dao.TimKhachHang(sql);
        }
    }
}
