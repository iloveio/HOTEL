////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	User.cs
//
// summary:	Implements the user class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace HumanResourcesLib
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   An user. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    [DataContract]
    public abstract partial class User
    {
        /// <summary>   The name. </summary>
        [DataMember]
        protected string name;
        /// <summary>   The person's last name. </summary>
        [DataMember]
        protected string lastName;
        /// <summary>   The identifier. </summary>
        [DataMember]
        protected uint id;
        /// <summary>   The user's login. </summary>
        [DataMember]
        protected string login;
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the login property. </summary>
        ///
        /// <value> The login property. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        /// <summary>   The user's password. </summary>
        [DataMember]
        protected string password;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the Password property. </summary>
        ///
        /// <value> The Password property. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public User()
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="name">     The name. </param>
        /// <param name="lastName"> The person's last name. </param>
        /// <param name="id">       The identifier. </param>
        /// <param name="login">       The user's login. </param>
        /// <param name="password">       The user's password. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public User(string name, string lastName, uint id, string login, string password)
        {
            this.id = id;
            this.lastName = lastName;
            this.name = name;
            this.login = login;
            this.password = password;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the name property. </summary>
        ///
        /// <value> The name property. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string nameProperty { get { return name; } set { name = value; } }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the last name property. </summary>
        ///
        /// <value> The last name property. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string lastNameProperty { get { return lastName; } set { lastName = value; } }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier property. </summary>
        ///
        /// <value> The identifier property. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public uint idProperty { get { return id; } set { } }

    }
}