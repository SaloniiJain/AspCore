using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.API.Database;
using HRM.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeedbContext _employeedbContext;
        public EmployeeController(EmployeedbContext employeedbContext)
        {
            _employeedbContext = employeedbContext;
        }

        [HttpGet, Route("getEmployees")]
        public IActionResult GetAllEmployees()
        {
            if (_employeedbContext == null)
            {
                return NotFound();
            }

            return Ok(_employeedbContext.Employees.ToList());
        }

        [HttpPost, Route("AddEmployee")]
        public IActionResult AddEmployees()
        {
          
            _employeedbContext.Employees.Add(new Employee()
            {
                Name = "Saloni",
                Department = "IT",
                IsManager = true,
                salary = "3000000",
                Manager = "ITManager",
                Phone = "8909890989",
                Email = "saloni@gmail.com",
            });

            _employeedbContext.SaveChanges();
            return Ok(true);
        }

        [HttpPut, Route("UpdateEmployee/{id}")]
         public IActionResult UpdateEmployees(int id)
        {
            var existingEmployee = _employeedbContext.Employees.Where(e => e.Id == id).FirstOrDefault();
   
            if (existingEmployee != null)
            {
                existingEmployee.Name = "Ram";

                _employeedbContext.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete, Route("DeleteEmployee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            if (id < 0)
                return BadRequest("Not a valid id");

            var existingEmployee = _employeedbContext.Employees.Where(e => e.Id == id)
                                                    .FirstOrDefault();
            _employeedbContext.Entry(existingEmployee).State = EntityState.Deleted;
            _employeedbContext.SaveChanges();

            return Ok(true);
        }

        [HttpGet ,Route("SelectEmployee/{id}")]
        public IActionResult SelectEmployee(int id)
        {
            var existingEmployee = _employeedbContext.Employees.Find(id);
           
            return Ok(existingEmployee);
        }
    }
}
