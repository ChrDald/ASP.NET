using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VideoRental.Models
{
    public class DbContextVideoRental : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<RentalRecord> RentalRecords { get; set; }
        // Medias isnt a word, media is already plural, so the table is called media
        public DbSet<Media> Media { get; set; }
    }
}