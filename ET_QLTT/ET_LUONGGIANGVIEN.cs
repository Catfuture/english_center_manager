using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QLTT
{
   public class ET_LUONGGIANGVIEN
    {
        private string magv;
        private string ngaynhanluong;
        private int sogioday;
        private int luong;
        public string Magv
        {
            get
            {
                return magv;
            }

            set
            {
                magv = value;
            }
        }

        public string Ngaynhanluong
        {
            get
            {
                return ngaynhanluong;
            }

            set
            {
                ngaynhanluong = value;
            }
        }

        public int Sogioday
        {
            get
            {
                return sogioday;
            }

            set
            {
                sogioday = value;
            }
        }

        public int Luong
        {
            get
            {
                return luong;
            }

            set
            {
                luong = value;
            }
        }

        public ET_LUONGGIANGVIEN(string magv, string ngaynhanluong, int sogioday, int luong)
        {
            this.Magv = magv;
            this.Ngaynhanluong = ngaynhanluong;
            this.Sogioday = sogioday;
            this.Luong = luong;
        }
    }
}
