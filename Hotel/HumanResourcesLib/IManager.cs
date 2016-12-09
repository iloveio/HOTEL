using HumanResourcesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResourcesLib
{
    public interface IManager
    {
        Employee HireAnEmployee(string name, string lastName, uint id, EmployeeStatus employeeStatus, float wage, List<Job> jobs);
        Employee FireAnEmployee();
        List<EmployeeStatus> CheckAllSubordinateStatus();
    }
}