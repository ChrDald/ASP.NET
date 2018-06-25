using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; // Add Entity Ref

namespace EntityFrameTimeTrack.Models
{
    public class TimeTrackerDbContext : DbContext // Extend DbContext
    {
        // Add Db Sets for the tables (these are your tables based off your classes)
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TimeCard> TimeCards { get; set; }

        // go to tools -> NuGet -> Console -> Type enable-migrations (once for each project) -> Magic (Migration folder)
    }
}