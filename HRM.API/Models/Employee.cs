using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.API.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Enter your name"), MaxLength(30)]
        public string Name { get; set; }
        [Required(ErrorMessage = "enter your department")]
        public string Department { get; set; }
        [Required(ErrorMessage = "Enter your salary")]
        public string salary { get; set; }
        
    
        public bool IsManager { get; set; }
        [Required(ErrorMessage = "Select Manager")]
        public string Manager { get; set; }
        [Required(ErrorMessage = "Enter your Phone no")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
