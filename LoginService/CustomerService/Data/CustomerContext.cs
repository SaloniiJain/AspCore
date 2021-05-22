using CustomerService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }

        public DbSet<Customer> customers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer>().HasData(
          new Customer
          {
              ID = 1,
              FullName = "Saloni",
              ContactNo = "9090909090",
              Email = "saloni@gmail.com",
              Gender = "Female",
              Birthdate = "20-01-1990",
              City = "Ahemdabad"
          },
          new Customer
          {
              ID = 2,
              FullName = "Ram",
              ContactNo = "9078609090",
              Email = "Ram@gmail.com",
              Gender = "Male",
              Birthdate = "2-11-1980",
              City = "Navsari"
          },
          new Customer
          {
              ID = 3,
              FullName = "Nayan",
              ContactNo = "9897654450",
              Email = "Nayan@gmail.com",
              Gender = "Male",
              Birthdate = "12-08-1980",
              City = "Mandsaur"
          });
        }
    }
}
