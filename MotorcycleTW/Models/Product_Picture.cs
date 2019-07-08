using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotorcycleTW.Models
{
    public class Product_Picture
    {
        [Key]
        public int pp_id { get; set; }

        [DataType(DataType.ImageUrl)]
        public string pp_path { get; set; }

        public DateTime pp_uploadtime { get; set; }

        public int p_id { get; set; }

        public virtual Product Product { get; set; }
    }
}