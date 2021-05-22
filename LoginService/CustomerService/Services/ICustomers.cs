using CustomerService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Services
{
    public interface ICustomers
    {
        IEnumerable<Customer> GetCustomers();
    }

}
