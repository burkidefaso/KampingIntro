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
            // sayilar1[0] ??      Cevap 999                          İLK ÖRNEK:           STACK               HEAP
        }                                                 //                              sayi1=10            
    }                                                     //                              sayi2=30
                                               
}                                                         //                      yeni    sayi1=30
                                                          //                      yeni    sayi2=65



// Değer tipinde olanlar Stack de tutulur. Referans tipinde olanlar referans no ile heap de tutulur. Değer tiplerde sadece değeri aktarırsın kopyalarsın. sayi1 in sayi2 ile olan irtibatı o an kopar yani bir
// sonraki işlemler onu etkilemez


//                   İKİNCİ ÖRNEK:                               STACK                                   HEAP        
//                                      Adres veya Ref no 101 / sayilar1  ------------>  Ref no 101 / [10,20,30] ---> Bu adres ile işimiz kalmadı artık. Garbage collector gelip 101 adresini bellekten atacak
//                                      Adres veya Ref no 102 / sayilar2  ------------>  Adres 102  / [100,200,300]      Artık sayilar1 de 102 de ve [100,200,300]

//                                                                                        Ama sayilar[0] = 999 dediğim için sayilar2 ve artık aynı zamanda sayilar1 in ilk değeri 999 olur. [999,200,300]


//                                   sayilar1 = sayilar2  demek sayilar2 nin adresini(ref nosunu) sayilar1 e ata demek. Yani referans tip olduğundan adres kopyalaması yapar. Yani sayilar1 i 102 de tutulacak



// Referans no heap de bir adres değeridir. Yani sayilar1 bellekte 101 nolu adreste tutuluyor. new --> heap te yani bellekte bir yer,adres oluştur demek


// Class lar 2 şekilde kullanılabilir.  1)  Özellikler belirtmek için    2) Operasyon yani metot tanımlamak için