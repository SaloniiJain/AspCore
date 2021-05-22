using CustomerService.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerService.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomers _customers;
        public CustomersController(ICustomers customers)
        {
            _customers = customers;
        }

        // GET: api/<CustomersController>
        [HttpGet(template:"CustomerList")]
        public IActionResult Get()
        {
            var cust = _customers.GetCustomers();
            return new OkObjectResult(cust);
        }
    }
}
