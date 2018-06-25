using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment3.Models
{
    public class Phone
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a phone name.")]
        [MaxLength(255)]
        public string PhoneName { get; set; }

        [Required(ErrorMessage = "Enter a valid release date (format - dd mm yyyy")]
        public DateTime DateReleased { get; set; }

        // Using this range since using pixels as screensize
        [Range(50,2000)]
        public string ScreenSize { get; set; }

        //Phone Type Foreign Key
        [Required]
        public int PhoneTypeId { get; set; }
        public PhoneType PhoneType { get; set; }

        //Brand foreign key
        [Required]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

    }
}