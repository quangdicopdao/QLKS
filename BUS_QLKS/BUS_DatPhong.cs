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
    public class BUS_DatPhong
    {
        DAO_DatPhong dao = new DAO_DatPhong();
        public bool themDatPhong(DTO_DatPhong tv)
        {
            return dao.themDatPhong(tv);
        }
    }
}
