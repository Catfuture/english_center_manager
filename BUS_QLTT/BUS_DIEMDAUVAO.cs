using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QLTT;
using ET_QLTT;

namespace BUS_QLTT
{
    public class BUS_DIEMDAUVAO
    {
        DAL_DIEMDAUVAO diem = new DAL_DIEMDAUVAO();
        public DataTable LayDS()
        {
            return diem.LayDS();
        }
        public int Them(ET_DIEMDAUVAO et)
        {
            return diem.Them(et);
        }
        public int Xoa(string mahv)
        {
            return diem.Xoa(mahv);
        }
        public int Sua(ET_DIEMDAUVAO et)
        {
            return diem.Sua(et);
        }
        public int ThemHocVienTuDiemDauVao(ET_HOCVIEN et)
        {
            return diem.ThemHocVienTuDiemDauVao(et);
        }
    }
}
