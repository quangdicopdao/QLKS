using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_DichVu
    {
        private string _DICHVU_MADV;
        private string _DICHVU_TENDV;
        private string _DICHVU_LOAIDV;
        private int _DICHVU_DONGIA;

        public string DICHVU_MADV
        {
            get { return _DICHVU_MADV; }
            set { _DICHVU_MADV = value; }
        }
        public string DICHVU_TENDV
        {
            get { return _DICHVU_TENDV; }
            set { _DICHVU_TENDV = value; }
        }
        public string DICHVU_LOAIDV
        {
            get { return _DICHVU_LOAIDV; }
            set { _DICHVU_LOAIDV = value; }
        }
        public int DICHVU_DONGIA
        {
            get { return _DICHVU_DONGIA; }
            set { _DICHVU_DONGIA = value; }
        }
        public DTO_DichVu()
        {

        }
        public DTO_DichVu(string madv, string tendv, string loaidv, int dongia)
        {
            this.DICHVU_DONGIA = dongia;
            this.DICHVU_TENDV = tendv;
            this.DICHVU_LOAIDV = loaidv;
            this.DICHVU_MADV = madv;
        }
    }
}
