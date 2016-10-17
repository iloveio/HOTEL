using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResourcesLib;

namespace BuilderTest
{
    public class Supervisor : Employee, IManager
    {
        protected List<Subordinate> employees;
        protected EmployeeFactory SubordinateFactory;

        public List<EmployeeStatus> CheckAllSubordinateStatus()
        {
            throw new NotImplementedException();
        }

        public Employee FireAnEmployee()
        {
            throw new NotImplementedException();
        }

        public EmployeeFactory GetFactory()
        {
            return new SubordinateFactory();
        }

        public Employee HireAnEmployee()
        {
            return GetFactory().CreateEmployee();
        }
    }
     
}