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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            /*
            foreach (var key in form.AllKeys)
            {
                Response.Write(String.Format("Key = {0} - ", key));
                Response.Write(form[key]);
                Response.Write("<br/>");
            }
            */
            Employee emp = new Employee();

            emp.Name = form["Name"];
            emp.Gender = form["Gender"];
            emp.City = form["City"];
            emp.DateOfBirth = Convert.ToDateTime(form["DateOfBirth"]);

            EmployeeBusinessLayer empList = new EmployeeBusinessLayer();
            empList.AddEmployee(emp);

            return RedirectToAction("Index");
        }
	}
}