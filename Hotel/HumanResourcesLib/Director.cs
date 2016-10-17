using BuilderTest;
using HumanResourcesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderTest
{
    public class Director : User, IManager
    {
        private List<Supervisor> supervisors;

        public List<EmployeeStatus> CheckAllSubordinateStatus()
        {
            throw new NotImplementedException();
        }

        public Employee FireAnEmployee()
        {
            throw new NotImplementedException();
        }

        public HumanResourcesLib.EmployeeFactory GetFactory()
        {
            return new SupervisorFactory();
        }

        public Employee HireAnEmployee()
        {
            return GetFactory().CreateEmployee();
        }
    }
}