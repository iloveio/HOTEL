////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	EmployeeStatusName.cs
//
// summary:	Implements the employee status name class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResourcesLib
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Values that represent employee status names. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public enum EmployeeStatusName
    {
        /// <summary>   An enum constant representing the working option. </summary>
        Working,
        /// <summary>   An enum constant representing the sick leave option. </summary>
        SickLeave,
        /// <summary>   An enum constant representing the maternity or paternity leave option. </summary>
        MaternityOrPaternityLeave,
        /// <summary>   An enum constant representing the extra ordinary leave option. </summary>
        ExtraOrdinaryLeave,
        /// <summary>   An enum constant representing the erned leave option. </summary>
        ErnedLeave,
        /// <summary>   An enum constant representing the half pay leave option. </summary>
        HalfPayLeave
    }

}