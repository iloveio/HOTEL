using Hotel.Database;
using HumanResourcesLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Hotel.Database
{
    /// <summary>
    /// Class RoomBookingManager.
    /// </summary>
    public class RoomBookingManager
    {
        /// <summary>
        /// Gets or sets the rooms list.
        /// </summary>
        /// <value>The rooms list.</value>
        public List<Room> roomsList { get; set; }

        /// <summary>
        /// Gets or sets the guests list.
        /// </summary>
        /// <value>The guests list.</value>
        public List<Guest> guestsList { get; set; }

        /// <summary>
        /// Gets or sets the reservation list.
        /// </summary>
        /// <value>The reservation list.</value>
        public List<Reservation> reservationList { get; set; }

        /// <summary>
        /// Gets or sets the cleaning job list.
        /// </summary>
        /// <value>The cleaning job list.</value>
        public List<CleaningJob> cleaningJobList { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomBookingManager"/> class.
        /// </summary>
        public RoomBookingManager()
        {
            roomsList = new List<Room>();
            guestsList = new List<Guest>();
            reservationList = new List<Reservation>();
            cleaningJobList = new List<CleaningJob>();

            FillDataWithAllGuests();
            FillDataWithAllReservations();
            FillDataWithAllRooms();
            FillDataWithAllCleaningJobs();
        }

        /// <summary>
        /// Fills the data with all rooms.
        /// </summary>
        public void FillDataWithAllRooms()
        {
            try
            {
                MyXmlSerializer<List<Room>> serialzier = new MyXmlSerializer<List<Room>>();
                roomsList = serialzier.ReadObject(@"./roomXML.xml");
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Fills the data with all guests.
        /// </summary>
        public void FillDataWithAllGuests()
        {
            try
            {
                MyXmlSerializer<List<Guest>> serialzier = new MyXmlSerializer<List<Guest>>();
                guestsList = serialzier.ReadObject(@"./guestXML.xml");
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Fills the data with all reservations.
        /// </summary>
        public void FillDataWithAllReservations()
        {
            try
            {
                MyXmlSerializer<List<Reservation>> serialzier = new MyXmlSerializer<List<Reservation>>();
                reservationList = serialzier.ReadObject(@"./reservationXML.xml");
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Fills the data with all cleaning jobs.
        /// </summary>
        public void FillDataWithAllCleaningJobs()
        {
            try
            {
                MyXmlSerializer<List<CleaningJob>> serialzier = new MyXmlSerializer<List<CleaningJob>>();
                cleaningJobList = serialzier.ReadObject(@"./cleaningJobXML.xml");
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Serializes the rooms.
        /// </summary>
        public void SerializeRooms()
        {
            MyXmlSerializer<List<Room>> ser = new MyXmlSerializer<List<Room>>();
            ser.WriteObject(@"roomXML.xml", roomsList);
        }

        /// <summary>
        /// Serializes the guests.
        /// </summary>
        public void SerializeGuests()
        {
            MyXmlSerializer<List<Guest>> ser = new MyXmlSerializer<List<Guest>>();
            ser.WriteObject(@"guestXML.xml", guestsList);
        }

        /// <summary>
        /// Serializes the reservations.
        /// </summary>
        public void SerializeReservations()
        {
            MyXmlSerializer<List<Reservation>> ser = new MyXmlSerializer<List<Reservation>>();
            ser.WriteObject(@"reservationXML.xml", reservationList);
        }

        /// <summary>
        /// Serializes the cleaning jobs.
        /// </summary>
        public void SerializeCleaningJobs()
        {
            MyXmlSerializer<List<CleaningJob>> ser = new MyXmlSerializer<List<CleaningJob>>();
            ser.WriteObject(@"cleaningJobXML.xml", cleaningJobList);
        }

        /// <summary>
        /// Adds the new guest.
        /// </summary>
        /// <param name="guest">The guest.</param>
        public void AddNewGuest(Guest guest)
        {
            guestsList.Add(guest);
            SerializeGuests();
        }

        /// <summary>
        /// Adds the new room.
        /// </summary>
        /// <param name="room">The room.</param>
        public void AddNewRoom(Room room)
        {
            roomsList.Add(room);
            SerializeRooms();
        }

        /// <summary>
        /// Adds the new reservation.
        /// </summary>
        /// <param name="reservation">The reservation.</param>
        public void AddNewReservation(Reservation reservation)
        {
            reservationList.Add(reservation);
            SerializeReservations();
        }

        /// <summary>
        /// Adds the new cleaning job.
        /// </summary>
        /// <param name="cJob">The c job.</param>
        public void AddNewCleaningJob(CleaningJob cJob)
        {
            cleaningJobList.Add(cJob);
            SerializeCleaningJobs();
        }

        /// <summary>
        /// Deletes the guest.
        /// </summary>
        /// <param name="guest">The guest.</param>
        public void DeleteGuest(Guest guest)
        {
            guestsList.Remove(guest);
            SerializeGuests();
        }

        /// <summary>
        /// Deletes the room.
        /// </summary>
        /// <param name="room">The room.</param>
        public void DeleteRoom(Room room)
        {
            roomsList.Remove(room);
            SerializeRooms();
        }

        /// <summary>
        /// Deletes the reservation.
        /// </summary>
        /// <param name="reservation">The reservation.</param>
        public void DeleteReservation(Reservation reservation)
        {
            reservationList.Remove(reservation);
            SerializeReservations();
        }

        /// <summary>
        /// Deletes the cleaning job.
        /// </summary>
        /// <param name="cJob">The c job.</param>
        public void DeleteCleaningJob(CleaningJob cJob)
        {
            cleaningJobList.Remove(cJob);
            SerializeCleaningJobs();
        }

        /// <summary>
        /// Updates the room.
        /// </summary>
        /// <param name="room">The room.</param>
        /// <param name="newVal">The new value.</param>
        public void UpdateRoom(Room room, Room newVal)
        {
            roomsList[roomsList.IndexOf(room)] = newVal;
            SerializeRooms();
        }

        /// <summary>
        /// Updates the guest.
        /// </summary>
        /// <param name="guest">The guest.</param>
        /// <param name="newVal">The new value.</param>
        public void UpdateGuest(Guest guest, Guest newVal)
        {
            guestsList[guestsList.IndexOf(guest)] = newVal;
            SerializeGuests();
        }

        /// <summary>
        /// Updates the reservation.
        /// </summary>
        /// <param name="res">The resource.</param>
        /// <param name="newVal">The new value.</param>
        public void UpdateReservation(Reservation res, Reservation newVal)
        {
            reservationList[reservationList.IndexOf(res)] = newVal;
            SerializeReservations();
        }

        /// <summary>
        /// Updates the cleaning job.
        /// </summary>
        /// <param name="cJob">The c job.</param>
        /// <param name="newVal">The new value.</param>
        public void UpdateCleaningJob(CleaningJob cJob, CleaningJob newVal)
        {
            cleaningJobList[cleaningJobList.IndexOf(cJob)] = newVal;
            SerializeCleaningJobs();
        }
    }
}
