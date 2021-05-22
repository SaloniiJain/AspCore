using CustomerService.Data;
using CustomerService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Services
{
    public class Customers : ICustomers
    {
        private readonly CustomerContext _dbContext;

        public Customers(CustomerContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable <Customer> GetCustomers()
        {
            return _dbContext.customers.ToList();
        }
    }
}
