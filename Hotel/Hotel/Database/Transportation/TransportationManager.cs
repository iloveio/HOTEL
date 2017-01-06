

using Hotel.Database;
using Hotel.Transpport;
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
    /// Class TransportationManager.
    /// </summary>
    public class TransportationManager
    {
        /// <summary>
        /// Gets or sets the transportations list.
        /// </summary>
        /// <value>The transportations list.</value>
        public List<Transportation> transportationsList { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransportationManager"/> class.
        /// </summary>
        public TransportationManager()
        {
            transportationsList = new List<Transportation>();
            FillDataWithAllTransportations();
        }

        /// <summary>
        /// Fills the data with all transportations.
        /// </summary>
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

        /// <summary>
        /// Serializes the transport.
        /// </summary>
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

        /// <summary>
        /// Adds the new transportation.
        /// </summary>
        /// <param name="trans">The trans.</param>
        public void AddNewTransportation(Transportation trans)
        {
            transportationsList.Add(trans);
            SerializeTransport();
        }

        /// <summary>
        /// Updates the transport.
        /// </summary>
        /// <param name="trans">The trans.</param>
        /// <param name="newVal">The new value.</param>
        public void UpdateTransport(Transportation trans , Transportation newVal)
        {
            transportationsList[transportationsList.IndexOf(trans)] = newVal;
            SerializeTransport();
        }

        /// <summary>
        /// Deletes the transport.
        /// </summary>
        /// <param name="trans">The trans.</param>
        public void DeleteTransport(Transportation trans)
        {
            transportationsList.Remove(trans);
            SerializeTransport();
        }
    }
}
