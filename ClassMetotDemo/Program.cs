using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Merhaba\n");

			Musteri musteri1 = new Musteri();
			musteri1.Id = 1;
			musteri1.Ad = "Burak";
			musteri1.Soyad = "Yağmurca";
			musteri1.Yas = 25;
			musteri1.Cinsiyet = 'E';


			Musteri musteri2 = new Musteri();
			musteri2.Id = 2;
			musteri2.Ad = "Ahmet";
			musteri2.Soyad = "Yağmurca";
			musteri2.Yas = 57;
			musteri2.Cinsiyet = 'E';


			Musteri musteri3 = new Musteri();
			musteri3.Id = 3;
			musteri3.Ad = "Leyla";
			musteri3.Soyad = "Yağmurca";
			musteri3.Yas = 52;
			musteri3.Cinsiyet = 'K';


			Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

			MusteriManager musteriManager = new MusteriManager();


			musteriManager.Add(musteri1);
			musteriManager.Add(musteri2);
			musteriManager.Add(musteri3);

			musteriManager.Listele(musteriler);

			musteriManager.Delete(musteri1);


		}
    }
}
