using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QLTT;
using ET_QLTT;

namespace BUS_QLTT
{
    public class BUS_LICHHOC
    {
        DAL_LICHHOC lichhoc = new DAL_LICHHOC();
        public DataTable LayDS(int tuan)
        {
            return lichhoc.LayDSLichhoc(tuan);
        }
        public int Them(ET_LỊCHHOC et)
        {
            return lichhoc.Them(et);
        }
        public int Xoa(string malop)
        {
            return lichhoc.Xoa(malop);
        }
        public int Sua(ET_LỊCHHOC et)
        {
            return lichhoc.Sua(et);
        }
    }
}
