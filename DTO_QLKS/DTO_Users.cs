using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_Users
    {
        string username, password, phanquyen, maks;

        public string UserName { get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Password 
        {
            get { return password; }
            set { password = value; }
        }
        public string Phanquyen
        {
            get { return phanquyen; }
            set { phanquyen = value; }
        }
        public string Maks 
        { get { return maks; }
            set { maks = value; }
        }

        public DTO_Users() { };
        public DTO_Users(string username,string pass,string pq,string maks)
        {
            this.password = pass;
            this.username = username;
            this.phanquyen = pq;
            this.maks = maks;
        }

    }
}
