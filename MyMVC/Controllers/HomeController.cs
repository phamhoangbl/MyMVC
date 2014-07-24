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
        public ViewResult Index()
        {
            //ViewData
            ViewData["Contries"] = new List<String>() { "Us", "VietName", "Autrialia", "Singapore" };
            return View();
        }
	}
}