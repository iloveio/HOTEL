////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	model\modelcontroller.cs
//
// summary:	Implements the modelcontroller class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using Hotel.Database;

namespace BookingApp.Model
{
    //A class responsible for exchange information beetwen database and our module controllers

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A controller for handling models. </summary>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class ModelController
    {
        /// <summary>   The instance. </summary>
        private static ModelController instance;

        /// <summary>   Manager for room booking. </summary>
        private readonly RoomBookingManager roomBookingManager;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Constructor that prevents a default instance of this class from being created.
        /// </summary>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private ModelController()
        {
            SelectedRoomID = 0;
            roomBookingManager = new RoomBookingManager();
        }

        /// <summary>   The instance. </summary>
        public static ModelController Instance => instance ?? (instance = new ModelController());

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the selected room identifier. </summary>
        ///
        /// <value> The identifier of the selected room. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public uint SelectedRoomID { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the start date. </summary>
        ///
        /// <value> The start date. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public DateTime StartDate { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the end date. </summary>
        ///
        /// <value> The end date. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public DateTime EndDate { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets a guest. </summary>
        ///
        /// <param name="PESEL">    The pesel. </param>
        ///
        /// <returns>   The guest. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Guest GetGuest(uint PESEL)
        {
            // --- TEMPORARY SOLUTION ---- //

            return (from r in roomBookingManager.guestsList
                where r.PESEL == PESEL
                select r).First();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the rooms. </summary>
        ///
        /// <returns>   The rooms. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<Room> GetRooms()
        {
            // --- TEMPORARY SOLUTION ---- //
            //return roomBookingManager.GetRoomsList();
            return roomBookingManager.roomsList;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets a room. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The room. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Room GetRoom(int id)
        {
            //return (from r in roomBookingManager.GetRoomsList()
            //        where r.RoomNumber == id
            //        select r).First();
            return (from r in roomBookingManager.roomsList
                where r.RoomNumber == id
                select r).First();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Creates a reservation. </summary>
        ///
        /// <param name="roomId">           Identifier for the room. </param>
        /// <param name="userId">           Identifier for the user. </param>
        /// <param name="reservationStart"> The reservation start Date/Time. </param>
        /// <param name="reservationEnd">   The reservation end Date/Time. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void CreateReservation(uint roomId, uint userId, DateTime reservationStart, DateTime reservationEnd)
        {
            roomBookingManager.reservationList.Add(new Reservation(roomId, userId, reservationStart, reservationEnd));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Creates a reservation. </summary>
        ///
        /// <param name="PESEL">    The pesel. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void CreateReservation(uint PESEL)
        {
            roomBookingManager.reservationList.Add(new Reservation(SelectedRoomID, PESEL, StartDate, EndDate));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Creates a guest. </summary>
        ///
        /// <param name="pesel">        The pesel. </param>
        /// <param name="name">         The name. </param>
        /// <param name="surname">      The person's surname. </param>
        /// <param name="placeOfBirth"> The place of birth. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void CreateGuest(uint pesel, string name, string surname, string placeOfBirth)
        {
            Guest guest = new Guest(pesel, name, surname, placeOfBirth);
            roomBookingManager.guestsList.Add(guest);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Creates cleaning job. </summary>
        ///
        /// <param name="description">  The description. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void CreateCleaningJob(string description)
        {
            roomBookingManager.cleaningJobList.Add(new CleaningJob(GenerateCleaningJobID(), (int) SelectedRoomID,
                description));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets reservations for selected room. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The reservations for selected room. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<Reservation> GetReservationsForSelectedRoom(uint id)
        {
            return (from r in roomBookingManager.reservationList where r.RoomId == id select r).ToList();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Generates a cleaning job identifier. </summary>
        ///
        /// <returns>   The cleaning job identifier. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private long GenerateCleaningJobID()
        {
            var now = DateTime.Now;
            return Int64.Parse($"{SelectedRoomID}{now.Year}{now.Month}{now.Day}{now.Hour}{now.Minute}{now.Second}");
        }
    }
}