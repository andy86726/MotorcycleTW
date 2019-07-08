using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotorcycleTW.Models
{
    public class Order_Detail
    {
        [Key]
        public int od_id { get; set; }
        public int od_quantity { get; set; }
        public decimal od_price { get; set; }
        public float od_discount { get; set; }
        public int o_id { get; set; }
        public int pd_id { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product_Detail Product_Detail { get; set; }
    }
}