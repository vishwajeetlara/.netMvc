using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "Jon",
                Gendar = "Male",
                City="Banglore"
            };
            return View(employee);
        }
    }
}