using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        public string Birthdate { get; set; }
        public string City { get; set; }

    }
}
