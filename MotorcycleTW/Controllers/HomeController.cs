using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MotorcycleTW.Models;

namespace MotorcycleTW.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult bbc()
        {
            var db = new MotorcycleContext();
            var b=db.Products.FirstOrDefault();
            var a= 123;
            return View(b);
        }
    }
}