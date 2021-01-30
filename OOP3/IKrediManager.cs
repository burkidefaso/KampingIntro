using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager                        //class ı interface yaptık ve void altındaki süslü parantezleri kaldırdık ve public takısını da kaldırdık ve void Hesapla() nın sonuna ; koyduk. Çünkü 3 kredi türünün de kendine göre hesaplama bilgileri farklı. void hesapla() imza kısmı. Interface bir şablon görevi görüyor. Yani bir interface alttaki kurallara şablona uymak zorunda demek
    {                                              // KrediManager ın başına genelde I konur. Interface olduğu anlaşılsın diye. IKrediManager bir interface ve alttaki kuralları içerir. İlgili onu implemenete eden class lar kendine göre içini doldurur kodlarını istediği gibi düzenler. Interface genelde operasyonel metotlarda kullanılır.
        void Hesapla();                            // Interface leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız
        void BiseyYap();                           //  Interface lerin başına I sonuna Service yazılır
    }
}
