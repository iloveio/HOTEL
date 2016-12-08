using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database.Staff
{
    class Job
    {
        public virtual Supervisor jobSupervisor { get; set; }
        public string jobDescription { get; set; }
        public DateTime deadline { get; set; }
    }
}
