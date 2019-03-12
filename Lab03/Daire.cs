using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03
{
    class Daire: Sekil
    {
        /* 
         * Bu şekle özel başka özellikler varsa onlarıda implemente ediniz.
         */
        private double yaricap;
            
        public Daire(int x, int y, double y_cap) : base(x, y)
        {
            //Eğer eklediğiniz ek özellikleri yaratıcı metota başlatmak isterseniz yaratıcı metotu günceleyebilirsiniz.
            base.X = x;
            base.Y = y;
            yaricap = y_cap;
        }
        /*
         * Abstarct metotlar burada implemente edilmeli.
         */
        public override double AlanHesapla()
        {
            return (Math.PI * yaricap * yaricap);
        }
        public override double CevreHesapla()
        {
            return (2 * Math.PI * yaricap);
        }

    }
}
