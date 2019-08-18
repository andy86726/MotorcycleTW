namespace MotorcycleTW.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product_Picture
    {
        [Key]
        public int pp_id { get; set; }

        public string pp_path { get; set; }
        public int p_id { get; set; }
        [ForeignKey("p_id")]
        public virtual Products Products { get; set; }
    }
}
