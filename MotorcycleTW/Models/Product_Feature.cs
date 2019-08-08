namespace MotorcycleTW.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product_Feature
    {
        [Key]
        public int pf_id { get; set; }

        public string pf_description { get; set; }

        public string pf_note { get; set; }

        public int p_id { get; set; }

        public virtual Products Products { get; set; }
    }
}
