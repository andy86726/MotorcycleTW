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
        public string m_lastName { get; set; }//姓
        public string m_firstName { get; set; }//名字
        public string m_identitiy { get; set; }//這個是男、女、法人
        public string m_email { get; set; }//郵件
        public string m_password { get; set; }//密碼
        public int m_phone { get; set; }//電話號碼
        public string m_identitiy_number { get; set; }//這個是身份證字號
        public DateTime m_birthday { get; set; }//生日
        public string m_industry { get; set; }//職業
        public string m_city { get; set; }//居住的城市
        public string m_area { get; set; }//居住地居
        public string m_address { get; set; }//地址
        public string m_zipcode { get; set; }//區號


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shopping_Cart> Shopping_Cart { get; set; }
    }
}
