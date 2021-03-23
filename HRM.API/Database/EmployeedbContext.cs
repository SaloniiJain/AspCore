using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.API.Database
{
    public class EmployeedbContext : DbContext
    {
        internal static readonly int Count;

        public EmployeedbContext(DbContextOptions options) : base(options)  
        {
         
        }
        public DbSet<Employee> Employees { get; set; }
        public string Name { get; internal set; }
    }
}
