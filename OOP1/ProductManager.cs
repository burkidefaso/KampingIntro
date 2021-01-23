using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{                                            // CRUD OPERASYONLARI - CREATE-READ-UPDATE-DELETE
    class ProductManager                     // METOTLARIN CLASS ADI SONU SERVİCE VEYA MANAGER İLE BİTER. ÜRÜNLE İLGİLİ OPERASYONLAR BURADA DEMEK. METOT-FONKSİYON-OPERASYON AYNI ŞEY
    {
        public void Add(Product product) 
        {
            //  product.ProductName = "Kamera";

            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

      //  public int Topla(int sayi1, int sayi2)                           // void yerine return kullanırsak sonucu bir değişkene atayıp başka yerlerde de kullanabiliriz, hafızada tutmuş olur. Return kullanılır genelde
      //  {
      //      return sayi1 + sayi2;
      //  }

      //  public void Topla2(int sayi1, int sayi2)                       // void emir verir işlemi yapar ve bitirir, başka bir şey istemez ondan. Hafızada tutmaz.
      //  {
      //      Console.WriteLine(sayi1 + sayi2);
      //  }



        //*  public void BiseyYap(int sayi) 
        //  {
        //      sayi = 99;
        //  }


    }
}
