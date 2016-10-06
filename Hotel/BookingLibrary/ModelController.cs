using BookingLibrary.TempDatabase;
using System;
using System.Collections.Generic;

namespace BookingLibrary
{
    //A class responsible for exchange information beetwen database and our module controllers
    public class ModelController
    {
        private static ModelController _instance;
        private TempDatabase.TempBookingDatabase tempBookingDatabase;

        private ModelController()
        {
            Name = "Dupa";
            Surname = "Dupalski";
            SelectedRoom = 6;

            tempBookingDatabase = new TempDatabase.TempBookingDatabase();
        }

        public static ModelController Instance => _instance ?? (_instance = new ModelController());

        public string Name { get; set; }
        public string Surname { get; set; }
        public int SelectedRoom { get; set; }

        public User GetUser()
        {
            // --- TEMPORARY SOLUTION ---- //
            return tempBookingDatabase.Users[new Random().Next(0,tempBookingDatabase.Users.Count)];
        }
        public List<Room> GetRooms()
        {
            // --- TEMPORARY SOLUTION ---- //
            return tempBookingDatabase.Rooms;
        }
    }
}