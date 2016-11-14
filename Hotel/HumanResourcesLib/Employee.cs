using HumanResourcesLib;
using System.Collections.Generic;

namespace BuilderTest
{
    public abstract class Employee : User
    {
        protected List<IJob> jobs;
        protected EmployeeStatus employeeStatus;
        protected float wage;
        public Employee(string name, string lastName, uint id) :base(name,lastName,id)
        {

        }
        // override object.Equals
        public override bool Equals(object obj)
        {

            Employee empObj = obj as Employee;
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return id.Equals(obj);
        }

        public override int GetHashCode()
        {
            
            return this.id.GetHashCode();
        }
        public Employee(string name,string lastName,uint id,EmployeeStatus employeeStatus, float wage, List<IJob> jobs)
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
        public List<IJob> Jobs
        {
            get
            {
                return this.jobs;
            }
            set
            {
                this.jobs = value;
            }
        }
    }
}