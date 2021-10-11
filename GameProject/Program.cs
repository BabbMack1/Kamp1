using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Name = "Ali", Surname = "Cambaz", CitizenshipNumber = "112341234",DateOfBirth=new DateTime(1999,02,20) };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);

            Customer customer2 = new Customer() { Name = "Selin", Surname = "Karıl", CitizenshipNumber = "6565465434", DateOfBirth = new DateTime(1992, 06, 14) };
            customerManager.Delete(customer2);


            CampaignManager campaignManager = new CampaignManager();
            SalesManager salesManager = new SalesManager();
            salesManager.Selling(customer, new Campaign {CampaignName="Christmas"});

            campaignManager.UpdateCampaign(new Campaign {CampaignName="Black Friday" });


        }
    }
}
