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

        public ActionResult StorePage()
        {

            return View();
        }

        public ActionResult StoreBatteryMap()
        {

            return View();
        }

        public ActionResult bbc()
        {
            //var db = new MrtorcycleContext();
            //var b=db.Products.FirstOrDefault();
            return View();
        }
        
    }
}