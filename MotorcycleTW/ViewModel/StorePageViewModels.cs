using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MotorcycleTW.ViewModel
{
    public class StorePageViewModels
    {
        public int ShoppingmeMber { get; set; }
    }
    public class ShoppingCartViewModel
    {
        public int p_id { get; set; }
        public decimal price { get; set; }
        public string name { get; set; }
        public string path { get; set; }
    }
}