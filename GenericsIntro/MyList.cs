using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T> ///Bu şekilde tanımlayabiliriz. Bunu yaptıgımızda hangi türde kullanmak istiyorsa o girilecek
    {
        T[] items; ///Verileri tutmak için bir dizi oluşturduk.
        //Constructor. ctor yazıp 2 kere tab basman yeterli.
        //Class ı newlediğimizde constructor otomatik çalışır.
        public MyList()
        {
            items = new T[0]; //Newlediğimiz anda array sıfırlandı.
        }
        public void Add(T item)
        {
            T[] tempArray = items; //Newlediğimizde içindeki elemanlar gideceği için önce geçici arraye referans noktasını aktardık.
            items = new T[items.Length + 1];  //Her ekleme fonksiyonunda dizinin eleman sayısını 1 arttırdık.
            for (int i = 0; i < tempArray.Length; i++)//Elemanları yeni arraye ekledik.
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;// En son verilen elemanı ekledik.
        }
    }
}
