using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Hotel.Database.Staff
{
    class StaffContext : DbContext
    {
        public DbSet<Director> Directors { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<Subordinate> Subordinates { get; set; }
        public DbSet<EmployeeStatus> EmployeeStatuses { get; set; }
    }
}
