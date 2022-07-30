using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QLKS;
using DAO_QLKS;
namespace BUS_QLKS
{
    public class BUS_HoaDon
    {
        DAO_HoaDon dao = new DAO_HoaDon();
        public DataTable getHoaDon()
        {
            return dao.getHoaDon();
        }
        public DataTable getMahd()
        {
            return dao.getMahd();
        }
        public bool themHoaDon(DTO_HoaDon tv)
        {
            return dao.themHoaDon(tv);
        }
    }
}
