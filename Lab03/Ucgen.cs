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
        public Dikucgen(int x, int y) : base(x, y)
        {
            //Eğer eklediğiniz ek özellikleri yaratıcı metota başlatmak isterseniz yaratıcı metotu günceleyebilirsiniz.
        }

        /*
         * Abstarct metotlar burada implemente edilmeli.
         */
        public override double AlanHesapla()
        {
            return 0.0;
        }

        public override double CevreHesapla()
        {
            return 0.0;
        }
    }
}
