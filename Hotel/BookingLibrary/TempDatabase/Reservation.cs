using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.TempDatabase
{
    public class Reservation
    {
        public Reservation(uint roomId, uint userId, DateTime reservationStart, DateTime reservationEnd)
        {
            RoomId = roomId;
            UserId = userId;
            ReservationStart = reservationStart;
            ReservationEnd = reservationEnd;
        }

        public uint RoomId { get; set; }
        public uint UserId { get; set; }
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }
    }
}
