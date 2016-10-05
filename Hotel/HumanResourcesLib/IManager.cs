using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderTest
{
    public interface IManager
    {
       List<EmployeeStatus> CheckAllSubordinateStatus();
    }
}