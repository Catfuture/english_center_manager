using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QLTT;
using ET_QLTT;

namespace BUS_QLTT
{
    public class BUS_LOPHOC
    {
        DAL_LOPHOC lophoc = new DAL_LOPHOC();
        public DataTable LayDS()
        {
            return lophoc.LayDSLophoc();
        }
        public int Them(ET_LOPHOC et)
        {
            return lophoc.Them(et);
        }
        public int Xoa(string malop)
        {
            return lophoc.Xoa(malop);
        }
        public int Sua(ET_LOPHOC et)
        {
            return lophoc.Sua(et);
        }
        public DataTable LayDSMaLop()
        {
            return lophoc.LayDSMaLop();
        }
    }
}
