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

    public class TransportationManager
    {
        List<Transport> transportationsList { get; set; }
        

        public TransportationManager()
        {
            transportationsList = new List<Transport>();
            FillDataWithAllTransportations();
        }
        

        public void FillDataWithAllTransportations()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Transport>));
            TextReader reader = new StreamReader(@"./transportationsXML.xml");
            object obj = deserializer.Deserialize(reader);
            transportationsList = (List<Transport>)obj;
            reader.Close();
        }

        public void SerializeTransport()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Transport>));
            using (TextWriter writer = new StreamWriter(@"./transportationsXML.xml"))
            {
                serializer.Serialize(writer, transportationsList);
            }
        }

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
