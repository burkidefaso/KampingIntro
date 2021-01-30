using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate -- Tüzel
    //Miras -- inheritance
    class TuzelMusteri:Musteri                    // TuzelMusteri ye sen bir Musteri sin diyoruz burada. TuzelMusteri bir Musteri dir
    {
        public string SirketAdi { get; set; }          
        public string VergiNo { get; set; }                // Müşteri numarası, tc no, vergi no neden string tutulur? Çünkü matematiksel işlem yapmayacağız. Long tutmamıza gerek yok 
    }
}
