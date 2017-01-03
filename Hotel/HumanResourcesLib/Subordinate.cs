////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Subordinate.cs
//
// summary:	Implements the subordinate class
////////////////////////////////////////////////////////////////////////////////////////////////////

using HumanResourcesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace HumanResourcesLib
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A subordinate. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    [DataContract]
    public partial class Subordinate : Employee
    {
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
        /// <param name="login">       The user's login. </param>
        /// <param name="password">       The user's password. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Subordinate(string name, string lastName, uint id, EmployeeStatus employeeStatus, float wage, List<Job> jobs, string login, string password) 
            : base(name, lastName, id, employeeStatus, wage, jobs,login,password)
        {
            
        }

    }

}