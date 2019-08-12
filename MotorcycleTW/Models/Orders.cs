namespace MotorcycleTW.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            Order_Detail = new HashSet<Order_Detail>();
        }

        [Key]
        public int o_id { get; set; }

        public DateTime? o_date { get; set; }

        public string o_receiver { get; set; }

        public int? o_cellphonenumber { get; set; }

        public string o_email { get; set; }

        public string o_address { get; set; }

        public DateTime? o_delivedate { get; set; }

        public string o_status { get; set; }

        public int? pay_id { get; set; }

        public int? dw_id { get; set; }

        public int? m_id { get; set; }

        public virtual Delivery_way Delivery_way { get; set; }

        public virtual Members Members { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Detail> Order_Detail { get; set; }

        public virtual Payments Payments { get; set; }
    }
}
