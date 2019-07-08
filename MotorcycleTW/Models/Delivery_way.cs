using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotorcycleTW.Models
{
    public class Delivery_way
    {
        [Key]
        public int dw_id { get; set; }
        [Display(Name ="運送方式")]
        public int dw_way { get; set; }
        public virtual ICollection<Order> Order { get; set; }

    }
}