using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotorcycleTW.Models
{
    public class MemberInfoamtion
    {
        [StringLength(10, ErrorMessage = "{0} 的長度必須為 {2} 個字元。", MinimumLength = 10)]
        [Display(Name = "身分證字號/統一編號")]
        public string Identit { get; set; }
    }
}