using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class MyList<T>  //Burada hangi tip verirsek onunla çalışsın diye T verdik.
    {
        public void Add(T item)
        {
            //Burada T olarak tanımladıgımızda hangi tür verirsek verelim çalışır durumda olacak.
        }
    }
}
