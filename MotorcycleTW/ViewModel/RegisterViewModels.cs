using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MotorcycleTW.ViewModel
{
    public class RegisterViewModels
    {
        public string City { get; set; }
        public List<ArrayList> arrayLists { get; set; }
    }
    public class ArrayList
    {
        public string AreaName { get; set; }
        public int ZipCode { get; set; }
    }


}