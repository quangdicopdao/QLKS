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
    public class BUS_DichVu
    {
        DAO_DichVu dao = new DAO_DichVu();
        public DataTable getDichVu()
        {
            return dao.getDichVu();
        }
        public DataTable getTimKiem(string data)
        {
            return dao.getTimKiem(data);
        }
        public bool themDichVu(DTO_DichVu tv)
        {
            return dao.themDichVu(tv);
        }
        public bool suaDichVu(DTO_DichVu tv)
        {
            return dao.suaDichVu(tv);
        }
        public bool xoaDichVu(string MADV)
        {
            return dao.xoaDichVu(MADV);
        }
    }
}
