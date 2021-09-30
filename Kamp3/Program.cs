using System;

namespace Kamp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class Giriş
            Kurs kurs1 = new Kurs(); //Kurs Tanımlama
            kurs1.KursAdi = "C#";
            kurs1.Egitim = "EnginDemirog";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs(); //Kurs Tanımlama
            kurs2.KursAdi = "Java";
            kurs2.Egitim = "Kerem";
            kurs2.IzlenmeOranı = 64;

            Kurs kurs3 = new Kurs(); //Kurs Tanımlama
            kurs3.KursAdi = "Python";
            kurs3.Egitim = "Berkay";
            kurs3.IzlenmeOranı = 80;

            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitim);

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; } // Prop yazarak 2 kere taba basınca direkt ekliyor.
        public string Egitim { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
