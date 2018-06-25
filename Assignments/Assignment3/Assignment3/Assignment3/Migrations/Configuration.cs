namespace Assignment3.Migrations
{
    using Assignment3.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment3.Models.PhonoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Assignment3.Models.PhonoDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            /*
            // Phones
            IList<Phone> phones = new List<Phone>
            {
                new Phone {
                    PhoneName = "G4",
                    DateReleased = DateTime.Now.AddYears(-4),
                    ScreenSize = "500px"
                },
                new Phone {
                    PhoneName = "Iphone 5s",
                    DateReleased = DateTime.Now.AddYears(-6),
                    ScreenSize = "400px"
                },
                new Phone {
                    PhoneName = "Brick",
                    DateReleased = DateTime.Now.AddYears(-12),
                    ScreenSize = "150px"
                }
            };

            foreach(Phone p in phones)
            {
                context.Phone.AddOrUpdate(p);
            }

            // Brands
            IList<Brand> Brands = new List<Brand>
            {
                new Brand {
                    BrandName = "Apple",
                    CountryOfOrigin = "USA"
                },
                new Brand {
                    BrandName = "Samsung",
                    CountryOfOrigin = "Korea"
                },
                new Brand {
                    BrandName = "Huawei",
                    CountryOfOrigin = "China"
                }
            };

            foreach (Brand b in Brands)
            {
                context.Brand.AddOrUpdate(b);
            }

            // Phone Types
            IList<PhoneType> PhoneTypes = new List<PhoneType>
            {
                new PhoneType {
                    OS = "IOS",
                    Type = "Smart"
                },
                new PhoneType {
                    OS = "Android",
                    Type = "Smart"
                },
                new PhoneType {
                    OS = "NA",
                    Type = "Bar"
                },
                new PhoneType {
                    OS = "NA",
                    Type = "Flip"
                }
            };
            
            foreach(PhoneType t in PhoneTypes)
            {
                context.PhoneType.AddOrUpdate(t);
            }

            base.Seed(context);
            */
        }
    }
}
