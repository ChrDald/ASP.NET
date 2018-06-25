using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment3.ViewModels
{
    public class AddPhoneViewModel
    {
        [Required(ErrorMessage = "Please enter a phone name.")]
        [MaxLength(255)]
        public string PhoneName { get; set; }

        [Required(ErrorMessage = "Enter a valid release date (format - dd mm yyyy")]
        public DateTime DateReleased { get; set; }

        [Required(ErrorMessage = "Please enter a valid screen size (from 50 to 2000)")]
        [Range(50, 2000)]
        public string ScreenSize { get; set; }

        public string BrandName { get; set; }
        public List<Brand> Brands { get; set; }
        public List<PhoneType> PhoneTypes { get; set; }

        public List<string> PhoneTypeDisplay { get; set; }

        [Required(ErrorMessage = "Please select a brand")]
        public int BrandId { get; set; }

        [Required(ErrorMessage = "Please select a phone type")]
        public int PhoneTypeId { get; set; }

        public int ID { get; set; }
    }
}