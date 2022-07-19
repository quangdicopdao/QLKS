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
    public class BUS_KhachSan
    {
        DAO_KhachSan dao = new DAO_KhachSan();
        public DataTable getKhachsan()
        {
            return dao.getKhachsan();
        }
        public DataTable getTimKiem(string data)
        {
            return dao.getTimKiem(data);
        }
        public DataTable getMAKV()
        {
            return dao.getMAKV();
        }
        public DataTable getSoPhong()
        {
            return dao.getSoPhong();
        }
        public DataTable getMaks()
        {
            return dao.getMAKS();
        }
        public bool themKhachSan(DTO_KhachSan tv)
        {
            return dao.themKhachSan(tv);
        }
        public bool suaKhachSan(DTO_KhachSan tv)
        {
            return dao.suaKhachSan(tv);
        }
        public bool xoaKhachSan(string MAKS)
        {
            return dao.xoaKhachSan(MAKS);
        }
    }
}
