using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QLTT
{
    public class ET_LỊCHHOC
    {
        private string malop;
        private string magiangvien;
        private string lichhoc;
        private string phong;
        private int tuan;

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

        public string Magiangvien
        {
            get
            {
                return magiangvien;
            }

            set
            {
                magiangvien = value;
            }
        }

        public string Lichhoc
        {
            get
            {
                return lichhoc;
            }

            set
            {
                lichhoc = value;
            }
        }

        public string Phong
        {
            get
            {
                return phong;
            }

            set
            {
                phong = value;
            }
        }

        public int Tuan
        {
            get
            {
                return tuan;
            }

            set
            {
                tuan = value;
            }
        }
        public ET_LỊCHHOC(string malop, string magiangvien, string lichhoc, string phong, int tuan)
        {
            this.malop = malop;
            this.magiangvien = magiangvien;
            this.lichhoc = lichhoc;
            this.phong = phong;
            this.tuan = tuan;
        }
    }
}
