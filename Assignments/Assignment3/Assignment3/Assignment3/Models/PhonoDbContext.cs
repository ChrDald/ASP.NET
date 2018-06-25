using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment3.Models
{
    public class PhonoDbContext : DbContext
    {
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<PhoneType> PhoneType { get; set; }
    }
}