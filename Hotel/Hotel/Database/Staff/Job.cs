using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Database.Staff
{
    public class Job
    {
        public virtual Supervisor jobSupervisor { get; set; }
        [Key]
        public string jobDescription { get; set; }
        public DateTime deadline { get; set; }

        public Job(Supervisor supervisor, string desc, DateTime deadline)
        {
            this.jobSupervisor = supervisor;
            this.jobDescription = desc;
            this.deadline = deadline;
        }
    }
}
