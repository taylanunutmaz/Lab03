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
            
            ListelerinEfendisi.Add(new Dikucgen(0, 0, 10, 12));
            ListelerinEfendisi.Add(new Object());
            ListelerinEfendisi.Add(new Daire(0, 0, 10));
            ListelerinEfendisi.Add("Taylan");
            ListelerinEfendisi.Add(21928);
            ListelerinEfendisi.Add(new Dikdortgen(0, 0, 10, 13));
            ListelerinEfendisi.Add(new ArrayList());

            Yazdir(ListelerinEfendisi);
            Console.WriteLine();
            Temizle(ListelerinEfendisi);
            Console.WriteLine();
            Yazdir(ListelerinEfendisi);
            Console.ReadKey();
        }

        static void Yazdir(ArrayList diziListesi)
        {
            for (int i = 0; i < diziListesi.Count; i++)
            {
                if(diziListesi[i] is Daire)
                {
                    Console.WriteLine($"Daire alani: {((Daire)diziListesi[i]).AlanHesapla()}, " +
                        $"Cevresi: {((Daire)diziListesi[i]).CevreHesapla()}");
                }
                else if (diziListesi[i] is Dikdortgen)
                {
                    Console.WriteLine($"Dikdortgen alani: {((Dikdortgen)diziListesi[i]).AlanHesapla()}, " +
                        $"Cevresi: {((Dikdortgen)diziListesi[i]).CevreHesapla()}");
                }
                else if (diziListesi[i] is Dikucgen)
                {
                    Console.WriteLine($"Dikucgen alani: {((Dikucgen)diziListesi[i]).AlanHesapla()}, " +
                        $"Cevresi: {((Dikucgen)diziListesi[i]).CevreHesapla()}");
                }
                else
                {
                    Console.WriteLine($"{diziListesi[i]} Sekil Degil!");
                }

        
            }
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
            for (int i = 0; i < diziListesi.Count; i++)
            {
                if (!(diziListesi[i] is Sekil))
                {
                    Console.WriteLine($"Silinen: {diziListesi[i]}");
                    diziListesi.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
