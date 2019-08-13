using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MotorcycleTW.Controllers
{
    public class MotoPageController : Controller
    {
        // GET: MotoPage
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult design()
        {
            return View();
        }
        public ActionResult spec()
        {
            return View();
        }


        public ActionResult Plus1()
        {
            return View();
        }
    }
}