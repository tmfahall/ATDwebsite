using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ATD.Models
{
    public class Brand
    {
        public int BrandID { get; set; }
        [DisplayName("Brand Carried")]
        public string BrandName { get; set; }

    }
}