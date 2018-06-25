using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameTimeTrack.Models
{
    public class TimeTrackerRepository
    {
        TimeTrackerDbContext Context = new TimeTrackerDbContext();
        // get all employees

        public List<Employee> GetEmployees()
        {
            return (from emp in Context.Employees select emp).ToList();
        }
        
        public List<TimeCard> GetEmployeeTimeCard(int employeeId)
        {
            return (from tc in Context.Employees where tc.ID == employeeId select tc.TimeCards).SingleOrDefault();
        }
        
    }
}