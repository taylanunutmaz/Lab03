using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03
{
    class Dikucgen : Sekil
    {
        /* 
         * Bu şekle özel başka özellikler varsa onlarıda implemente ediniz.
         */
        double yukseklik;
        double taban;
        public Dikucgen(int x, int y, double yuk, double tab) : base(x, y)
        {
            //Eğer eklediğiniz ek özellikleri yaratıcı metota başlatmak isterseniz yaratıcı metotu günceleyebilirsiniz.
            base.X = x;
            base.Y = y;
            yukseklik = yuk;
            taban = tab;
        }

        /*
         * Abstarct metotlar burada implemente edilmeli.
         */
        public override double AlanHesapla()
        {
            return (taban*yukseklik/2.0);
        }

        public override double CevreHesapla()
        {
            return (taban + yukseklik + Math.Sqrt(Math.Pow(taban, 2) + Math.Pow(yukseklik, 2)));
        }
    }
}
