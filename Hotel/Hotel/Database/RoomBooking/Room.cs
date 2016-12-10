using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Database
{
    public class Room
    {
        [Key]
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

        public Room(int number, int floor, int numberofrooms, bool tv, bool balcony, bool bathroom, bool empty, Guest currentGuest, DateTime startTime, DateTime endTime)
        {
            this.RoomNumber = number;
            this.FloorNumber = floor;
            this.NumberOfRooms = numberofrooms;
            IsTv = tv;
            IsBalcony = balcony;
            IsBathroom = bathroom;
            IsEmpty = empty;
            CurrentGuest = currentGuest;
            ReservationEnd = endTime;
            ReservationStart = startTime;
        }
    }
}
