using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResourcesLib
{
    public class EmployeeStatus
    {
        private DateTime statusBegining;
        private DateTime statusEnd;
        EmployeeStatusName statusName;
        
        public EmployeeStatus(EmployeeStatusName statusName, DateTime statusBegining, DateTime statusEND)
        {
            this.statusName = statusName;
            this.statusBegining = statusBegining;
            this.statusEnd = statusEND;

        }
    
        public DateTime StatusBegining
        {
            get
            {
                return this.statusBegining;
            }
            set
            {
                statusBegining = value;
            }
        }
        public DateTime StatusEnd
        {
            get
            {
                return this.statusEnd;
            }
            set
            {
                statusEnd = value;
            }
        }

    }
}