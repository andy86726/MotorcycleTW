using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotorcycleTW.Models
{
    public class Member
    {
        [Key]
        public int m_id { get; set; }

        [Display(Name ="會員名稱")]
        public string m_name { get; set; }

        [Display(Name ="電子郵件")]
        [DataType(DataType.EmailAddress)]
        public string m_email { get; set; }

        [Display(Name ="密碼")]
        [DataType(DataType.Password)]
        public string m_password { get; set; }

        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Shopping_Cart> Shopping_Cart { get; set; }
    }
}