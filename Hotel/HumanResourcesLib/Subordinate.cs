using HumanResourcesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResourcesLib
{
    public partial class Subordinate : Employee
    {
        public Subordinate(string name, string lastName, uint id, EmployeeStatus employeeStatus, float wage, List<Job> jobs) 
            : base(name, lastName, id, employeeStatus, wage, jobs)
        {
            
        }

    }

}