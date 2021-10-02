using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList<string> names = new MyList<string>(); //List de bu şekildedir. Tür girmek zorundayız.
            names.Add("Deneme"); ///Fonksiyon string girdi istiyor.
        }
    }
}
