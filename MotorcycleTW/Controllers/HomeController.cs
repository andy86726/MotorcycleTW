﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            //var db = new MrtorcycleContext();
            //var b=db.Products.FirstOrDefault();
            return View();
        }
        public ActionResult SalesPage()
        {
            return View();
        }
        public ActionResult StorePage(string a)//網路商店
        {

            return View();
        }
        [HttpPost]
        public ActionResult StorePage()
        {
            return View();
        }

        public ActionResult ShoppingCart(string a)//購物車
        {
            return View();
        }
        [HttpPost]
        public ActionResult ShoppingCart()
        {
            return View();
        }
    }
}