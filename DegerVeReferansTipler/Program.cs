using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı1 = 10;
            int sayı2 = 30;
            sayı1 = sayı2;
            sayı2 = 65;
            //Burada sayı1 30 olur.

            int[] sayılar = new int[] {10,20,30 };
            int[] sayılar2 = new int[] {100,200,300 };
            sayılar = sayılar2;
            sayılar2[0] = 999;
            //Burada ise sayılar[0] yazdırırsak 999 olacaktır.
            //int,decimal,double,float,bool== değer tip
            //array,class,interface== referans tiptir.
            //sayı1=sayı2 yaptığımızda burada sayı1 in değeri sayı2 nin değerine eşitlenir. ve işlem biter.
            //sayılar arrayi olusturdugumuzda new yazdıgımızda heap te yeni bir alan olusturulur ve bir adresi olmus olur.
            //sayılar 1 in bellekteki karşılığı olmus olur.Yani new yazdıgımızda bellekte yeni adres olusturmus oluyoru.
            //sayılar=sayılar2 yaptığımızda referans numaraları eşitlenir. Böylece bellekteki karşılığı değişmiş olur.
            //sayılar 2 nin bellekteki adresine atanmış olur. sayılar2 yi değiştirdiğimizde adresteki veri değiştiğinden
            //sayılar da değişmiş olur.Sayıların ilk adresini tutan olmadıgı için bellekten atılır.
        }
    }
}
