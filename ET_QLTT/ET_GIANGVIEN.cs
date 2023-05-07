using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QLTT
{
    public class ET_GIANGVIEN
    {
        private string magiangvien;
        private string hovatendem;
        private string tengiangvien;
        private string ngaysinh;
        private string phai;
        private string diachi;
        private int lienhe;
        private int luongcoban;

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

        public string Hovatendem
        {
            get
            {
                return hovatendem;
            }

            set
            {
                hovatendem = value;
            }
        }

        public string Tengiangvien
        {
            get
            {
                return tengiangvien;
            }

            set
            {
                tengiangvien = value;
            }
        }

        public string Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Phai
        {
            get
            {
                return phai;
            }

            set
            {
                phai = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public int Lienhe
        {
            get
            {
                return lienhe;
            }

            set
            {
                lienhe = value;
            }
        }

        public int Luongcoban
        {
            get
            {
                return luongcoban;
            }

            set
            {
                luongcoban = value;
            }
        }

        public ET_GIANGVIEN(string magiangvien, string hovatendem, string tengiangvien, string ngaysinh, string phai, string diachi, int lienhe, int luongcoban)
        {
            this.Magiangvien = magiangvien;
            this.Hovatendem = hovatendem;
            this.Tengiangvien = tengiangvien;
            this.Ngaysinh = ngaysinh;
            this.Phai = phai;
            this.Diachi = diachi;
            this.Lienhe = lienhe;
            this.Luongcoban = luongcoban;
        }
    }
}
