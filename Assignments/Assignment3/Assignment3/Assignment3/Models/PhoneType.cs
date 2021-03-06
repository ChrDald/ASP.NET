﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class PhoneType
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(10)]
        public string Type { get; set; }

        [Required]
        [MaxLength(10)]
        public string OS { get; set; }

        public string DisplayText
        {
            get
            {
                return (OS + " " + Type);
            }
        }
    }
}