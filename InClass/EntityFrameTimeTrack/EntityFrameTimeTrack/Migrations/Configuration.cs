namespace EntityFrameTimeTrack.Migrations
{
    using System;
    using System.Collections;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EntityFrameTimeTrack.Models; // Add this ref to your models (classes)
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameTimeTrack.Models.TimeTrackerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFrameTimeTrack.Models.TimeTrackerDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.TimeCards.RemoveRange(context.TimeCards);
            context.Employees.RemoveRange(context.Employees);

            IList<Employee> Employees = new List<Employee>();

            Employees.Add(new Employee()
            {
                FirstName = "Bob",
                LastName = "Jose",
                Department = "IT",
                DateOfHire = DateTime.Now.AddDays(-365),
                TimeCards = new List<TimeCard>
                {
                    new TimeCard
                    {
                        SubmissionDate = DateTime.Now.AddDays(-7),
                        MondayHours = 8,
                        TuesdayHours = 8,
                        WednesdayHours = 8,
                        ThursdayHours = 8,
                        FridayHours = 1,
                        SaturdayHours = 12,
                        SundayHours = 12
                    },
                    new TimeCard
                    {
                        SubmissionDate = DateTime.Now,
                        MondayHours = 1,
                        TuesdayHours = 1,
                        WednesdayHours = 8,
                        ThursdayHours = 24,
                        FridayHours = 4,
                        SaturdayHours = 24,
                        SundayHours = 48
                    }
                }
            });
            context.Employees.AddRange(Employees);
            base.Seed(context); // this overrides the original .Seed method with the above code
            // next step is go to the console, write add-migration (Name you want for it) and run
            // finally write update-database in the console to create your database
        }
    }
}
