using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_HoaDon
    {
        string mahd;
        int makh;
        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        public int Makh
        {
            get { return makh; }
            set { makh = value; }
        }

        public DTO_HoaDon() { }
        public DTO_HoaDon(string mahd,int makh) 
        {
            this.mahd = mahd;
            this.makh = makh;
        }
    }
}
