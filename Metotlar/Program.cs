using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 8;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Çilek";
            urun2.Fiyati = 12;
            urun2.Aciklama = "Dağ Çileği";                                                         // Class lar özellik tutar

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)                                            // Urun tipi yerine var da yazılabilir.    urunler dizisinin tüm elemanlarını tek tek dolaşır. urun alias. Urun class
            {
                Console.WriteLine(urun.Id + " - " + urun.Adi + " - " + urun.Fiyati + " TL - " + urun.Aciklama);                          // cw yazıp çift tab yapınca Console.WriteLine(); yazar
            }

            Console.WriteLine("---------Metotlar---------");

            SepetManager sepetManager = new SepetManager();               // instance - class örneği oluşturma yaptık       // encapsulation
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

        }
    }
}
