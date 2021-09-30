using System;

namespace Kamp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Metotlar
            ///Class olustururken bas harflerini büyük yaz
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.aciklama = "Amasya elması";

            Product urun2 = new Product { };
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 20;
            urun2.aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] {urun1,urun2 };  //Bu şekilde yapmasaydık arraye ekleyemeyecektik bütün özellikleri //Küçük harfle yaz.
            foreach (var ozellik in urunler)
            {
                
                Console.WriteLine(ozellik.aciklama);
                Console.WriteLine(ozellik.Adi);
                Console.WriteLine(ozellik.Fiyat);
                Console.WriteLine("-------------------");

            }
            Console.WriteLine("---------SEPET MANAGER KISMI-------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            ///Console writeline hızlı yazmak için cw yazıp tab+tab yap.

            //instance-örnek
            Console.WriteLine("------------Diger----------------");
            sepetManager.Ekle2("Armut", "Sarı armut", 15);
            sepetManager.Ekle2("Elma", "Yeşil elma", 16);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuz", 20);
            //Urun kısmındaki fonksiyona daha sonra bir özellik eklememiz gerektiğinde bütün fonksiyonlar patlar. Bu sebepten
            //ötürü class ları kullanmak çok daha mantıklı olur.Diğer türde class parametresini düzeltmek yeterli olur.
            //Buna encapsulation denir.

        }
    }
}
//Do not repeat yourself