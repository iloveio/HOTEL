using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.TempDatabase
{
    public class TempBookingDatabase
    {
        public List<User> Users { get; set; }
        public List<Room> Rooms { get; set; }

        public TempBookingDatabase()
        {
            Users = new List<User>
            {
                new User() {Name = "Zdzisiu", SelectedRoom = 201, Surname = "Kowalksi"},
                new User() {Name = "Marek", SelectedRoom = 201, Surname = "Nowam"},
                new User() {Name = "Krystina", SelectedRoom = 201, Surname = "Szaba"},
                new User() {Name = "Abelard", SelectedRoom = 201, Surname = "Szama"},
                new User() {Name = "Konstantyn", SelectedRoom = 201, Surname = "Zdrój"}
            };

            Rooms = new List<Room>
            {
                new Room() {ID = 122, FloorNumber = 1, Size = 78 },
                new Room() {ID = 2452, FloorNumber = 2, Size = 234 },
                new Room() {ID = 2, FloorNumber = 5, Size = 223 },
                new Room() {ID = 45, FloorNumber = 0, Size = 1221 },
                new Room() {ID = 23, FloorNumber = 4, Size = 443 },
            };
        }
    }
}
