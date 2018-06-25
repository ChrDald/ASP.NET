using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment3.Models
{
    public class Brand
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(255)]
        public string BrandName { get; set; }

        public string CountryOfOrigin { get; set; }
    }
}