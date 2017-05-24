using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ATD.Models
{
    public class Service
    {
        public int ServiceID { get; set; }
        [DisplayName("Service")]
        public string ServiceName { get; set; }
    }
}