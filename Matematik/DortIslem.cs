using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)              // Parametreler değişken olanlardır.      Hesap Makinesi için metot oluşturduk

        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }

        public void Cikar(int sayi1, int sayi2) 
        
        {
            int cikartma = sayi1 - sayi2;
            Console.WriteLine("Sonuç : " + cikartma);
        }

        public void Carp(int sayi1, int sayi2)

        {
            int carpma = sayi1 * sayi2;
            Console.WriteLine("Sonuç : " +carpma);
        }

        public void Bol(double sayi1, double sayi2)

        {
            double bolme = sayi1 / sayi2;
            Console.WriteLine("Sonuç : " + bolme);
        }
    }
}
