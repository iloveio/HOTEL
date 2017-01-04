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
        [IgnoreDataMember]
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
        /// <param name="login">       The user's login. </param>
        /// <param name="password">       The user's password. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Supervisor(string name, string lastName, uint id, EmployeeStatus employeeStatus,List<Employee> employees, float wage, List<Job> jobs,IEmployeeFactory subrodinateFactory,
            string login, string password, Postion position) : 
            base(name, lastName, id, employeeStatus, wage, jobs,login,password,position)
        {
            this.subordinateFactory = subrodinateFactory;
            this.employees = employees;
        }
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
        /// <param name="login">       The user's login. </param>
        /// <param name="password">       The user's password. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public Supervisor(string name, string lastName, uint id, EmployeeStatus employeeStatus, List<Employee> employees, float wage, List<Job> jobs, string login, string password, Postion position) :
            base(name, lastName, id, employeeStatus, wage, jobs,login,password,position)
        {
           
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
        /// <param name="login">       The user's login. </param>
        /// <param name="password">       The user's password. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Supervisor(string name, string lastName, uint id, string login, string password) : base(name, lastName, id,login,password)
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

        public void FireAnEmployee(Employee employee)
        {
            this.employees.Remove(employee);

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
        /// <param name="position">       The employees's position. </param>
        /// <param name="wage">             The wage. </param>
        /// <param name="jobs">             The jobs. </param>
        /// <param name="login">       The user's login. </param>
        /// <param name="password">       The user's password. </param>
        /// 
        /// <returns>   An Employee. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Employee HireAnEmployee(string name, string lastName, uint id, EmployeeStatus employeeStatus, float wage, List<Job> jobs, string login, string password, Postion position)
        {
            this.subordinateFactory = new SubordinateFactory();
            Employee tmp = GetFactory.CreateEmployee(name, lastName, id, employeeStatus, wage, jobs,login,password, position);
            this.employees.Add(tmp);
            return tmp;
        }
    }
     
}