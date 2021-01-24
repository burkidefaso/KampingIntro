using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Add(Musteri musteri) 
        {
            Console.WriteLine("{0} İsimli Musteri Eklendi", musteri.Ad);
        }

        public void Delete(Musteri musteri) 
        {
            Console.WriteLine("{0} İsimli Musteri Silindi", musteri.Ad);
        }


        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Id: " + musteri.Id + " " + "Ad: " + musteri.Ad + " " + "Soyad: " + musteri.Soyad + " " + "Yas: " + musteri.Yas + " " + "Cinsiyet: " + musteri.Cinsiyet);
            }
        }

    }
}
