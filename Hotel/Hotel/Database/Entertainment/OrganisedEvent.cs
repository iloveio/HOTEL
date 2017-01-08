﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	OrganisedEvent.cs
//
// summary:	Implements the organised event class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using Hotel.Database;
using HumanResourcesLib;
using System.Runtime.Serialization;

namespace Hotel.Database
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   An organised event. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    [DataContract]
    public class OrganisedEvent : Entertainment
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="name">                     The name. </param>
        /// <param name="price">                    The price. </param>
        /// <param name="maximumNumberOfGuests">    Gets or sets the maximum number of guests. </param>
        /// <param name="startDate">                Gets or sets the start date. </param>
        /// <param name="endDate">                  Gets or sets the end date. </param>
        /// <param name="supervisor">               Gets or sets the supervisor. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public OrganisedEvent(string name, float price, int maximumNumberOfGuests,
            DateTime startDate, DateTime endDate, Supervisor supervisor)
        {
            this.name = name;
            this.price = price;
            this.maximumNumberOfGuests = maximumNumberOfGuests;
            this.startDate = startDate.ToShortDateString();
            this.endDate = endDate.ToShortDateString();
            this.supervisor = supervisor;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the maximum number of guests. </summary>
        ///
        /// <value> The maximum number of guests. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        public int maximumNumberOfGuests { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the start date. </summary>
        ///
        /// <value> The start date. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        public string startDate { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the end date. </summary>
        ///
        /// <value> The end date. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        public string endDate { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the supervisor. </summary>
        ///
        /// <value> The supervisor. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        public Supervisor supervisor { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets a list of guests. </summary>
        ///
        /// <value> A List of guests. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DataMember]
        public List<Guest> guestList { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Adds a guest. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="guest">    The guest. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void addGuest(Guest guest)
        {
            guestList.Add(guest);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Removes the guest described by guest. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="guest">    The guest. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void removeGuest(Guest guest)
        {
            guestList.Remove(guest);
        }
    }
}
