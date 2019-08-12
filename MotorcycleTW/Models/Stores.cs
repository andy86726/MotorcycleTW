namespace MotorcycleTW.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Stores
    {
        [Key]
        public int s_id { get; set; }

        public string s_name { get; set; }

        public string s_block { get; set; }

        public string s_address { get; set; }
    }
}
