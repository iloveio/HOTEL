////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Job.cs
//
// summary:	Implements the job class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
namespace HumanResourcesLib
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A job. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    [DataContract]
    public class Job
    {
        /// <summary>   The job supervisor. </summary>
        [DataMember]
        private Supervisor jobSupervisor;
        /// <summary>   Information describing the job. </summary>
        [DataMember]
        private string jobDescription;
        /// <summary>   The start date. </summary>
        [DataMember]
        private DateTime startDate;
        /// <summary>   The deadline Date/Time. </summary>
        [DataMember]
        private DateTime deadline;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="jobSupervisor">    The job supervisor. </param>
        /// <param name="jobDescription">   Information describing the job. </param>
        /// <param name="startDate">        The start date. </param>
        /// <param name="deadline">         The deadline. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Job(Supervisor jobSupervisor, string jobDescription,DateTime startDate, DateTime deadline)
        {
            this.startDate = startDate;
            this.deadline = deadline;
            this.jobDescription = jobDescription;
            this.jobSupervisor = jobSupervisor;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="jobDescription">   Information describing the job. </param>
        /// <param name="startDate">        The start date. </param>
        /// <param name="deadline">         The deadline. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Job(string jobDescription, DateTime startDate, DateTime deadline)
        {
            this.startDate = startDate;
            this.deadline = deadline;
            this.jobDescription = jobDescription;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="jobSupervisor">    The job supervisor. </param>
        /// <param name="jobDescription">   Information describing the job. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Job(Supervisor jobSupervisor, string jobDescription)
        {
            this.jobDescription = jobDescription;
            this.jobSupervisor = jobSupervisor;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the description. </summary>
        ///
        /// <value> The description. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Description { get { return jobDescription; } set { } }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the start date. </summary>
        ///
        /// <value> The start date. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string StartDate { get { return startDate.ToShortDateString(); } set { } }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the deadline. </summary>
        ///
        /// <value> The deadline. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Deadline { get { return deadline.ToShortDateString(); } set { } }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the name of the job supervisor. </summary>
        ///
        /// <value> The name of the job supervisor. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string JobSupervisorName { get { return jobSupervisor.nameProperty + "  " + jobSupervisor.lastNameProperty; } set { } }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the job supervisor. </summary>
        ///
        /// <value> The job supervisor. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Supervisor JobSupervisor { get { return jobSupervisor; } set { } }
    }
}