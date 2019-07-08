using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotorcycleTW.Models
{
    public class Shopping_Cart
    {
        [Key]
        public int cart_id { get; set; }
        public int m_id { get; set; }
        public int pd_id { get; set; }
        public int cart_quantity { get; set; }

        public virtual Member Member { get; set; }
        public virtual Product_Detail Product_Detail { get; set; }
    }
}