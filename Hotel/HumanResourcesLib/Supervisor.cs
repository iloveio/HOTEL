////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Supervisor.cs
//
// summary:	Implements the supervisor class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResourcesLib;
using System.Runtime.Serialization;
namespace HumanResourcesLib
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A supervisor. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    [DataContract]
    public partial class Supervisor : Employee, IManager
    {
        /// <summary>   The employees. </summary>
        [DataMember]
        protected List<Employee> employees;
        /// <summary>   The subordinate factory. </summary>
        [DataMember]
        protected IEmployeeFactory subordinateFactory;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="name">                 The name. </param>
        /// <param name="lastName">             The person's last name. </param>
        /// <param name="id">                   The identifier. </param>
        /// <param name="employeeStatus">       The employee status. </param>
        /// <param name="employees">            The employees. </param>
        /// <param name="wage">                 The wage. </param>
        /// <param name="jobs">                 The jobs. </param>
        /// <param name="subrodinateFactory">   The subrodinate factory. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Supervisor(string name, string lastName, uint id, EmployeeStatus employeeStatus,List<Employee> employees, float wage, List<Job> jobs,IEmployeeFactory subrodinateFactory) : 
            base(name, lastName, id, employeeStatus, wage, jobs)
        {
            this.subordinateFactory = subrodinateFactory;
            this.employees = employees;
        }

        //for testing

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="name">     The name. </param>
        /// <param name="lastName"> The person's last name. </param>
        /// <param name="id">       The identifier. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Supervisor(string name, string lastName, uint id) : base(name, lastName, id)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Check all subordinate status. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <returns>   A List&lt;EmployeeStatus&gt; </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<EmployeeStatus> CheckAllSubordinateStatus()
        {
            throw new NotImplementedException();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Fire an employee. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <returns>   An Employee. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Employee FireAnEmployee()
        {
            throw new NotImplementedException();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the get factory. </summary>
        ///
        /// <value> The get factory. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public IEmployeeFactory GetFactory
        {
            get
            {
                return this.subordinateFactory;
            }
            set
            {
                this.subordinateFactory = value;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Hire an employee. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="name">             The name. </param>
        /// <param name="lastName">         The person's last name. </param>
        /// <param name="id">               The identifier. </param>
        /// <param name="employeeStatus">   The employee status. </param>
        /// <param name="wage">             The wage. </param>
        /// <param name="jobs">             The jobs. </param>
        ///
        /// <returns>   An Employee. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Employee HireAnEmployee(string name, string lastName, uint id, EmployeeStatus employeeStatus, float wage, List<Job> jobs)
        {
            return GetFactory.CreateEmployee(name, lastName, id, employeeStatus, wage, jobs);
        }
    }
     
}