﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Database\Transportation\Transportation.cs
//
// summary:	Implements the transportation class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HumanResourcesLib;

namespace Hotel.Database.Transportation
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A transportation. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class Transportation
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="emp">  The emp. </param>
        /// <param name="date"> Gets or sets the Date/Time of the date. </param>
        /// <param name="desc"> The description. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public Transportation()
        {

        }
        public Transportation(Employee emp, DateTime date, string desc)
        {
            employee = emp;
            this.date = date;
            description = desc;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the employee. </summary>
        ///
        /// <value> The employee. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public virtual Employee employee { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the Date/Time of the date. </summary>
        ///
        /// <value> The date. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public DateTime date { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the description. </summary>
        ///
        /// <value> The description. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [Key]
        public string description { get; set; }

    }
}
