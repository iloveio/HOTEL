using BuilderTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResourcesLib
{
    public interface IEmployeeFactory
    {
        Employee CreateEmployee(string name, string lastName, uint id, EmployeeStatus employeeStatus, float wage, List<Job> jobs);
    }
}