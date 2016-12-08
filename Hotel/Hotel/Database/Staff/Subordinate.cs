using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database.Staff
{
    class Subordinate : Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual List<Job> jobs { get; set; }
        public virtual EmployeeStatus employeeStatus { get; set; }
        public float wage { get; set; }
}
}
