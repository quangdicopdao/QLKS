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
    public class BUS_Phong
    {
        DAO_Phong dao = new DAO_Phong();
        public DataTable getPhong()
        {
            return dao.getPhong();
        }
        public bool themPhong(DTO_Phong tv)
        {
            return dao.themPhong(tv);
        }
        public bool suaPhong(DTO_Phong tv)
        {
            return dao.suaPhong(tv);
        }
        public bool xoaPhong(string MAPHONG)
        {
            return dao.xoaPhong(MAPHONG);
        }
    }
}
