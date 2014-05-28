using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVC.Models;

namespace MyMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Details(int id)
        {
            //Employee employee = new Employee() { EmployeeId = 101, Gender = "Male", City = "HCM", Name = "John"};
            EmployeeContext context = new EmployeeContext();
            Employee employee = context.Employees.Single(emp => emp.EmployeeId == id);
             return View(employee);
        }
	}
}