using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database.Staff
{
    class Supervisor : Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public virtual List<Employee> subordinates { get; set; }
        public float wage { get; set; }
        public virtual EmployeeStatus employeeStatus { get; set; }
        public virtual List<Job> jobs { get; set; }
}
}
