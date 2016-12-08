using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database
{
    public class RoomBookingManager
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
            {
                db.Guests.Add(guest);
                db.SaveChanges();
            }
            FillDataWithAllGuests();
        }
        public void DeleteGuestByObject(Guest guest)
        {
            using (var db = new RoomBookingContext())
            {
                db.Guests.Remove(guest);
                db.SaveChanges();
            }
            FillDataWithAllGuests();
        }

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
