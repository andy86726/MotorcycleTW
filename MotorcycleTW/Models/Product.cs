using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotorcycleTW.Models
{
    public class Product
    {
        [Key]
        public int p_id { get; set; }

        [Display(Name ="產品名稱")]
        public string p_name { get; set; }

        [Display(Name ="產品單價")]
        public decimal p_unitprice { get; set; }

        public DateTime p_lauchdate { get; set; }

        public int c_id { get; set; }

        public string p_status { get; set; }

        public virtual ICollection<Product_Detail> Product_Details { get; set; }
    }
}