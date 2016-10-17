using BuilderTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResourcesLib
{
    public interface EmployeeFactory
    {
        Employee CreateEmployee();
    }
}