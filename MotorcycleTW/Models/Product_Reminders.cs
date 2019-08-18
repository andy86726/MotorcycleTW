using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MotorcycleTW.Models
{
    public class Product_Reminders
    {
        [Key]
        public int pr_id { get; set; }
        public string pr_detail { get; set; }//溫馨提醒
        public int p_id { get; set; }
        [ForeignKey("p_id")]
        public virtual Products Products { get; set; }
    }
}