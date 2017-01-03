////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Database\Transportation\TransportationManager.cs
//
// summary:	Implements the transportation manager class
////////////////////////////////////////////////////////////////////////////////////////////////////

using Hotel.Database.Staff;
using Hotel.Transpport;
using HumanResourcesLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Hotel.Database.Room
{

    public class TransportationManager
    {
        public List<Transportation> transportationsList { get; set; }
        
        public TransportationManager()
        {
            transportationsList = new List<Transportation>();
            FillDataWithAllTransportations();
        }
        
        public void FillDataWithAllTransportations()
        {
            /* XmlSerializer deserializer = new XmlSerializer(typeof(List<Transportation>));
             TextReader reader = new StreamReader(@"./transportationsXML.xml");
             object obj = deserializer.Deserialize(reader);
             transportationsList = (List<Transportation>)obj;
             reader.Close();*/
            try
            {
                MyXmlSerializer<List<Transportation>> serialzier = new MyXmlSerializer<List<Transportation>>();
                transportationsList = serialzier.ReadObject(@"./transportationXML.xml");
            }
            catch(Exception ex)
            {

            }

        }

        public void SerializeTransport()
        {
            /*XmlSerializer serializer = new XmlSerializer(typeof(List<Transport>));
            using (TextWriter writer = new StreamWriter(@"./transportationsXML.xml"))
            {
                serializer.Serialize(writer, transportationsList);
            }*/

            MyXmlSerializer<List<Transportation>> ser = new MyXmlSerializer<List<Transportation>>();
            ser.WriteObject(@"transportationXML.xml", transportationsList);
        }

        public void AddNewTransportation(Transportation trans)
        {
            transportationsList.Add(trans);
            SerializeTransport();
        }

        public void UpdateTransport(Transportation trans , Transportation newVal)
        {
            transportationsList[transportationsList.IndexOf(trans)] = newVal;
            SerializeTransport();
        }

        public void DeleteTransport(Transportation trans)
        {
            transportationsList.Remove(trans);
            SerializeTransport();
        }
    }
}
