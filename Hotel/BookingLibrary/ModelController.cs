////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	ModelController.cs
//
// summary:	Implements the model controller class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using BookingLibrary.TempDatabase;

namespace BookingLibrary
{
    //A class responsible for exchange information beetwen database and our module controllers

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A controller for handling models. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class ModelController
    {
        /// <summary>   The instance. </summary>
        private static ModelController instance;
        /// <summary>   The temporary booking database. </summary>
        private readonly TempBookingDatabase tempBookingDatabase;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Constructor that prevents a default instance of this class from being created.
        /// </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private ModelController()
        {
            Name = "Dupa";
            Surname = "Dupalski";
            SelectedRoom = 6;

            tempBookingDatabase = new TempBookingDatabase();
        }

        /// <summary>   The instance. </summary>
        public static ModelController Instance => instance ?? (instance = new ModelController());

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
        /// <summary>   Gets or sets the selected room. </summary>
        ///
        /// <value> The selected room. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public int SelectedRoom { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the user. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <returns>   The user. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public User GetUser()
        {
            // --- TEMPORARY SOLUTION ---- //
            return tempBookingDatabase.Users[new Random().Next(0, tempBookingDatabase.Users.Count)];
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the rooms. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <returns>   The rooms. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<Room> GetRooms()
        {
            // --- TEMPORARY SOLUTION ---- //
            return tempBookingDatabase.Rooms;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets a room. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The room. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Room GetRoom(int id)
        {
            return (from r in tempBookingDatabase.Rooms
                where r.RoomNumber == id
                select r).First();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Creates a reservation. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="roomId">           Identifier for the room. </param>
        /// <param name="userId">           Identifier for the user. </param>
        /// <param name="reservationStart"> The reservation start Date/Time. </param>
        /// <param name="reservationEnd">   The reservation end Date/Time. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void CreateReservation(uint roomId, uint userId, DateTime reservationStart, DateTime reservationEnd)
        {
            tempBookingDatabase.Reservations.Add(new Reservation(roomId,userId,reservationStart,reservationEnd));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets reservations for selected room. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The reservations for selected room. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<Reservation> GetReservationsForSelectedRoom(uint id)
        {
            return (from r in tempBookingDatabase.Reservations where r.RoomId == id select r).ToList();
        }
    }
}