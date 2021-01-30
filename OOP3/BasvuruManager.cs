using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) 
        {
            // Başvuran bilgilerini değerlendirme
            

            //KonutKrediManager konutKrediManager = new KonutKrediManager();            // Bu şekilde yaparsak konut kredisine bağımlı oluruz ama public void BasvuruYap(IKrediManager krediManager) yaptığımız için ve (IKrediManager krediManager) da 3 kredinin de referans numarasını tuttuğu için bunu yazar ve 3 krediye erişiriz
            //konutKrediManager.Hesapla();  

            krediManager.Hesapla();         // Burada sadece 1 kredi hesapladı
            //loggerService.Log();            // Hangi loglayıcı servis(database,file) seçildiyse onu logla diyoruz   ---   public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) durumunda bu ikili olurdu. Yani tek bir loglama yapar bu tanım

            foreach (var loggerService in loggerServices)                       // Bunu yaparak birden çok loglamayı tek bir operasyonda yapıcaz. Listedeki tüm log servicelerini dolaşır. Yukarda List olduğunu belirttik
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach(var kredi in krediler)              // Listedeki her bir krediyi hesaplamak için foreach kullandık. Tabi şubenin seçimine göre hesaplar. 1 kredi girerse 1, 3 girerse 3 ünü de ayrı ayrı hesaplar. Biz mesela ihtiyaç ve taşıt girdik
            {
                kredi.Hesapla();
            }
        }
    }
}
