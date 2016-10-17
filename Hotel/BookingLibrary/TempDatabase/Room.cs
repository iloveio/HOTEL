using System;

namespace BookingLibrary.TempDatabase
{
    public class Room
    {
        public uint RoomNumber { get; set; }
        public uint FloorNumber { get; set; }
        public uint Size { get; set; }
        public uint NumberOfRooms { get; set; }
        public bool IsTv { get; set; }
        public bool HasOutlook { get; set; }
        public bool IsBalcony { get; set; }
    }
}