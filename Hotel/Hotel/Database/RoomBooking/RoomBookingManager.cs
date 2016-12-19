////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Database\RoomBooking\RoomBookingManager.cs
//
// summary:	Implements the room booking manager class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Manager for room bookings. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class RoomBookingManager
    {
        /// <summary>   List of rooms. </summary>
        List<Room> roomsList;
        /// <summary>   List of guests. </summary>
        List<Guest> guestsList;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Fill data with all rooms. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void FillDataWithAllRooms()
        {
            using (var db = new RoomBookingContext())
            {
                var query = from b in db.Rooms
                            select b;
                roomsList = query.ToList<Room>();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Fill data with all guests. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void FillDataWithAllGuests()
        {
            using (var db = new RoomBookingContext())
            {
                var query = from b in db.Guests
                            select b;
                guestsList = query.ToList<Guest>();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Adds a new guest. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="guest">    The guest. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void AddNewGuest(Guest guest)
        {
            using (var db = new RoomBookingContext())
            {
                db.Guests.Add(guest);
                db.SaveChanges();
            }
            FillDataWithAllGuests();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Deletes the guest by object described by guest. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="guest">    The guest. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DeleteGuestByObject(Guest guest)
        {
            using (var db = new RoomBookingContext())
            {
                db.Guests.Remove(guest);
                db.SaveChanges();
            }
            FillDataWithAllGuests();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Adds a guest to room to 'room'. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="guest">    The guest. </param>
        /// <param name="room">     The room. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void AddGuestToRoom(Guest guest, Room room)
        {
            if(room.CurrentGuest == null)
            {
                using (var db = new RoomBookingContext())
                {
                    Room temp = db.Rooms.Find(room);
                    temp.CurrentGuest = guest;
                    db.SaveChanges();
                }
                FillDataWithAllRooms();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets rooms list. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <returns>   The rooms list. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<Room> GetRoomsList()
        {
            return roomsList;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets guests list. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <returns>   The guests list. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<Guest> GetGuestsList()
        {
            return guestsList;
        }
    }
}
