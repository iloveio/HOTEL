﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	SubordinateFactory.cs
//
// summary:	Implements the subordinate factory class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResourcesLib;


namespace HumanResourcesLib
{ 
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A subordinate factory. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class SubordinateFactory : IEmployeeFactory
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Creates an employee. </summary>
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
        /// <returns>   The new employee. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Employee CreateEmployee(string name, string lastName, uint id, EmployeeStatus employeeStatus, float wage, List<Job> jobs, string login, string password, Postion position)
        {
            return new Subordinate(name, lastName, id, employeeStatus, wage, jobs, login, password, position);
        }
    }
}