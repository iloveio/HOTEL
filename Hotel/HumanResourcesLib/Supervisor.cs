using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResourcesLib;

namespace BuilderTest
{
    public class Supervisor : Employee, IManager
    {
        protected List<Employee> employees;
        protected IEmployeeFactory subordinateFactory;

        public Supervisor():base()
        {

        }

        public Supervisor(string name, string lastName, uint id, EmployeeStatus employeeStatus,List<Employee> employees, float wage, List<Job> jobs,IEmployeeFactory subrodinateFactory) : 
            base(name, lastName, id, employeeStatus, wage, jobs)
        {
            this.subordinateFactory = subrodinateFactory;
            this.employees = employees;
        }

        public List<EmployeeStatus> CheckAllSubordinateStatus()
        {
            throw new NotImplementedException();
        }

        public Employee FireAnEmployee()
        {
            throw new NotImplementedException();
        }

        public IEmployeeFactory GetFactory
        {
            get
            {
                return this.subordinateFactory;
            }
            set
            {
                this.subordinateFactory = value;
            }
        }

        public Employee HireAnEmployee(string name, string lastName, uint id, EmployeeStatus employeeStatus, float wage, List<Job> jobs)
        {
            return GetFactory.CreateEmployee(name, lastName, id, employeeStatus, wage, jobs);
        }
    }
     
}