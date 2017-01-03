////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Database\RoomBooking\RoomBookingManager.cs
//
// summary:	Implements the room booking manager class
////////////////////////////////////////////////////////////////////////////////////////////////////

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
        public List<User> guestsList { get; set; }

        public List<Reservation> reservationList { get; set; }

        public RoomBookingManager()
        {
            roomsList = new List<Room>();
            guestsList = new List<User>();
            reservationList = new List<Reservation>();

            FillDataWithAllGuests();
            FillDataWithAllReservations();
            FillDataWithAllRooms();
        }

        public void FillDataWithAllRooms()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Room>));
            TextReader reader = new StreamReader(@"./roomXML.xml");
            object obj = deserializer.Deserialize(reader);
            roomsList = (List<Room>)obj;
            reader.Close();
        }

        public void FillDataWithAllGuests()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<User>));
            TextReader reader = new StreamReader(@"./guestXML.xml");
            object obj = deserializer.Deserialize(reader);
            guestsList = (List<User>)obj;
            reader.Close();
        }

        public void FillDataWithAllReservations()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Reservation>));
            TextReader reader = new StreamReader(@"./reservationXML.xml");
            object obj = deserializer.Deserialize(reader);
            reservationList = (List<Reservation>)obj;
            reader.Close();
        }

        public void SerializeRooms()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Room>));
            using (TextWriter writer = new StreamWriter(@"./roomXML.xml"))
            {
                serializer.Serialize(writer, roomsList);
            }
        }

        public void SerializeGuests()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (TextWriter writer = new StreamWriter(@"./guestXML.xml"))
            {
                serializer.Serialize(writer, guestsList);
            }
        }

        public void SerializeReservations()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Reservation>));
            using (TextWriter writer = new StreamWriter(@"./reservationXML.xml"))
            {
                serializer.Serialize(writer, reservationList);
            }
        }

        public void AddNewGuest(User guest)
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

        public void DeleteGuest(User guest)
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

        public void UpdateRoom(Room room, Room newVal)
        {
            roomsList[roomsList.IndexOf(room)] = newVal;
            SerializeRooms();
        }

        public void UpdateGuest(User guest, User newVal)
        {
            guestsList[guestsList.IndexOf(guest)] = newVal;
            SerializeGuests();
        }

        public void UpdateReservation(Reservation res, Reservation newVal)
        {
            reservationList[reservationList.IndexOf(res)] = newVal;
            SerializeReservations();
        }
    }
}
