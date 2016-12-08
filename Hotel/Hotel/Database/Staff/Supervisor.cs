using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Database.Staff
{
    public class Supervisor : Employee
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public virtual List<Employee> subordinates { get; set; }
        public float wage { get; set; }
        public virtual EmployeeStatus employeeStatus { get; set; }
        public virtual List<Job> jobs { get; set; }

        public Supervisor(int id, string name, string lastname, List<Employee> subordinates, float wage, EmployeeStatus status, List<Job> jobs)
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
            this.subordinates = subordinates;
            this.wage = wage;
            this.employeeStatus = status;
            this.jobs = jobs;
        }
}
}
