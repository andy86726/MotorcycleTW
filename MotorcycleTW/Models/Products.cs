namespace MotorcycleTW.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            Classifies = new HashSet<Classifies>();
            Order_Detail = new HashSet<Order_Detail>();
            Product_Feature = new HashSet<Product_Feature>();
            Product_Picture = new HashSet<Product_Picture>();
        }

        [Key]
        public int p_id { get; set; }

        public string p_name { get; set; }

        public decimal? p_unitprice { get; set; }

        public int? c_id { get; set; }

        public string p_status { get; set; }

        public string p_photo { get; set; }

        public int? p_stock { get; set; }

        public int? p_onorder { get; set; }

        public string p_color_1 { get; set; }

        public string p_color_2 { get; set; }

        public virtual Categories Categories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Classifies> Classifies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Detail> Order_Detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Feature> Product_Feature { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Picture> Product_Picture { get; set; }

        public virtual Shopping_Cart Shopping_Cart { get; set; }
    }
}
