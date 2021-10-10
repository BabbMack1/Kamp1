using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.Name = "Kemal";
            customer1.LastName = "Ayvan";
            customer1.CustomerNumber = "22412421";
            customer1.IdentityNumber = "12341";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 1;
            customer2.CustomerNumber = "22412421";
            customer2.CompanyName = "Gürsesler";
            customer2.TaxNumber = "231421";

            Customer customer3 = new IndividualCustomer(); /// Bu şekilde 2 class'a ait kişi olusturabiliyoruz.
            Customer customer4 = new CoorporateCustomer(); ///Ebeveyn diğer 2 class'ın da referansını tutabiliyor.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
