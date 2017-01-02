////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Director.cs
//
// summary:	Implements the director class
////////////////////////////////////////////////////////////////////////////////////////////////////

using HumanResourcesLib;

/// <summary>   The system. </summary>
using System;
/// <summary>   The system. collections. generic. </summary>
using System.Collections.Generic;
/// <summary>   The system. linq. </summary>
using System.Linq;
/// <summary>   The system. text. </summary>
using System.Text;
using System.Runtime.Serialization;


////////////////////////////////////////////////////////////////////////////////////////////////////
// namespace: HumanResourcesLib
//
// summary:	.
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace HumanResourcesLib
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A director. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    [DataContract]
    public partial class Director : User, IManager
    {
        /// <summary>   The supervisors. </summary>
        [DataMember]
        private List<Employee> supervisors;
        /// <summary>   The employee factory. </summary>
        [IgnoreDataMember]
        IEmployeeFactory employeeFactory;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="name">         The name. </param>
        /// <param name="lastName">     The person's last name. </param>
        /// <param name="id">           The identifier. </param>
        /// <param name="supervisors">  The supervisors. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Director()
        {

        }

        public Director(string name, string lastName, uint id,List<Employee> supervisors) : base(name, lastName, id)
        {
            this.supervisors = supervisors;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Instantiate director. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="name">         The name. </param>
        /// <param name="lastName">     The person's last name. </param>
        /// <param name="id">           The identifier. </param>
        /// <param name="supervisors">  The supervisors. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the get instance. </summary>
        ///
        /// <exception cref="InvalidOperationException">    Thrown when the requested operation is
        ///                                                 invalid. </exception>
        ///
        /// <value> The get instance. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////



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

        public void FireAnEmployee(Employee employee)
        {
            this.supervisors.Remove(employee);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the get factory. </summary>
        ///
        /// <value> The get factory. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public HumanResourcesLib.IEmployeeFactory GetFactory
        {
            get
            {
                return this.employeeFactory;
            }
            set
            {
                this.employeeFactory = value;
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
            this.employeeFactory = new SupervisorFactory(new List<Employee>());
            Employee tmp = this.GetFactory.CreateEmployee(name, lastName, id, employeeStatus, wage, jobs);
            this.supervisors.Add(tmp);
            return tmp;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the supervisors. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <returns>   The supervisors. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<Employee> GetSupervisors()
        {
            return supervisors;
        }


    }
}