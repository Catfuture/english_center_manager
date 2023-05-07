using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QLTT;
using ET_QLTT;

namespace BUS_QLTT
{
    public class BUS_GIANGVIEN
    {
        DAL_GIANGVIEN gv = new DAL_GIANGVIEN();
        public DataTable LayDS()
        {
            return gv.LayDSGiangvien();
        }
        public int Them(ET_GIANGVIEN et)
        {
            return gv.Them(et);
        }
        public int Xoa(string magv)
        {
            return gv.Xoa(magv);
        }
        public int Sua(ET_GIANGVIEN et)
        {
            return gv.Sua(et);
        }
        public DataTable TimkiemMaGV(string magv)
        {
            return gv.TimkiemmaGIANGVIEN(magv);
        }
        public DataTable TimkiemTENGV(string tengv)
        {
            return gv.TimkiemTENGIANGVIEN(tengv);
        }
        public DataTable LayDSMaGV()
        {
            return gv.LayMaGiangvien();
        }
    }

}
