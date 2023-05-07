using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QLTT
{
    public class ET_DIEMDAUVAO
    {
        private string mahocvien;
        private string hovatendem;
        private string tenhocvien;
        private string ngaysinh;
        private string phai;
        private string diachi;
        private int lienhe;
        private int diem;

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

        public int Diem
        {
            get
            {
                return diem;
            }

            set
            {
                diem = value;
            }
        }

        public ET_DIEMDAUVAO(string mahocvien, string hovatendem, string tenhocvien, string ngaysinh, string phai, string diachi, int lienhe, int diem)
        {
            this.Mahocvien = mahocvien;
            this.Hovatendem = hovatendem;
            this.Tenhocvien = tenhocvien;
            this.Ngaysinh = ngaysinh;
            this.Phai = phai;
            this.Diachi = diachi;
            this.Lienhe = lienhe;
            this.Diem = diem;
        }
    }
}
