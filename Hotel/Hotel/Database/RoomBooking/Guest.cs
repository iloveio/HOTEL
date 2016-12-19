﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Database\RoomBooking\Guest.cs
//
// summary:	Implements the guest class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Database
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A guest. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class Guest
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the pesel. </summary>
        ///
        /// <value> The pesel. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [Key]
        public int PESEL { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the name. </summary>
        ///
        /// <value> The name. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Name { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the person's surname. </summary>
        ///
        /// <value> The surname. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Surname { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the place of birth. </summary>
        ///
        /// <value> The place of birth. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string PlaceOfBirth { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="pesel">        The pesel. </param>
        /// <param name="name">         The name. </param>
        /// <param name="surname">      The person's surname. </param>
        /// <param name="placeofbirth"> The placeofbirth. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Guest(int pesel, string name, string surname, string placeofbirth)
        {
            this.PESEL = pesel;
            this.Name = name;
            this.Surname = surname;
            this.PlaceOfBirth = placeofbirth;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the name of the full. </summary>
        ///
        /// <value> The name of the full. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string FullName
        {
            get
            {
                return Surname + " " + Name;
            }
        }
    }
}
