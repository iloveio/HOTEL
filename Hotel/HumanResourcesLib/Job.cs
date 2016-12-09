using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResourcesLib
{
    public class Job
    {
        private Supervisor jobSupervisor;
        private string jobDescription;
        private DateTime startDate;
        private DateTime deadline;

        public Job(Supervisor jobSupervisor, string jobDescription,DateTime startDate, DateTime deadline)
        {
            this.startDate = startDate;
            this.deadline = deadline;
            this.jobDescription = jobDescription;
            this.jobSupervisor = jobSupervisor;
        }

        public Job(string jobDescription, DateTime startDate, DateTime deadline)
        {
            this.startDate = startDate;
            this.deadline = deadline;
            this.jobDescription = jobDescription;
        }

        public Job(Supervisor jobSupervisor, string jobDescription)
        {
            this.jobDescription = jobDescription;
            this.jobSupervisor = jobSupervisor;
        }

        public string Description { get { return jobDescription; } set { } }
        public string StartDate { get { return startDate.ToShortDateString(); } set { } }
        public string Deadline { get { return deadline.ToShortDateString(); } set { } }
        public string JobSupervisorName { get { return jobSupervisor.nameProperty + "  " + jobSupervisor.lastNameProperty; } set { } }
        public Supervisor JobSupervisor { get { return jobSupervisor; } set { } }
    }
}