using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor constructor = new Constructor { Id=1,FirstName="Mahmut",LastName="Balcı",City="İSTANBUL"};
            //Constructor customer = new Constructor { Id = 2, FirstName = "Ali", LastName = "Veli", City = "Kocaeli" };///Bu şekilde yazmak yerine ctor kısmına tanımlayabiliriz.
            Constructor customer1 = new Constructor ( 2, "Mahmut", "Balcı", "Kastamonu" ); //Aşağıda tanımladığımızda bu şekilde yazılabilir.
            //İkisi de çalışsın istiyorsak eğer aşağıda parametresiz bir ctor daha olustururuz.
            Console.WriteLine(customer1.FirstName);
        }

    }
    class Constructor
    {
        public Constructor()
        {

        }
        public Constructor(int id,string firstname,string lastname, string city)  ////Ctor yazıp çift tab ile hızlıca olusturabiliriz.Class çağırıldıgında bu kısım çalışır.
        {
            FirstName = firstname;
            LastName = lastname;
            City = city;
            Id = id;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
