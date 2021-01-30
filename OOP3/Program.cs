using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();                         // Biz instance oluştururken IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();    yerine   IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();   yazabilirdik. Ve diğer 2 kredi içinde de aynısını yazabilirdik. Sonuç değişmezdi. Çünkü inheritance da olduğu gibi interface ler de o interface i implemente eden class ın referans numarasını tutabiliyor
              //ihtiyacKrediManager.Hesapla();
            IKrediManager tasitKrediManager = new TasitKrediManager();
              //tasitKrediManager.Hesapla();                                    // (1)
            IKrediManager konutKrediManager = new KonutKrediManager();                        // Bu 3 ü şube ekranındaki açılır kutu
                                                                                              //konutKrediManager.Hesapla();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { databaseLoggerService, fileLoggerService };


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, loggers);                             //  (4)             // basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLoggerService);   tekil hali durumu
            //basvuruManager.BasvuruYap(tasitKrediManager,fileLoggerService);                    //  (2)
            //basvuruManager.BasvuruYap(konutKrediManager,databaseLoggerService);                                  // Şubenin seçimine göre hesaplama yapar. İçine parametre girmek şart bu kısımda


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
          
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);                 // (3)
        
        }
    }
}
