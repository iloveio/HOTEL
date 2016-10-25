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
        private List<Employee> supervisors;

        IEmployeeFactory employeeFactory;

        public Director(string name, string lastName, uint id,List<Employee> supervisors) : base(name, lastName, id)
        {
            this.supervisors = supervisors;
        }

        public List<EmployeeStatus> CheckAllSubordinateStatus()
        {
            throw new NotImplementedException();
        }

        public Employee FireAnEmployee()
        {
            throw new NotImplementedException();
        }

        public HumanResourcesLib.IEmployeeFactory GetFactory
        {
            get
            {
                return this.employeeFactory;
            }
            set
            {
                this.employeeFactory = value;
            }
        }

        public Employee HireAnEmployee(string name, string lastName, uint id, EmployeeStatus employeeStatus, float wage, List<Job> jobs)
        {
            return this.GetFactory.CreateEmployee(name, lastName, id, employeeStatus, wage, jobs);
        }


    }
}