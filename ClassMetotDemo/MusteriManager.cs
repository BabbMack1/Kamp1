using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi! = " + musteri.MusteriAdi);
        }

        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi = "+ musteri.MusteriAdi);
        }

        public void MusteriGuncelleme(Musteri musteri) {
            Console.WriteLine("Musteri Güncellendi = "+ musteri.MusteriAdi);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müsteri Adı: "+musteri.MusteriAdi);
            Console.WriteLine("Müsteri Soyadı: "+musteri.MusteriSoyadi);
            Console.WriteLine("Musteri Id: "+musteri.Id);
            Console.WriteLine("Musteri Konumu: "+ musteri.Konumu);
        }
       
    }
}
