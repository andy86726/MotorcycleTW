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
        MotorcycleContext db = new MotorcycleContext();
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
        public ActionResult ShoppingCart()//購物車
        {
            return View();
        }
        [HttpPost]
        public ActionResult ShoppingCart(StorePageViewModels model,string name)
        {
            var a = db.Products.Where(x => x.p_name == name).FirstOrDefault();
            ShoppingCartViewModel shoppingCartViewModel = new ShoppingCartViewModel() {
                p_id = a.p_id,
                name = name,
                price=a.p_unitprice,
                path= a.Product_Picture.Where(x => x.p_id == a.p_id).FirstOrDefault().pp_path
            };
            return View();
        }
        public ActionResult BillPage()//結帳頁面
        {
            return View();
        }
    }
}