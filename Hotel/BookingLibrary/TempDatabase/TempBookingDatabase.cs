////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	TempDatabase\TempBookingDatabase.cs
//
// summary:	Implements the temporary booking database class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace BookingLibrary.TempDatabase
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A temporary booking database. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class TempBookingDatabase
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public TempBookingDatabase()
        {
            Users = new List<User>
            {
                new User {Name = "Zdzisiu", PESEL = 123, Surname = "Kowalksi"},
                new User {Name = "Marek", PESEL = 22342201, Surname = "Nowam"},
                new User {Name = "Krystina", PESEL = 24324401, Surname = "Szaba"},
                new User {Name = "Abelard", PESEL = 2023421131, Surname = "Szama"},
                new User {Name = "Konstantyn", PESEL = 232435201, Surname = "Zdrój"}
            };

            Rooms = new List<Room>
            {
                new Room {RoomNumber = 101, FloorNumber = 1, Size = 4},
                new Room {RoomNumber = 145, FloorNumber = 1, Size = 3},
                new Room {RoomNumber = 201, FloorNumber = 2, Size = 4},
                new Room {RoomNumber = 245, FloorNumber = 2, Size = 3},
                new Room {RoomNumber = 301, FloorNumber = 3, Size = 4},
                new Room {RoomNumber = 345, FloorNumber = 3, Size = 3},
                new Room {RoomNumber = 401, FloorNumber = 4, Size = 4},
                new Room {RoomNumber = 445, FloorNumber = 4, Size = 3},
                new Room {RoomNumber = 501, FloorNumber = 5, Size = 4},
                new Room {RoomNumber = 545, FloorNumber = 5, Size = 3}
            };
            Reservations = new List<Reservation>
            {
                new Reservation (145,123,DateTime.Today,DateTime.Today.AddDays(5)),
                new Reservation (145,123,DateTime.Today.AddDays(8),DateTime.Today.AddDays(13))
            };
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the users. </summary>
        ///
        /// <value> The users. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<User> Users { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the rooms. </summary>
        ///
        /// <value> The rooms. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<Room> Rooms { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the reservations. </summary>
        ///
        /// <value> The reservations. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<Reservation> Reservations { get; set; }
    }
}