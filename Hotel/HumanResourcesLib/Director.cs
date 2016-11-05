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
        private static volatile Director directorInstance;

        private object syncObject = new object();

        IEmployeeFactory employeeFactory;

        private Director(string name, string lastName, uint id,List<Employee> supervisors) : base(name, lastName, id)
        {
            this.supervisors = supervisors;
        }
        public Director GetInstance(string name, string lastName, uint id, List<Employee> supervisors)
        {
            
                if( directorInstance == null)
                {
                    lock(syncObject)
                    {
                        if (directorInstance == null)
                        {
                            directorInstance = new Director(name, lastName, id, supervisors);
                        }
                    }
                }
            return directorInstance;
            
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