using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;                                                        // int, decimal, float, double, bool -------> Değer Tip  --  Sayısal değerdekiler yani.  Ayrıca bool 0 ve 1 'i tutar   
            int sayi2 = 30;                                                                     
            sayi1 = sayi2;                                                         // array, class, interface ---------> Referans Tip
            sayi2 = 65;
            // sayi1 ??      Cevap 30


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar1[0] ??      Cevap 999
        }                                                                                         
    }
}
