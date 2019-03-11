using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ListelerinEfendisi = new ArrayList();
            /* ArrayList kullanım örneği:
             * 
            ListelerinEfendisi.Add(35);
            ListelerinEfendisi.Add("deneme");
            ListelerinEfendisi.RemoveAt(1);  //indise göre silme
            ListelerinEfendisi.Remove(35);
            */

            Yazdir(ListelerinEfendisi);
            Temizle(ListelerinEfendisi);
        }

       static void Yazdir(ArrayList diziListesi)
        {
            /*
             * Dizi listesinde Sekil olan her bir öğenin alan ve cevresini hesapla ve konsola yazdir. Örneğin;
             * Ucgen Alan: ** Cevre: **
             * Daire Alan:** Cevre:**
             * Dikdorgen Alan:** Cevre:**
             * Formatında...
             * İPUCU:
                if (obj is int) {
                     Console.WriteLine("Yuppi it is int!!!!");
                } else {
                    Console.WriteLine("not an int");
                 }
             */
        }

        static void Temizle(ArrayList diziListesi)
        {
            /*
             * Dizi listesinde Sekil olmayan öğeleri listeden çıkar.
             */
        }
    }
}
