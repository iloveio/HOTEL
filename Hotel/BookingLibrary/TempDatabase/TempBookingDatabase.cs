using System.Collections.Generic;

namespace BookingLibrary.TempDatabase
{
    public class TempBookingDatabase
    {
        public TempBookingDatabase()
        {
            Users = new List<User>
            {
                new User {Name = "Zdzisiu", SelectedRoom = 201, Surname = "Kowalksi"},
                new User {Name = "Marek", SelectedRoom = 201, Surname = "Nowam"},
                new User {Name = "Krystina", SelectedRoom = 201, Surname = "Szaba"},
                new User {Name = "Abelard", SelectedRoom = 201, Surname = "Szama"},
                new User {Name = "Konstantyn", SelectedRoom = 201, Surname = "Zdrój"}
            };

            Rooms = new List<Room>
            {
                new Room {Id = 101, FloorNumber = 1, Size = 4, IsEmpty = true},
                new Room {Id = 145, FloorNumber = 1, Size = 3, IsEmpty = true},
                new Room {Id = 201, FloorNumber = 2, Size = 4, IsEmpty = false},
                new Room {Id = 245, FloorNumber = 2, Size = 3, IsEmpty = true},
                new Room {Id = 301, FloorNumber = 3, Size = 4, IsEmpty = false},
                new Room {Id = 345, FloorNumber = 3, Size = 3, IsEmpty = false},
                new Room {Id = 401, FloorNumber = 4, Size = 4, IsEmpty = false},
                new Room {Id = 445, FloorNumber = 4, Size = 3, IsEmpty = false},
                new Room {Id = 501, FloorNumber = 5, Size = 4, IsEmpty = true},
                new Room {Id = 545, FloorNumber = 5, Size = 3, IsEmpty = false}
            };
        }

        public List<User> Users { get; set; }
        public List<Room> Rooms { get; set; }
    }
}