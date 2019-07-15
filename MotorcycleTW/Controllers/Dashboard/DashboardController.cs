using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MotorcycleTW.Controllers.Dashboard
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult DashboardDesiner()
        {
            return View("DashboardDesiner");
        }
    }
}