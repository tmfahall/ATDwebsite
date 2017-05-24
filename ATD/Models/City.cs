using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ATD.Models
{
    public class City
    {
        public int CityID { get; set; }
        [DisplayName("City")]
        public string CityName { get; set; }
    }
}