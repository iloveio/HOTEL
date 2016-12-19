////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Database\Staff\EmployeeStatus.cs
//
// summary:	Implements the employee status class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Database.Staff
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   An employee status. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class EmployeeStatus
    {
        /// <summary>   The status begining Date/Time. </summary>
        public DateTime statusBegining;
        /// <summary>   The status end Date/Time. </summary>
        public DateTime statusEnd;
        /// <summary>   ?? typ??? </summary>
        [Key]
        public string statusName;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="beginTime">    The begin time. </param>
        /// <param name="endTime">      The end time. </param>
        /// <param name="name">         The name. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public EmployeeStatus(DateTime beginTime, DateTime endTime, string name)
        {
            this.statusBegining = beginTime;
            this.statusEnd = endTime;
            this.statusName = name;
        }
    }
}
