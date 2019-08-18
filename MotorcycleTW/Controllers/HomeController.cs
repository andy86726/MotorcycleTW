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
        public ActionResult StorePage_Product(Products model)//網路商店-產品頁
        {
            return View();
        }
        [HttpPost]
        public ActionResult StorePage_Product(StorePageViewModels models,string Member, string ID)
        {
            //if (Session["shoppingCartViewModel"] != null)
            //{
            //    var shoppingCartList = (List<string>)Session["shoppingCartViewModel"];
            //    if (shoppingCartList[0] == ID)
            //    {
            //        shoppingCartList[2] = (int.Parse(Member) * decimal.Parse(Member)).ToString();
            //        shoppingCartList[4] = Member;
            //    };
            //    Session["shoppingCartViewModel"] = shoppingCartList;
            //    return View("ShoppingCart");
            //}
            //else { 
                var member = int.Parse(models.arrays[0].ToString());
                var productname=models.arrays[1].ToString();
                for(var i = 2; i < models.arrays.Length; i++)
                {
                    productname = productname + models.arrays[i].ToString();
                }
                var a = db.Products.Where(x => x.p_name == productname).FirstOrDefault();
                var Product_Picture = db.Product_Picture.Where(x => x.p_id == a.p_id).FirstOrDefault();
                    List<string> shoppingCartViewModel = new List<string>()
                {
                    a.p_id.ToString(),//產品id
                    a.p_name,//產品名
                    (member*a.p_unitprice).ToString(),//產品總價
                    Product_Picture.pp_path,//產品圖片
                    member.ToString(),//產品數量
                    a.p_unitprice.ToString()//產品單價
                };
                Session["shoppingCartViewModel"] = shoppingCartViewModel;
            //}
            return View("ShoppingCart");
        }
        public ActionResult ShoppingCart()//購物車
        {

            return View();
        }
        [HttpPost]
        public ActionResult ShoppingCart(string name,string ShoppingmeMber)
        {
            
            var a = db.Products.Where(x => x.p_name == name).FirstOrDefault();
            var Product_Picture = db.Product_Picture.Where(x => x.p_id == a.p_id).FirstOrDefault();
            ShoppingCartViewModel shoppingCartViewModel = new ShoppingCartViewModel() {
                p_id = a.p_id,
                name = a.p_name,
                price = a.p_unitprice,
                path = Product_Picture.pp_path
            };
            return View(shoppingCartViewModel);
        }
        public ActionResult BillPage()//結帳頁面
        {
            return View();
        }
        public ActionResult gogoromap()
        {
            return View();
        }
    }
}