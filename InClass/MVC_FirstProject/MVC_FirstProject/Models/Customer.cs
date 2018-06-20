using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_FirstProject.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Subscribed { get; set; }

        public Membership MembershipType { get; set; }
        public byte MembershipID { get; set; }

        public DateTime? Birthdate { get; set; }
    }
}