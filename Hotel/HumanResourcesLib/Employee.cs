////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Employee.cs
//
// summary:	Implements the employee class
////////////////////////////////////////////////////////////////////////////////////////////////////

using HumanResourcesLib;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HumanResourcesLib
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   An employee. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    [DataContract]
    public abstract partial class Employee : User
    {
        /// <summary>   The jobs. </summary>
        [DataMember]
        protected List<Job> jobs;
        /// <summary>   The employee status. </summary>
        [DataMember]
        protected EmployeeStatus employeeStatus;
        /// <summary>   The wage. </summary>
        [DataMember]
        protected float wage;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="name">     The name. </param>
        /// <param name="lastName"> The person's last name. </param>
        /// <param name="id">       The identifier. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Employee(string name, string lastName, uint id) :base(name,lastName,id)
        {

        }
        // override object.Equals

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determines whether the specified object is equal to the current object. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="obj">  The object to compare with the current object. </param>
        ///
        /// <returns>
        /// true if the specified object  is equal to the current object; otherwise, false.
        /// </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public override bool Equals(object obj)
        {

            Employee empObj = obj as Employee;
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return id.Equals(obj);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Serves as the default hash function. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <returns>   A hash code for the current object. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public override int GetHashCode()
        {
            
            return this.id.GetHashCode();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="name">             The name. </param>
        /// <param name="lastName">         The person's last name. </param>
        /// <param name="id">               The identifier. </param>
        /// <param name="employeeStatus">   The employee status. </param>
        /// <param name="wage">             The wage. </param>
        /// <param name="jobs">             The jobs. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Employee(string name,string lastName,uint id,EmployeeStatus employeeStatus, float wage, List<Job> jobs)
            :base(name,lastName,id)
        {
            this.employeeStatus = employeeStatus;
            this.wage = wage;
            this.jobs = jobs;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the employee status. </summary>
        ///
        /// <value> The employee status. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public EmployeeStatus EmployeeStatus
        {
            get
            {
                return this.employeeStatus;
            }
            
            set
            {
                this.employeeStatus = value;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the jobs. </summary>
        ///
        /// <value> The jobs. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<Job> Jobs
        {
            get
            {
                return this.jobs;
            }
            set
            {
                this.jobs = value;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the wage. </summary>
        ///
        /// <value> The wage. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public float Wage
        {
            get
            {
                return this.wage;
            }
            set
            {
                this.wage = value;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the shorten jobs property. </summary>
        ///
        /// <value> The shorten jobs property. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string shortenJobsProperty { get { if (jobs.Count > 0) { return "have some tasks"; } else { return "no tasks"; } } set { } }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the jobs property. </summary>
        ///
        /// <value> The jobs property. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<Job> jobsProperty { get { return jobs; } set { jobs = value; } }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the employee status property. </summary>
        ///
        /// <value> The employee status property. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string employeeStatusProperty { get { return employeeStatus.StatusName.ToString()+":  from: "+employeeStatus.StatusBegining.ToShortDateString()+" to: "+employeeStatus.StatusEnd.ToShortDateString(); } set { } }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the name of the employee status. </summary>
        ///
        /// <value> The name of the employee status. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string employeeStatusName { get { return employeeStatus.StatusName.ToString(); } set { } }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the employee status date from. </summary>
        ///
        /// <value> The employee status date from. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public System.DateTime employeeStatusDateFrom { get { return employeeStatus.StatusBegining; } set { } }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the employee status date to. </summary>
        ///
        /// <value> The employee status date to. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public System.DateTime employeeStatusDateTo { get { return employeeStatus.StatusEnd; } set { } }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the wage property. </summary>
        ///
        /// <value> The wage property. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string wageProperty { get { return wage.ToString(); } set { } }


    }
}