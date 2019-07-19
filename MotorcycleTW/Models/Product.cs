namespace MotorcycleTW.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Classifies = new HashSet<Classifie>();
            Product_Feature = new HashSet<Product_Feature>();
            Product_Picture = new HashSet<Product_Picture>();
        }

        [Key]
        public int p_id { get; set; }

        public string p_name { get; set; }

        public decimal p_unitprice { get; set; }

        public int c_id { get; set; }

        public string p_status { get; set; }

        public string p_photo { get; set; }

        public int p_stock { get; set; }

        [StringLength(50)]
        public string p_color { get; set; }

        public int p_onorder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Classifie> Classifies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Feature> Product_Feature { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Picture> Product_Picture { get; set; }

        public virtual Shopping_Cart Shopping_Cart { get; set; }
    }
}
