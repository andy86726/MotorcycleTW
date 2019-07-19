namespace MotorcycleTW.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Discount
    {
        [Key]
        public int d_id { get; set; }

        public float d_discount { get; set; }

        public DateTime d_startdate { get; set; }

        public DateTime d_enddate { get; set; }

        public int c_id { get; set; }

        public string d_activity { get; set; }

        public virtual Categories Categories { get; set; }
    }
}
