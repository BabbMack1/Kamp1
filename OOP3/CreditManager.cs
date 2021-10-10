using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface ICreditManager  ///Burada CreditManager class'ı tek başına bir işe yaramıyor. Bütün hesaplar diğer class'larda yapılıyor. Bu yüzden bu classı interface olarak olustururuz.
        //Okunurluğun artması için interface'ler I harfi ile başlar.
    {
        void Calculate();
        void BirSeyYap();
    }
}
