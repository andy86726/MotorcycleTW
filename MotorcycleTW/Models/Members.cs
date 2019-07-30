namespace MotorcycleTW.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Members
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Members()
        {
            Orders = new HashSet<Orders>();
            Shopping_Cart = new HashSet<Shopping_Cart>();
        }

        [Key]
        public int m_id { get; set; }

        public string m_name { get; set; }

        public string m_email { get; set; }

        public string m_password { get; set; }
        public string m_identitiy { get; set; }//男、女、法人
        public int m_phone { get; set; }//電話號碼
        public string m_identitiy_number { get; set; }//身份證字號
        public string m_address { get; set; }//居住地
        public string m_zipcode { get; set; }//郵遞區號
        public DateTime m_birthday { get; set; }//生日
        public string m_status { get; set; }//驗證狀態
        [Display(Name ="驗證碼")]
        public string m_verification { get; set; }//驗證碼
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shopping_Cart> Shopping_Cart { get; set; }
    }
}
