using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace MyMVC.Controllers
{
    public class EmployeeBusinessController : Controller
    {
        //
        // GET: /EmployeeBusiness/
        public ActionResult Index()
        {
            EmployeeBusinessLayer emp = new EmployeeBusinessLayer();
            List<Employee> listEmployee = emp.Employees.ToList();
            return View(listEmployee);
        }
	}
}