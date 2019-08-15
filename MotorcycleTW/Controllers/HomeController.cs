using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MotorcycleTW.Models;
using MotorcycleTW.ViewModel;
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
        public ActionResult StorePage()//網路商店
        {

            return View();
        }
        [Authorize]
        public ActionResult ShoppingCart()//購物車
        {
            return View();
        }
        [HttpPost]
        public ActionResult ShoppingCart(StorePageViewModels model, string titlename)
        {
            return View();
        }
    }
}