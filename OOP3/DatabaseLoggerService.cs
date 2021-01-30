using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService           // DatabaseLoggerService e sen aslında IloggerService alternatifisin diyoruz burada. Amacımız Loglamayı veritabanına yapmak burada
    {
        public void Log()                                  // Interface içinde sadece imza metotları olur, içi dolu olamaz
        {
            Console.WriteLine("Veritabanına Loglandı");                                
        }
    }
}
