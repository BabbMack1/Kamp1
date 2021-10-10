using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class IndividualCustomer:Customer   ///Customer'daki bütün özellikler individual ve coorporate de de vardır. Customer ebeveyndir.
    {
       
        public string Name { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
    }
}
