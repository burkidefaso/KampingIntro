using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);                                                  // İstediğin alanı seçip ctrl - k - c yapınca command line - yorum satırı yapar topluca. ctrl-k-u da geri alır
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];                 // Yukarıdaki diziyi yok sayıp yeni bir adreste 6 elemenlı dizi oluşturuyor. (Heap'te) 4. elemanını İlker olarak atıyor ama diğer elemanları atamıyor
            //isimler[4] = "İlker";                                                      // Bu yüzden derleyici 0 ve 1. elemanları boşluk olarak yazdırıyor.
            //Console.WriteLine(isimler[4]);       
            //Console.WriteLine(isimler[0]);                                 // Gerçek hayatta array'ler kullanılmaz. Koleksiyonlar kullanılır daha çok
            //Console.WriteLine(isimler[1]);                                 // Array lerde sabitlik var. Mesela 4 elemanlı bir dizi tanımladınız onu 5 elemanlıya dönüştüremezsiniz.He yaparsınız yandaki gibi ama eski elemanları kaybedersiniz
            // new dediğin anda heap te yeni bir adres oluşur. Yani new demek yeni referans adresi demek. Yanda yeni bir adreste yeni bir dizi oluşturuyor ama elemanları yok
            // Değer tipler sadece Stack i kullanır. Referans tipler hem Stack i hem Heap i kullanır



            List<string> isimler3 = new List<string>();
            isimler3.Add("Engin");                                                                                           // List i kullanabilmek için List yazıp solundaki ampule basıp system.collections.generic i seçmen gerek


            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };                                 // List kullanımı yandaki 2 şekildeki gibi de olur.

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");                                                         // List eleman sayısını bir arttırdı ve ilker elemanını 5. eleman olara atadı. Diğer elemanlar da aynı şekilde kaldı
            Console.WriteLine(isimler2[4]);                                                // Dizilerde bunu yapamıyorsun. O yüzden List kullanılır ( COLLECTIONS )
            Console.WriteLine(isimler2[0]);
        }
    }
}
