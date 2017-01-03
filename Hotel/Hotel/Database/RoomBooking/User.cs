﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	TempDatabase\User.cs
//
// summary:	Implements the user class
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Hotel.Database
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   An user. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class User
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the pesel. </summary>
        ///
        /// <value> The pesel. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public uint PESEL { get; set; }

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
    }
}