using System;

namespace ReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;  //yaptıgımızda person2 nin firstname i de engin olur. Çünkü adreslerini aktarmış oluyoruz.
            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.CreditCardNumber = 123145;
            Employee employee = new Employee();
            //customer=employee yapamayız!! Çünkü farklı tip.
            Person person3 = new Person();
            person3 = customer;  
            person3.FirstName = "Salih"; //Yaptıgımızda customerın first name i de salih olur.
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber); ///Bunu yaptıgımızda person3 e boxing yapmış oluyoruz. person3 customer değişkeni olarak çalışıyor yani
            ///Ve customer'ın creditcardnumberını okumus oluruz.

            //Burada base class yani temel sınıf person'dur. Yani ebeveyn. Base class'ı inherit eden sınıfları birbirine atayabilirsin.
        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
        class Customer:Person           //Bu şekilde yazarak Persondaki bütün özellikleri customer'a da verdik. Customerda ek olarak creditcardnumber var
        {
            public int CreditCardNumber { get; set; }

        }
        class Employee:Customer
        {
            public int EmployeeNumber { get; set; }
        }
    }
}
