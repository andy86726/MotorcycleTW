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
        public string m_lastName { get; set; }//�m
        public string m_firstName { get; set; }//�W�r
        public string m_identitiy { get; set; }//�o�ӬO�k�B�k�B�k�H
        public string m_email { get; set; }//�l��
        public string m_password { get; set; }//�K�X
        public int m_phone { get; set; }//�q�ܸ��X
        public string m_identitiy_number { get; set; }//�o�ӬO�����Ҧr��
        public DateTime m_birthday { get; set; }//�ͤ�
        public string m_industry { get; set; }//¾�~
        public string m_city { get; set; }//�~������
        public string m_area { get; set; }//�~��a�~
        public string m_address { get; set; }//�a�}
        public string m_zipcode { get; set; }//�ϸ�


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shopping_Cart> Shopping_Cart { get; set; }
    }
}
