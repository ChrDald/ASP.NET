using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment3.ViewModels
{
    public class PhoneFullDetailsViewModel
    {
        public int ID { get; set; }
        public string PhoneName { get; set; }
        public DateTime DateReleased { get; set; }
        public string ScreenSize { get; set; }
        public string BrandName { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Type { get; set; }
        public string OS { get; set; }
    }
}