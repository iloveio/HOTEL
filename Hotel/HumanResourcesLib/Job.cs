using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderTest
{
    public class Job
    {
        private Supervisor jobSupervisor;
        private string jobDescription;
        private DateTime deadline;

        public Job(Supervisor jobSupervisor, string jobDescription, DateTime deadline)
        {
            this.deadline = deadline;
            this.jobDescription = jobDescription;
            this.jobSupervisor = jobSupervisor;
        }

        public Job(Supervisor jobSupervisor, string jobDescription)
        {
            this.jobDescription = jobDescription;
            this.jobSupervisor = jobSupervisor;
        }
    }
}