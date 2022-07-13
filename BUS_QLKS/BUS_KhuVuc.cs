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
    public class BUS_KhuVuc
    {
        DAO_KhuVuc dao = new DAO_KhuVuc();
        public DataTable getKhuVuc()
        {
            return dao.getKhuVuc();
        }
        public bool themKhuVuc(DTO_KhuVuc tv)
        {
            return dao.themKhuVuc(tv);
        }
        public bool suaKhuVuc(DTO_KhuVuc tv)
        {
            return dao.suaKhuVuc(tv);
        }
        public bool xoaKhuVuc(string MAKV)
        {
            return dao.xoaKhuVuc(MAKV);
        }
    }
}
