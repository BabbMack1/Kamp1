using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class CustomerManager : ICustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer " + customer.Name + " has added.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer "+ customer.Name+ " has deleted.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer " + customer.Name + " has updated.");
        }
    }
}
