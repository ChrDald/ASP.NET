﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRental.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<RentalRecord> RentalRecords { get; set; }

    }
}