namespace MotorcycleTW.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shopping_Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cart_id { get; set; }

        public int m_id { get; set; }

        public int p_id { get; set; }

        public int cart_quantity { get; set; }

        public virtual Members Members { get; set; }

        public virtual Products Products { get; set; }
    }
}
