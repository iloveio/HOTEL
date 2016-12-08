using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Database.Staff
{
    public class Subordinate : Employee
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public virtual List<Job> jobs { get; set; }
        public virtual EmployeeStatus employeeStatus { get; set; }
        public float wage { get; set; }

        public Subordinate(int id, string name, List<Job> jobs, EmployeeStatus status, float wage)
        {
            this.id = id;
            this.name = name;
            this.jobs = jobs;
            this.employeeStatus = status;
            this.wage = wage;
        }
    }
}
