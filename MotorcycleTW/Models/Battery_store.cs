using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotorcycleTW.Models
{
    public class Battery_store
    {
        [Key]
        public int s_id { get; set; }
        [Display(Name = "店名")]
        public string s_name { get; set; }
        [Display(Name = "區域")]
        public string s_block { get; set; }
        [Display(Name = "地址")]
        public string s_address { get; set; }
    }
}