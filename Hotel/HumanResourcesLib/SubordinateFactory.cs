using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderTest;
using HumanResourcesLib;

namespace HumanResourcesLib
{ 
    public class SubordinateFactory : EmployeeFactory
    {
        public Employee CreateEmployee()
        {
            return new Subordinate();
        }
    }
}