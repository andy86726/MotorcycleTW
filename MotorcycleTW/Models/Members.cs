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
        public string m_identitiy { get; set; }//�k�B�k�B�k�H
        public int m_phone { get; set; }//�q�ܸ��X
        public string m_identitiy_number { get; set; }//�����Ҧr��
        public string m_address { get; set; }//�~��a
        public string m_zipcode { get; set; }//�l���ϸ�
        public DateTime m_birthday { get; set; }//�ͤ�
        public string m_status { get; set; }//���Ҫ��A
        [Display(Name ="���ҽX")]
        public string m_verification { get; set; }//���ҽX
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shopping_Cart> Shopping_Cart { get; set; }
    }
}
