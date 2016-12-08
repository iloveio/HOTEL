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
                roomsList = query.ToList<Room>();
            }
        }
        public void FillDataWithAllGuests()
        {
            using (var db = new RoomBookingContext())
            {
                var query = from b in db.Guests
                            select b;
                guestsList = query.ToList<Guest>();
            }
        }

        public void AddNewGuest(Guest guest)
        {
            using (var db = new RoomBookingContext())
                db.Guests.Add(guest);
        }
        public void DeleteGuestByObject(Guest guest)
        {
            using (var db = new RoomBookingContext())
                db.Guests.Remove(guest);
        }

        public void AddGuestToRoom(Guest guest, Room room)
        {
            if(room.CurrentGuest == null)
            {
                using (var db = new RoomBookingContext())
                    //db.Rooms.Find()
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
