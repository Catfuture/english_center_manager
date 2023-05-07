using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QLTT
{
    public class ET_HOCVIEN
    {
        private string mahocvien;
        private string hovatendem;
        private string tenhocvien;
        private string ngaysinh;
        private string phai;
        private string diachi;
        private string nguoidamho;
        private int lienhe;
        private string capdo;
        private string lophoc;

        public string Mahocvien
        {
            get
            {
                return mahocvien;
            }

            set
            {
                mahocvien = value;
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

        public string Tenhocvien
        {
            get
            {
                return tenhocvien;
            }

            set
            {
                tenhocvien = value;
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

        public string Nguoidamho
        {
            get
            {
                return nguoidamho;
            }

            set
            {
                nguoidamho = value;
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

        public string Lophoc
        {
            get
            {
                return lophoc;
            }

            set
            {
                lophoc = value;
            }
        }

        public ET_HOCVIEN(string mahocvien, string hovatendem, string tenhocvien, string ngaysinh, string phai, string diachi, string nguoidamho, int lienhe, string capdo, string lophoc)
        {
            this.mahocvien = mahocvien;
            this.hovatendem = hovatendem;
            this.tenhocvien = tenhocvien;
            this.ngaysinh = ngaysinh;
            this.phai = phai;
            this.diachi = diachi;
            this.nguoidamho = nguoidamho;
            this.lienhe = lienhe;
            this.capdo = capdo;
            this.lophoc = lophoc;
        }
    }
}
