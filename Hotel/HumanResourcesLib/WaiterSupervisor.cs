using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderTest
{
    public class WaiterSupervisor : Supervisor
    {
        public List<Waiter> Subordinates
        {
            get
            {
                return null;
            }

            set
            {
                
            }
        }

        public override List<EmployeeStatus> CheckAllSubordinateStatus()
        {
            throw new NotImplementedException();
        }
    }
}