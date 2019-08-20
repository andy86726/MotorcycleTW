using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MotorcycleTW.ViewModel
{
    public class StorePageViewModels
    {
        public string arrays { get; set; }
    }
    public class ShoppingCartViewModel
    {
        public int p_id { get; set; }
        public decimal? price { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public int member { get; set; }
    }
    public class BillPageViewModel
    {
        public string name { get; set; }
        public int cellphonenumber { get; set; }
        public string email { get; set; }
        public string storecity { get; set; }
        public string storename { get; set; }
        public string car_name { get; set; }//車主姓名
        public string car_number { get; set; }//車牌號碼
    }
}