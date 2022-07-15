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
    public class BUS_Users
    {
        DAO_Users dao = new DAO_Users();
        public DataTable getUsers()
        {
            return dao.getUsers();
        }
        public DataTable getUserName()
        {
            return dao.getUserName();
        }
        public DataTable getPass()
        {
            return dao.getPass();
        }
        public DataTable getMAKS()
        {
            return dao.getMAKS();
        }
        public bool themUser(DTO_Users us)
        {
            return dao.themUser(us);
        }
        public bool suaUser(DTO_Users us)
        {
            return dao.suaUser(us);
        }
        public bool xoaUser(string us)
        {
            return dao.xoaUser(us);
        }

    }
}
