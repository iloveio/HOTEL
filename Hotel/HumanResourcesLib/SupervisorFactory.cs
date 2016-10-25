using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderTest;

namespace HumanResourcesLib
{
    public class SupervisorFactory : IEmployeeFactory
    {
        private IEmployeeFactory factory;
        List<Employee> employees;
        public SupervisorFactory(IEmployeeFactory employeeFactory,List<Employee> employees) 
        {
            this.factory = employeeFactory;
            this.employees = employees;
        }
        public Employee CreateEmployee(string name, string lastName, uint id, EmployeeStatus employeeStatus, float wage, List<Job> jobs)
        {
            return new Supervisor(name, lastName, id, employeeStatus, this.employees, wage, jobs, this.factory);
        }
    }
}