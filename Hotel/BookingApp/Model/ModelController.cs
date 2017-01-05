using System;
using System.Collections.Generic;
using System.Linq;
using Hotel.Database;

namespace BookingApp.Model
{
    //A class responsible for exchange information beetwen database and our module controllers
    public class ModelController
    {
        private static ModelController instance;

        private readonly RoomBookingManager roomBookingManager;

        private ModelController()
        {
            SelectedRoomID = 0;
            roomBookingManager = new RoomBookingManager();
        }

        public static ModelController Instance => instance ?? (instance = new ModelController());

        public uint SelectedRoomID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public Guest GetGuest(uint PESEL)
        {
            // --- TEMPORARY SOLUTION ---- //

            return (from r in roomBookingManager.guestsList
                    where r.PESEL == PESEL
                    select r).First();
        }

        public List<Room> GetRooms()
        {
            // --- TEMPORARY SOLUTION ---- //
            //return roomBookingManager.GetRoomsList();
            return roomBookingManager.roomsList;
        }



        public Room GetRoom(int id)
        {
            //return (from r in roomBookingManager.GetRoomsList()
            //        where r.RoomNumber == id
            //        select r).First();
            return (from r in roomBookingManager.roomsList
                    where r.RoomNumber == id
                    select r).First();
        }

        public void CreateReservation(uint roomId, uint userId, DateTime reservationStart, DateTime reservationEnd)
        {
            roomBookingManager.reservationList.Add(new Reservation(roomId, userId, reservationStart, reservationEnd));
        }

        public void CreateReservation(uint PESEL)
        {
            roomBookingManager.reservationList.Add(new Reservation(SelectedRoomID, PESEL, StartDate, EndDate));
        }

        public void CreateGuest(uint pesel, string name, string surname, string placeOfBirth)
        {
            //Guest guest = new Guest(pesel, name, surname, placeOfBirth);
            //roomBookingManager.guestsList.Add(guest);
        }

        public void CreateCleaningJob(string description)
        {
            //TODO zamien na tworzenie w prawdziwej bazie
            //roomBookingManager.CleaningJobs.Add(new CleaningJob(GenerateCleaningJobID(),(int)//SelectedRoomID,description));
        }

        public List<Reservation> GetReservationsForSelectedRoom(uint id)
        {
            return (from r in roomBookingManager.reservationList where r.RoomId == id select r).ToList();
        }

        private long GenerateCleaningJobID()
        {
            var now = DateTime.Now;
            return Int64.Parse($"{SelectedRoomID}{now.Year}{now.Month}{now.Day}{now.Hour}{now.Minute}{now.Second}");
        }

    }
}