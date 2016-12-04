using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database
{
    class RoomBookingManager
    {
        List<Room> roomsList;
        List<Guest> guestsList;
        public void FillDataWithAllRooms()
        {
            using (var db = new RoomBookingContext())
            {
                var query = from b in db.Rooms
                            select b;

                foreach(var room in query)
                {
                    roomsList = query.ToList<Room>();
                }
            }
        }
        public void FillDataWithAllGuests()
        {
            using (var db = new RoomBookingContext())
            {
                var query = from b in db.Guests
                            select b;

                foreach (var guest in query)
                {
                    guestsList = query.ToList<Guest>();
                }
            }
        }
        public List<Room> GetRoomsList()
        {
            return roomsList;
        }
        public List<Guest> GetGuestsList()
        {
            return guestsList;
        }
    }
}
