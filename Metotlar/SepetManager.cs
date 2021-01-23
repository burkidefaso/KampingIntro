using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)            // metot syntax'ı bu şekilde. Metot ve fonksiyon aynı şey. Metotun içine yazdığımız şey class(tip) ve nesne(alias gibi) (Urun urun) -- Parametre kısmı
        
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);               // Yukardaki metotun yapacağı iş bu blok içine yazılır. Metotun şablonunu bu projede oluşturuyoruz
        }

                                 // Buraya tekrar public void yapıp yeni bir metot oluşturabiliriz


    }
}
