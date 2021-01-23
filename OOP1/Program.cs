using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";                        // Bu ve aşağıdaki yöntemle de ürün girişi 2 farklı şekilde de manuel giriş gibi yapılabilir.
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };



            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();                  // Eşitliğin sol tarafı STACK sağ tarafı HEAP
            productManager.Add(product1);

            //  Console.WriteLine(product1.ProductName);    // CEVAP KAMERA - REFERANS TİP


          //   productManager.Topla2(3,6);              // void çıktısı için


          //   int toplamSonucu = productManager.Topla(3, 6);          // return çıktısı için
          //   Console.WriteLine(toplamSonucu * 2);




          //  int sayi = 100;
          //  productManager.BiseyYap(sayi);
          //  Console.WriteLine(sayi);       // CEVAP 100 - DEĞER TİP

        }

    }
}
