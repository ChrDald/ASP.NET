using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_FirstProject.Models
{
    public class Membership
    {
        public byte ID { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscontRate { get; set; }
        public string Name { get; set; }

    }
}