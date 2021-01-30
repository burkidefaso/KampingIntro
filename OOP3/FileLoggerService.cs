using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService               // Amacımız Loglamayı dosyaya yapmak burada
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");         
        }
    }
}
