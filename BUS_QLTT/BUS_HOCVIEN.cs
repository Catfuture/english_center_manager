using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QLTT;
using ET_QLTT;

namespace BUS_QLTT
{
    public class BUS_HOCVIEN
    {
        DAL_HOCVIEN hv = new DAL_HOCVIEN();
        public DataTable LayDS()
        {
            return hv.LayDSHocvien();
        }
        public int Them(ET_HOCVIEN et)
        {
            return hv.Them(et);
        }
        public int Xoa(string mahv)
        {
            return hv.Xoa(mahv);
        }
        public int Sua(ET_HOCVIEN et)
        {
            return hv.Sua(et);
        }
        public int Sualop(string mahv,string lop)
        {
            return hv.Sualop(mahv,lop);
        }
        public DataTable TimkiemMaHV(string mahv)
        {
            return hv.TimkiemmaHOCVIEN(mahv);
        }
        public DataTable TimkiemTENHV(string tenhv)
        {
            return hv.TimkiemtenHOCVIEN(tenhv);
        }
        public DataTable TimkiemlopHOCVIEN(string lop)
        {
            return hv.TimkiemlopHOCVIEN(lop);
        }
        public DataTable TimkiemCapHOCVIEN(string cap)
        {
            return hv.TimkiemcapHOCVIEN(cap);
        }
        public DataSet thongKeHocPhiTheoLop()
        {
            return hv.ThongKeHocPhiTheoLop();
        }
    }
}
