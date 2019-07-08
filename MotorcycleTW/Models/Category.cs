using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotorcycleTW.Models
{
    public class Category
    {
        [Key]
        public int c_id { get; set; }
        [Display(Name ="種類名")]
        public string c_name { get; set; }

        public virtual ICollection<Discount> Discount { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}