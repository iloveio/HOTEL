using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderTest
{
    public class EmployeeStatus
    {
        private DateTime statusBegining;
        private DateTime statusEnd;
        EmployeeStatusName satusName;
    
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