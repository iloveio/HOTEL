using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database
{
    public class Room
    {
        public int RoomNumber { set; get; }
        public int FloorNumber { set; get; }
        public int NumberOfRooms { set; get; }
        public bool IsTv { set; get; }
        public bool IsBalcony { set; get; }
        public bool IsBathroom { set; get; }
        public bool IsEmpty { set; get; }
        public virtual Guest CurrentGuest { set; get; }
        public DateTime ReservationStart { set; get; }
        public DateTime ReservationEnd { set; get; }
    }
}
