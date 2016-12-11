using System;
using System.Collections.Generic;
using System.Linq;
using BookingLibrary.TempDatabase;
using Hotel.Database;
using Room = Hotel.Database.Room;

namespace BookingApp.Model
{
    //A class responsible for exchange information beetwen database and our module controllers
    public class ModelController
    {
        private static ModelController instance;
        private readonly TempBookingDatabase tempBookingDatabase;

        private readonly RoomBookingManager roomBookingManager;

        private ModelController()
        {
            Name = "Dupa";
            Surname = "Dupalski";
            SelectedRoom = 6;

            roomBookingManager = new RoomBookingManager();
            //tempBookingDatabase = new TempBookingDatabase();
        }

        public static ModelController Instance => instance ?? (instance = new ModelController());

        public string Name { get; set; }
        public string Surname { get; set; }
        public int SelectedRoom { get; set; }

        public Guest GetUser()
        {
            // --- TEMPORARY SOLUTION ---- //
            //return tempBookingDatabase.Users[new Random().Next(0, tempBookingDatabase.Users.Count)];
            return null;
        }

        public List<Room> GetRooms()
        {
            // --- TEMPORARY SOLUTION ---- //
            return roomBookingManager.GetRoomsList();
        }

        public Room GetRoom(int id)
        {
            return (from r in roomBookingManager.GetRoomsList()
                    where r.RoomNumber == id
                    select r).First();
        }

        public void CreateReservation(uint roomId, uint userId, DateTime reservationStart, DateTime reservationEnd)
        {
            tempBookingDatabase.Reservations.Add(new Reservation(roomId, userId, reservationStart, reservationEnd));
        }

        public List<Reservation> GetReservationsForSelectedRoom(uint id)
        {
            return (from r in tempBookingDatabase.Reservations where r.RoomId == id select r).ToList();
        }
    }
}