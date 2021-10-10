using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService   //Class adına bir kere tıklayıp ampulden move type to .. yazısına tıkladıgımızda otomatik olarak solution kısmına ekliyor.
    {
        public void log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
    
}
