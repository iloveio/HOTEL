using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderTest;

namespace HumanResourcesLib
{
    public class SupervisorFactory : EmployeeFactory
    {
        public Employee CreateEmployee()
        {
            return new Supervisor();
        }
    }
}