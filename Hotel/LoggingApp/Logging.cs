////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Logging.cs
//
// summary:	Implements the logging class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingApp
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A logging. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class Logging
    {
        /// <summary>   The login. </summary>
        private string login;
        /// <summary>   The password. </summary>
        private string password;
        /// <summary>   The person's first name. </summary>
        private string firstName;
        /// <summary>   The person's last name. </summary>
        private string lastName;
        /// <summary>   The birth date. </summary>
        private string birthDate;
        /// <summary>   The phone number. </summary>
        private int phoneNumber;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the login. </summary>
        ///
        /// <value> The login. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the password. </summary>
        ///
        /// <value> The password. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the person's first name. </summary>
        ///
        /// <value> The name of the first. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the person's last name. </summary>
        ///
        /// <value> The name of the last. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the birth date. </summary>
        ///
        /// <value> The birth date. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the phone number. </summary>
        ///
        /// <value> The phone number. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public int PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }
    }
}