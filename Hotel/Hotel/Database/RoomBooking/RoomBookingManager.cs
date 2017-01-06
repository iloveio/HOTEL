////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Database\RoomBooking\RoomBookingManager.cs
//
// summary:	Implements the room booking manager class
////////////////////////////////////////////////////////////////////////////////////////////////////

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
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Manager for room bookings. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class RoomBookingManager
    {
        /// <summary>   List of rooms. </summary>
        public List<Room> roomsList { get; set; }
        /// <summary>   List of guests. </summary>
        public List<Guest> guestsList { get; set; }

        public List<Reservation> reservationList { get; set; }

        public List<CleaningJob> cleaningJobList { get; set; }

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

        public void FillDataWithAllGuests()
        {
            try
            {
                MyXmlSerializer<List<Guest>> serialzier = new MyXmlSerializer<List<Guest>>();
                guestsList = serialzier.ReadObject(@"./guestXML");
            }
            catch (Exception ex)
            {

            }
        }

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

        public void SerializeRooms()
        {
            MyXmlSerializer<List<Room>> ser = new MyXmlSerializer<List<Room>>();
            ser.WriteObject(@"roomXML.xml", roomsList);
        }

        public void SerializeGuests()
        {
            MyXmlSerializer<List<Guest>> ser = new MyXmlSerializer<List<Guest>>();
            ser.WriteObject(@"guestXML.xml", guestsList);
        }

        public void SerializeReservations()
        {
            MyXmlSerializer<List<Reservation>> ser = new MyXmlSerializer<List<Reservation>>();
            ser.WriteObject(@"reservationXML.xml", reservationList);
        }

        public void SerializeCleaningJobs()
        {
            MyXmlSerializer<List<CleaningJob>> ser = new MyXmlSerializer<List<CleaningJob>>();
            ser.WriteObject(@"cleaningJobXML.xml", cleaningJobList);
        }

        public void AddNewGuest(Guest guest)
        {
            guestsList.Add(guest);
            SerializeGuests();
        }

        public void AddNewRoom(Room room)
        {
            roomsList.Add(room);
            SerializeRooms();
        }

        public void AddNewReservation(Reservation reservation)
        {
            reservationList.Add(reservation);
            SerializeReservations();
        }

        public void AddNewCleaningJob(CleaningJob cJob)
        {
            cleaningJobList.Add(cJob);
            SerializeCleaningJobs();
        }

        public void DeleteGuest(Guest guest)
        {
            guestsList.Remove(guest);
            SerializeGuests();
        }

        public void DeleteRoom(Room room)
        {
            roomsList.Remove(room);
            SerializeRooms();
        }

        public void DeleteReservation(Reservation reservation)
        {
            reservationList.Remove(reservation);
            SerializeReservations();
        }

        public void DeleteCleaningJob(CleaningJob cJob)
        {
            cleaningJobList.Remove(cJob);
            SerializeCleaningJobs();
        }

        public void UpdateRoom(Room room, Room newVal)
        {
            roomsList[roomsList.IndexOf(room)] = newVal;
            SerializeRooms();
        }

        public void UpdateGuest(Guest guest, Guest newVal)
        {
            guestsList[guestsList.IndexOf(guest)] = newVal;
            SerializeGuests();
        }

        public void UpdateReservation(Reservation res, Reservation newVal)
        {
            reservationList[reservationList.IndexOf(res)] = newVal;
            SerializeReservations();
        }

        public void UpdateCleaningJob(CleaningJob cJob, CleaningJob newVal)
        {
            cleaningJobList[cleaningJobList.IndexOf(cJob)] = newVal;
            SerializeCleaningJobs();
        }
    }
}
