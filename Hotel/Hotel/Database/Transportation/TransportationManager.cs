////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Database\Transportation\TransportationManager.cs
//
// summary:	Implements the transportation manager class
////////////////////////////////////////////////////////////////////////////////////////////////////

using Hotel.Transpport;
using HumanResourcesLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Hotel.Database.Transportation
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Manager for transportations. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class TransportationManager
    {
        /// <summary>   List of transportations. </summary>
        List<Transport> transportationsList;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public TransportationManager()
        {
            transportationsList = new List<Transport>();
            FillDataWithAllTransportations();
        }

        //----Methods to fill lists----

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Method to fill transportations list with data from database, works as update (should be
        /// called whenever data in database has been changed.
        /// </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void FillDataWithAllTransportations()
        {
            //Deserialize
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Transport>));
            TextReader reader = new StreamReader(@"./transportationsXML.xml");
            object obj = deserializer.Deserialize(reader);
            transportationsList = (List<Transport>)obj;
            reader.Close();
        }
        #pragma warning restore 1591
        public void SerializeTransport()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Transport>));
            using (TextWriter writer = new StreamWriter(@"./transportationsXML.xml"))
            {
                serializer.Serialize(writer, transportationsList);
            }
        }
        //----Methods to manage database----

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Method to add new transportation record to database. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="trans">    . </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void AddNewTransportation(Transport trans)
        {
            transportationsList.Add(trans);
            SerializeTransport();
        }

        public void UpdateTransport(Transport trans , Transport newVal)
        {
            transportationsList[transportationsList.IndexOf(trans)] = newVal;
            SerializeTransport();
        }

        public void DeleteTransport(Transport trans)
        {
            transportationsList.Remove(trans);
            SerializeTransport();
        }



    }
}
