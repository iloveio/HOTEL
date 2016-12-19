////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	EmployeeStatus.cs
//
// summary:	Implements the employee status class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResourcesLib
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   An employee status. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class EmployeeStatus
    {
        /// <summary>   The status begining Date/Time. </summary>
        private DateTime statusBegining;
        /// <summary>   The status end Date/Time. </summary>
        private DateTime statusEnd;
        /// <summary>   Name of the status. </summary>
        EmployeeStatusName statusName;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="statusName">       The name of the status. </param>
        /// <param name="statusBegining">   The status begining. </param>
        /// <param name="statusEND">        The status end. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public EmployeeStatus(EmployeeStatusName statusName, DateTime statusBegining, DateTime statusEND)
        {
            this.statusName = statusName;
            this.statusBegining = statusBegining;
            this.statusEnd = statusEND;

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the Date/Time of the status begining. </summary>
        ///
        /// <value> The status begining. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public DateTime StatusBegining
        {
            get
            {
                return this.statusBegining;
            }
            set
            {
                statusBegining = value;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the Date/Time of the status end. </summary>
        ///
        /// <value> The status end. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public DateTime StatusEnd
        {
            get
            {
                return this.statusEnd;
            }
            set
            {
                statusEnd = value;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the name of the status. </summary>
        ///
        /// <value> The name of the status. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public EmployeeStatusName StatusName
        {
            get
            {
                return this.statusName;
            }
            set
            {
                statusName = value;
            }
        }

    }
}