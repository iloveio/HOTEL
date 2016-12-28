using System;
using System.Collections.Generic;

namespace BookingLibrary.TempDatabase
{
    public class TempBookingDatabase
    {
        public TempBookingDatabase()
        {
            Guests = new List<Guest>
            {
                //new Guest {Name = "Zdzisiu", PESEL = 123, Surname = "Kowalksi"},
                //new Guest {Name = "Marek", PESEL = 22342201, Surname = "Nowam"},
                //new Guest {Name = "Krystina", PESEL = 24324401, Surname = "Szaba"},
                //new Guest {Name = "Abelard", PESEL = 2023421131, Surname = "Szama"},
                //new Guest {Name = "Konstantyn", PESEL = 232435201, Surname = "Zdrój"}
            };

            Rooms = new List<Room>
            {
                new Room {RoomNumber = 101, FloorNumber = 1, Size = 4, NumberOfRooms = 1 , HasOutlook = true, IsBalcony =true , IsTv = false },
                new Room {RoomNumber = 145, FloorNumber = 1, Size = 3, NumberOfRooms = 4, HasOutlook =false , IsBalcony =false , IsTv =false},
                new Room {RoomNumber = 201, FloorNumber = 2, Size = 4, NumberOfRooms = 3, HasOutlook = true, IsBalcony = true, IsTv =true},
                new Room {RoomNumber = 245, FloorNumber = 2, Size = 3, NumberOfRooms = 2, HasOutlook =false , IsBalcony = true, IsTv =false},
                new Room {RoomNumber = 301, FloorNumber = 3, Size = 4, NumberOfRooms = 2, HasOutlook = true, IsBalcony = false, IsTv =false},
                new Room {RoomNumber = 345, FloorNumber = 3, Size = 3, NumberOfRooms = 2, HasOutlook = false, IsBalcony =false , IsTv =true},
                new Room {RoomNumber = 401, FloorNumber = 4, Size = 4, NumberOfRooms = 3, HasOutlook = true, IsBalcony = false, IsTv =true},
                new Room {RoomNumber = 445, FloorNumber = 4, Size = 3, NumberOfRooms = 1, HasOutlook = true, IsBalcony = true, IsTv =false},
                new Room {RoomNumber = 501, FloorNumber = 5, Size = 4, NumberOfRooms = 4, HasOutlook =false , IsBalcony = false, IsTv =false},
                new Room {RoomNumber = 545, FloorNumber = 5, Size = 3, NumberOfRooms = 1, HasOutlook = true, IsBalcony = true, IsTv =true}
            };
            Reservations = new List<Reservation>
            {
                new Reservation (145,123,DateTime.Today,DateTime.Today.AddDays(5)),
                new Reservation (145,123,DateTime.Today.AddDays(8),DateTime.Today.AddDays(13))
            };
        }

        public List<Guest> Guests { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}