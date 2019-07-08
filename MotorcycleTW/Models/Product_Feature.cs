using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotorcycleTW.Models
{
    public class Product_Feature
    {
        [Key]
        public int pf_id { get; set; }
        public string pf_description { get; set; }
        public string pf_note { get; set; }
        public int p_id { get; set; }

        public virtual Product Product { get; set; }
    }
}