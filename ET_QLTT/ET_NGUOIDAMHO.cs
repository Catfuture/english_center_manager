using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QLTT
{
    public class ET_NGUOIDAMHO
    {
        private string manguoidamho;
        private string hovaten;
        private string quanhe;
        private int lienhe;

        public string Manguoidamho
        {
            get
            {
                return manguoidamho;
            }

            set
            {
                manguoidamho = value;
            }
        }

        public string Hovaten
        {
            get
            {
                return hovaten;
            }

            set
            {
                hovaten = value;
            }
        }

        public string Quanhe
        {
            get
            {
                return quanhe;
            }

            set
            {
                quanhe = value;
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

        public ET_NGUOIDAMHO(string manguoidamho, string hovaten, string quanhe, int lienhe)
        {
            this.Manguoidamho = manguoidamho;
            this.Hovaten = hovaten;
            this.Quanhe = quanhe;
            this.Lienhe = lienhe;
        }
    }
}
