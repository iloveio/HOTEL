using HumanResourcesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderTest
{
    public interface IManager
    {
        EmployeeFactory GetFactory();
        Employee HireAnEmployee();
        Employee FireAnEmployee();
        List<EmployeeStatus> CheckAllSubordinateStatus();
    }
}