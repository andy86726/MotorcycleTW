using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotorcycleTW.Models
{
    public class Order
    {
        [Key]
        public int o_id { get; set; }
        public DateTime o_date { get; set; }
        public string o_receiver { get; set; }
        public int o_cellphonenumber { get; set; }
        public string o_email { get; set; }
        public string o_address { get; set; }
        public DateTime o_delivedate { get; set; }
        public string o_status { get; set; }
        public int pay_id { get; set; }
        public int dw_id { get; set; }
        public int m_id { get; set; }

        public virtual Store Delive_Way { get; set; }
        public virtual Member Member { get; set; }
        public virtual ICollection<Order_Detail> Order_Detail { get; set; }
        public virtual Payment Payment { get; set; }
    }
}