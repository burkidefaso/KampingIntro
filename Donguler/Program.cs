using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args) 
        
        {

            string kurs1 = "Yazılım K1";
            string kurs2 = "Yazılım K2";
            string kurs3 = "Yazılım K3";
            string kurs4 = "Yazılım K4";


            Console.WriteLine(kurs1);   
            Console.WriteLine(kurs2);                     // WriteLine yazdıktan sonra bir alt satıra geçer. Write alta geçmez aynı satırda boşluksuz devam eder
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            String[] kurslar = new string[] { "Yazılım K1", "Yazılım K2", "Yazılım K3", "Yazılım K4" };

        
            for (int i=1; i<10; i++)       // i++ yerine  i=i+1 yazabilirsin. 2 arttırmak için i=i+2 yazabilirsin veya i+=2
            
            {
                Console.WriteLine(i);      
            }
       
            for ( int i=0; i<kurslar.Length; i++)        // kurslar.length ---- Dinamik yapı için. Kursların eleman sayısı demek
            
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach ( string kurs in kurslar)            // foreach bir tek dizilere uygulanabilir. For ile aynı mantık yazılışı kolay diziler için. Kursları dolaş anlamına gelir. Oradaki kurs alias aslında

            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu - Footer");
        
        
        }
    }
}
