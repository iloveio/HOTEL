using System.Collections.Generic;

namespace BuilderTest
{
    public abstract class Employee : User
    {
        protected List<Job> jobs;
        protected EmployeeStatus employeeStatus;
        protected float wage;
        public Employee():base("TestName","TestLastName",666)
        {

        }
        public Employee(string name,string lastName,uint id,EmployeeStatus employeeStatus, float wage, List<Job> jobs)
            :base(name,lastName,id)
        {
            this.employeeStatus = employeeStatus;
            this.wage = wage;
            this.jobs = jobs;
        }
        public EmployeeStatus EmployeeStatus
        {
            get
            {
                return this.employeeStatus;
            }
            
            set
            {
                this.employeeStatus = value;
            }
        }
    }
}