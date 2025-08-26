using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Domain.Entities__Model_
{
    internal class Customer
    {
        int CustomerId { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Address { get; set; }

        public Customer(int customerId, string name, string email, string address)
        {
            CustomerId = customerId;
            Name = name;
            Email = email;
            Address = address;
        }
    }
}
