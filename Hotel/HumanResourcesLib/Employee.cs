using System.Collections.Generic;

namespace BuilderTest
{
    public abstract class Employee : User
    {
        protected List<Job> jobs;
        protected EmployeeStatus employeeStatus;
        protected float wage;
        public Employee()
        {

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