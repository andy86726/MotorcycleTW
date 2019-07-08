using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotorcycleTW.Models
{
    public class Classify
    {
        [Key]
        public int cl_id { get; set; }
        public string cl_specs { get; set; }
        public string cl_content { get; set; }
        public int p_id { get; set; }

        public virtual Product Product { get; set; }
    }
}