using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamp4
{
    class SepetManager
    {
        ///Manager yazan kısımlarda genelde fonksiyonlar bulunur.
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete eklendi : "+ urun.Adi);
        }
        public void Ekle2(string UrunAdı, string Acıklama, double Fiyat)
        {
            Console.WriteLine("Urun eklendi : "+UrunAdı);
        }
    }
}
