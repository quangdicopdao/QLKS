using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_KhuVuc
    {
        private string _KHUVUC_MAKV;
        private string _KHUVUC_TENKV;

        public string KHUVUC_MAKV
        {
            get { return _KHUVUC_MAKV; }
            set { _KHUVUC_MAKV = value; }
        }
        public string KHUVUC_TENKV
        {
            get { return _KHUVUC_TENKV; }
            set { _KHUVUC_TENKV = value; }
        }
        public DTO_KhuVuc()
        {

        }
        public DTO_KhuVuc(string makv, string tenkv)
        {
            this.KHUVUC_MAKV = makv;
            this.KHUVUC_TENKV = tenkv;
        }
    }
}
