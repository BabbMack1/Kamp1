using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Ahmet";
            musteri1.MusteriSoyadi = "Kunduracı";
            musteri1.Konumu = "Malatya";
            musteri1.Id = 11111;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Melek";
            musteri2.MusteriSoyadi = "Sayman";
            musteri2.Konumu = "Rize";
            musteri2.Id = 22222;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Melek";
            musteri3.MusteriSoyadi = "Sayman";
            musteri3.Konumu = "Rize";
            musteri3.Id = 22222;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriGuncelleme(musteri2);
            musteriManager.MusteriSilme(musteri3);
            musteriManager.Listele(musteri1);
        }
    }
}
