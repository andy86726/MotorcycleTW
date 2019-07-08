using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotorcycleTW.Models
{
    public class Product_Detail
    {
        [Key]
        public int pd_id { get; set; }
        public string pd_color { get; set; }
        public int pd_stock { get; set; }
        public int pd_onorder { get; set; }
        public int p_id { get; set; }

        public virtual Product Product { get; set; }
    }          
}