using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderTest;
using HumanResourcesLib;

namespace HumanResourcesLib
{ 
    public class SubordinateFactory : IEmployeeFactory
    {
       

        public Employee CreateEmployee(string name, string lastName, uint id, EmployeeStatus employeeStatus, float wage, List<IJob> jobs)
        {
            return new Subordinate(name, lastName, id, employeeStatus, wage, jobs);
        }
    }
}