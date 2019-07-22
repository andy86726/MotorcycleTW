namespace MotorcycleTW.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Classifies
    {
        [Key]
        public int cl_id { get; set; }

        public string cl_specs { get; set; }

        public string cl_content { get; set; }

        public int p_id { get; set; }

        public virtual Products Products { get; set; }
    }
}
