using System;
using System.Collections.Generic;
using System.Linq;
using BookingLibrary.TempDatabase;

namespace BookingLibrary
{
    //A class responsible for exchange information beetwen database and our module controllers
    public class ModelController
    {
        private static ModelController instance;
        private readonly TempBookingDatabase tempBookingDatabase;

        private ModelController()
        {
            Name = "Dupa";
            Surname = "Dupalski";
            SelectedRoom = 6;

            tempBookingDatabase = new TempBookingDatabase();
        }

        public static ModelController Instance => instance ?? (instance = new ModelController());

        public string Name { get; set; }
        public string Surname { get; set; }
        public int SelectedRoom { get; set; }

        public User GetUser()
        {
            // --- TEMPORARY SOLUTION ---- //
            return tempBookingDatabase.Users[new Random().Next(0, tempBookingDatabase.Users.Count)];
        }

        public List<Room> GetRooms()
        {
            // --- TEMPORARY SOLUTION ---- //
            return tempBookingDatabase.Rooms;
        }

        public Room GetRoom(int id)
        {
            return (from r in tempBookingDatabase.Rooms
                where r.Id == id
                select r).First();
        }
    }
}