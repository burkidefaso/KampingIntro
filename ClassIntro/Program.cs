using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "Burak";
            int yas = 25;

            Kurs kurs1 = new Kurs();                            // Aşağıda Kurs diye class oluşturduk. Kurs classının özelliklerini belirttik. Burada da Kurs tipinde bir kurs1 değişkeni oluşturduk
            kurs1.KursAdi = "C#";                                                     // Kurs bir veri tipi aslında                                                               // ve değerlerini atadık
            kurs1.Egitmen = "Burak Yağmurca";
            kurs1.IzlenmeOrani = 23;


            Kurs kurs2 = new Kurs();                            
            kurs2.KursAdi = "Python";                                                                                                                                         
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 84;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "SQL";
            kurs3.Egitmen = "Can Günaydın";
            kurs3.IzlenmeOrani = 64;


            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)                                     // foreach (Kurs kurs in kurslar)      Kurs yerine tip ( class ) olarak var da yazılabilir. Aynı şey    kurs alias
            {
                Console.WriteLine(kurs.KursAdi + " - " + kurs.Egitmen + " - %" + kurs.IzlenmeOrani);                                // kurs alias
            }   
        }
        
    }

  
    class Kurs
    {
        public string KursAdi { get; set; }                              // Bu kodu yazmak için prop yazıp çift tab yaptık. Sonra düzenledik. prop tab tab
        public string Egitmen { get; set; }                             // Class bir nesneye ait tüm bilgileri tutmak için oluşturulur
        public int IzlenmeOrani { get; set; }
    }


}

