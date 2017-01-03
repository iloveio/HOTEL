////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	SupervisorFactory.cs
//
// summary:	Implements the supervisor factory class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResourcesLib;

namespace HumanResourcesLib
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A supervisor factory. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class SupervisorFactory : IEmployeeFactory
    {
        /// <summary>   The factory. </summary>
        /// <summary>   The employees. </summary>
        List<Employee> employees;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="employees">        The employees. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public SupervisorFactory(List<Employee> employees) 
        {
            this.employees = employees;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Creates an employee. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="name">             The name. </param>
        /// <param name="lastName">         The person's last name. </param>
        /// <param name="id">               The identifier. </param>
        /// <param name="employeeStatus">   The employee status. </param>
        /// <param name="wage">             The wage. </param>
        /// <param name="jobs">             The jobs. </param>
        /// <param name="login">       The user's login. </param>
        /// <param name="password">       The user's password. </param>
        /// 
        /// <returns>   The new employee. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Employee CreateEmployee(string name, string lastName, uint id, EmployeeStatus employeeStatus, float wage, List<Job> jobs, string login, string password)
        {
            return new Supervisor(name, lastName, id, employeeStatus, this.employees, wage, jobs, login, password);
        }
    }
}