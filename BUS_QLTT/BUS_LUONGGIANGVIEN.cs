using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QLTT;
using ET_QLTT;

namespace BUS_QLTT
{
    public class BUS_LUONGGIANGVIEN
    {
        DAL_LUONGGIANGVIEN gv = new DAL_LUONGGIANGVIEN();
        public DataTable LayDS(DateTime ngay)
        {
            return gv.LayDSLuong(ngay);
        }
        public int Them(ET_LUONGGIANGVIEN et)
        {
            return gv.Them(et);
        }
        public int Xoa(string magv, DateTime ngay)
        {
            return gv.Xoa(magv,ngay);
        }
        public int Sua(ET_LUONGGIANGVIEN et)
        {
            return gv.Sua(et);
        }
    }
}
