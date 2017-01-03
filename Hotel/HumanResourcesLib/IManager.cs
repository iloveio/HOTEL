////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	IManager.cs
//
// summary:	Declares the IManager interface
////////////////////////////////////////////////////////////////////////////////////////////////////

using HumanResourcesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResourcesLib
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Interface for manager. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public interface IManager
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Hire an employee. </summary>
        ///
        /// <param name="name">             The name. </param>
        /// <param name="lastName">         The person's last name. </param>
        /// <param name="id">               The identifier. </param>
        /// <param name="employeeStatus">   The employee status. </param>
        /// <param name="wage">             The wage. </param>
        /// <param name="jobs">             The jobs. </param>
        /// <param name="login">       The user's login. </param>
        /// <param name="password">       The user's password. </param>
        /// <returns>   An Employee. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        Employee HireAnEmployee(string name, string lastName, uint id, EmployeeStatus employeeStatus, float wage, List<Job> jobs, string login, string password);

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Fire an employee. </summary>
        ///
        /// <returns>   An Employee. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        void FireAnEmployee(Employee employee);

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Check all subordinate status. </summary>
        ///
        /// <returns>   A List&lt;EmployeeStatus&gt; </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        List<EmployeeStatus> CheckAllSubordinateStatus();
    }
}