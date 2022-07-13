using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKS;
using DAO_QLKS;
using System.Data;
using System.Collections;

namespace BUS_QLKS
{
    public class BUS_NhanVien
    {
        DAO_NhanVien dao = new DAO_NhanVien();
        public DataTable getNhanVien()
        {
            return dao.getNhanVien();
        }
        public bool themNhanVien(DTO_NhanVien tv)
        {
            return dao.themNhanVien(tv);
        }
        public bool suaNhanVien(DTO_NhanVien tv)
        {
            return dao.suaNhanVien(tv);
        }
        public bool xoaNhanVien(string MANV)
        {
            return dao.xoaNhanVien(MANV);
        }

    }
}
