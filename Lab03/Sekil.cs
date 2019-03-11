using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03
{
    abstract class Sekil
    {
        private int x;
        private int y;

        public Sekil(int x,int y)
        {
            X = x;
            Y = y;
        }

        public int X { get{ return x;}  set{ x = value; } }
        public int Y { get{ return y;}  set{ y = value; } }


        public abstract double AlanHesapla();
        public abstract double CevreHesapla();
    }
}
