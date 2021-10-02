using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] {"Halil","Kerem","Murat","Cemal" };
            //Console.WriteLine(names[0]); //Bu şekilde isimleri yazdırabiliriz tek tek. names[4] ü okumaya çalıştıgımızda hata alırız.
            //                             //names[4] = "Gülseren";
            //                             // Console.WriteLine(names[4]); //Bunu yazdıgımızda ise hata alırız. Array sınırların dışında vs.
            //names = new string[5]; //Denediğimizde 5. elemanı okuruz ama diğer elemanlar gitmiş olur. Çünlü new yazdıgımızda yeni bir referans noktası belirledik.
            ////Bu yüzden koleksiyonlar kullanılır.
            /// Ctrl+k + ctrl+c comment yapar. Ctrl+k + Ctrl+u uncomment yapar.

            List<string> names2 = new List<string> {"Engin","Murat", "Kerem","Halil" }; ///Şeklinde listeleri tanımlayabiliriz.
            names2.Add("Ayşe"); //Şeklinde eleman ekleyebiliriz.
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[4]);


        }
    }
}
