using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotorcycleTW.Models
{
    public class Payment
    {
        [Key]
        public int pay_id { get; set; }
        public string pay_name { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}