////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	IEmployeeFactory.cs
//
// summary:	Declares the IEmployeeFactory interface
////////////////////////////////////////////////////////////////////////////////////////////////////

using HumanResourcesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace HumanResourcesLib
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Interface for employee factory. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    
    public interface IEmployeeFactory
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Creates an employee. </summary>
        ///
        /// <param name="name">             The name. </param>
        /// <param name="lastName">         The person's last name. </param>
        /// <param name="id">               The identifier. </param>
        /// <param name="employeeStatus">   The employee status. </param>
        /// <param name="wage">             The wage. </param>
        /// <param name="jobs">             The jobs. </param>
        ///
        /// <returns>   The new employee. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        Employee CreateEmployee(string name, string lastName, uint id, EmployeeStatus employeeStatus, float wage, List<Job> jobs);
    }
}