using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace HRM.MVC.Controllers
{
    public class EmployeeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Email, string password)
        {
            if (Email == "saloni@gmail.com" && password == "saloni")
                return RedirectToAction("Index");
            else 
                return View();  
        }

        public IActionResult AddEmploye()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult ViewEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateEmployee()
        {
            return View();
        }

    }
}
