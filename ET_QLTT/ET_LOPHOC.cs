using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QLTT
{
    public class ET_LOPHOC
    {
        private string malop;
        private string tenlop;
        private string capdo;
        private string ngaybatdau;
        private string ngayketthuc;
        public string Malop
        {
            get
            {
                return malop;
            }

            set
            {
                malop = value;
            }
        }

        public string Tenlop
        {
            get
            {
                return tenlop;
            }

            set
            {
                tenlop = value;
            }
        }

        public string Capdo
        {
            get
            {
                return capdo;
            }

            set
            {
                capdo = value;
            }
        }

        public string Ngaybatdau
        {
            get
            {
                return ngaybatdau;
            }

            set
            {
                ngaybatdau = value;
            }
        }

        public string Ngayketthuc
        {
            get
            {
                return ngayketthuc;
            }

            set
            {
                ngayketthuc = value;
            }
        }
        public ET_LOPHOC(string malop, string tenlop, string capdo, string ngaybatdau, string ngayketthuc)
        {
            this.malop = malop;
            this.tenlop = tenlop;
            this.capdo = capdo;
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
        }
    }
}
