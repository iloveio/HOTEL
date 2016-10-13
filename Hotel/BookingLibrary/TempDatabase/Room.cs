﻿using System;

namespace BookingLibrary.TempDatabase
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public int FloorNumber { get; set; }
        public int Size { get; set; }
        public int NumberOfRooms { get; set; }
        public bool IsTv { get; set; }
        public bool IsBathroom { get; set; }
        public bool IsBalcony { get; set; }
        public bool IsEmpty { get; set; }
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }
        public int CurrentClientId { get; set; }
        public int Id { get; set; }
    }
}