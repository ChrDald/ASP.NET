namespace VideoRental.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VideoRental.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VideoRental.Models.DbContextVideoRental>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VideoRental.Models.DbContextVideoRental context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Customers.AddOrUpdate(
                new Customer() {
                    FirstName = "John",
                    LastName = "Notsmith",
                    Address = "Street 101",
                    Phone = "514-505-5575",
                    RentalRecords = new List<RentalRecord>
                    {
                        new RentalRecord
                        {
                            RentalDate = DateTime.Now,
                            RentedMedia = new List<Media>
                            {
                                new Media
                                {
                                    Title = "Monty Python",
                                    ProductionYear = DateTime.Now.AddDays(-10000)
                                },
                                new Media
                                {
                                    Title = "Debby In Dallas",
                                    ProductionYear = DateTime.Now.AddDays(-500)
                                }
                            }
                        }
                    }
                },
                new Customer()
                {
                    FirstName = "Johnny",
                    LastName = "Cash",
                    Address = "Everywhere",
                    Phone = "Unknown",
                    RentalRecords = new List<RentalRecord>
                    {
                        new RentalRecord
                        {
                            RentalDate = DateTime.Now,
                            RentedMedia = new List<Media>
                            {
                                new Media
                                {
                                    Title = "Nintendo 64",
                                    ProductionYear = DateTime.Now.AddDays(-10000)
                                },
                                new Media
                                {
                                    Title = "Sega Genesis",
                                    ProductionYear = DateTime.Now.AddDays(-500)
                                }
                            }
                        }
                    }
                }
            );
            base.Seed(context);
        }
    }
}
