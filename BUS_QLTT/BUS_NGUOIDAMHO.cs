using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QLTT;
using ET_QLTT;
namespace BUS_QLTT
{
    public class BUS_NGUOIDAMHO
    {
        DAL_NGUOIDAMHO ndh = new DAL_NGUOIDAMHO();
        public DataTable LayDS()
        {
            return ndh.LayDSNguoidamho();
        }
        public int Them(ET_NGUOIDAMHO et)
        {
            return ndh.Them(et);
        }
        public int Xoa(string malop)
        {
            return ndh.Xoa(malop);
        }
        public int Sua(ET_NGUOIDAMHO et)
        {
            return ndh.Sua(et);
        }
    }
}
