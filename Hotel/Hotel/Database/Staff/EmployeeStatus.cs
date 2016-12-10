using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Database.Staff
{
    public class EmployeeStatus
    {
        public DateTime statusBegining;
        public DateTime statusEnd;
        [Key]
        public string statusName; //?? typ???

        public EmployeeStatus(DateTime beginTime, DateTime endTime, string name)
        {
            this.statusBegining = beginTime;
            this.statusEnd = endTime;
            this.statusName = name;
        }
    }
}
