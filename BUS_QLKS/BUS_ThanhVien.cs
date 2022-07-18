using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_QLKS;
using DAO_QLKS;
namespace BUS_QLKS
{
    public class BUS_ThanhVien
    {
        DAO_ThanhVien dao = new DAO_ThanhVien();
        public DataTable getThanhVien()
        {
            return dao.getThanhVien();
        }
        public DataTable getTenDangNhap()
        {
            return dao.getTenDangNhap();
        }
        public DataTable getMatKhau()
        {
            return dao.getMatKhau();
        }
        
        public DataTable getPhanQuyen(string data)
        {
            return dao.getPhanQuyen(data);
        }
        public DataTable getMaksForDoimk(string data)
        {
            return dao.getMaks(data);
        }
        
        
        public bool themThanhVien(DTO_ThanhVien us)
        {
            return dao.themThanhVien(us);
        }
        public bool suaThanhVien(DTO_ThanhVien us)
        {
            return dao.suaThanhVien(us);
        }
        public bool xoaThanhVien(string us)
        {
            return dao.xoaThanhVien(us);
        }

    }

}
