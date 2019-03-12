using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03
{
    class Dikdortgen : Sekil
    {
        /* 
         * Bu şekle özel başka özellikler varsa onlarıda implemente ediniz.
         */
        private double yukseklik;
        private double genislik;
        public Dikdortgen(int x, int y, double yuk, double gen) : base(x, y)
        {
            //Eğer eklediğiniz ek özellikleri yaratıcı metota başlatmak isterseniz yaratıcı metotu günceleyebilirsiniz.
            base.X = x;
            base.Y = y;
            yukseklik = yuk;
            genislik = gen;
        }
        /*
         * Abstarct metotlar burada implemente edilmeli.
         */
        public override double AlanHesapla()
        {
            return (yukseklik*genislik);
        }

        public override double CevreHesapla()
        {
            return ((2 * yukseklik) + (2 * genislik));
        }
    }
}
