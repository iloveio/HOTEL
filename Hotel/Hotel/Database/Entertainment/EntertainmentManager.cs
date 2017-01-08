using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Database
{
    /// <summary>
    /// Class EntertainmentManager.
    /// </summary>
    public class EntertainmentManager
    {
        /// <summary>
        /// The innier entertainment list
        /// </summary>
        public List<InnerEntertainment> innierEntertainmentList;
        /// <summary>
        /// The organised events list
        /// </summary>
        public List<OrganisedEvent> organisedEventsList;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntertainmentManager"/> class.
        /// </summary>
        public EntertainmentManager()
        {
            innierEntertainmentList = new List<InnerEntertainment>();
            organisedEventsList = new List<OrganisedEvent>();

            DeserializeInnierEntertainments();
            DeserializeOrganisedEvents();
        }

        /// <summary>
        /// Deserializes the innier entertainments.
        /// </summary>
        void DeserializeInnierEntertainments()
        {
            try
            {
                MyXmlSerializer<List<InnerEntertainment>> serialzier = new MyXmlSerializer<List<InnerEntertainment>>();
                innierEntertainmentList = serialzier.ReadObject(@"./innerEntertainmentXML.xml");
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Deserializes the organised events.
        /// </summary>
        void DeserializeOrganisedEvents()
        {
            try
            {
                MyXmlSerializer<List<InnerEntertainment>> serialzier = new MyXmlSerializer<List<InnerEntertainment>>();
                innierEntertainmentList = serialzier.ReadObject(@"./organisedEventXML.xml");
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Serializes the innier entertainments.
        /// </summary>
        void SerializeInnierEntertainments()
        {
            MyXmlSerializer<List<InnerEntertainment>> ser = new MyXmlSerializer<List<InnerEntertainment>>();
            ser.WriteObject(@"innerEntertainmentXML.xml", innierEntertainmentList);
        }

        /// <summary>
        /// Serializes the organised events.
        /// </summary>
        void SerializeOrganisedEvents()
        {
            MyXmlSerializer<List<OrganisedEvent>> ser = new MyXmlSerializer<List<OrganisedEvent>>();
            ser.WriteObject(@"organisedEventXML.xml", organisedEventsList);
        }

        /// <summary>
        /// Adds the new innier entertainment.
        /// </summary>
        /// <param name="ent">The entntertainment.</param>
        public void AddNewInnierEntertainment(InnerEntertainment ent)
        {
            innierEntertainmentList.Add(ent);
            SerializeInnierEntertainments();
        }

        /// <summary>
        /// Adds the n ew organised event.
        /// </summary>
        /// <param name="ev">The event.</param>
        public void AddNEwOrganisedEvent(OrganisedEvent ev)
        {
            organisedEventsList.Add(ev);
            SerializeOrganisedEvents();
        }

        /// <summary>
        /// Deletes the innier entertainment.
        /// </summary>
        /// <param name="ent">The entertainment.</param>
        public void DeleteInnierEntertainment(InnerEntertainment ent)
        {
            innierEntertainmentList.Remove(ent);
            SerializeInnierEntertainments();
        }

        /// <summary>
        /// Deletes the organised event.
        /// </summary>
        /// <param name="ev">The event.</param>
        public void DeleteOrganisedEvent(OrganisedEvent ev)
        {
            organisedEventsList.Remove(ev);
            SerializeOrganisedEvents();
        }

        /// <summary>
        /// Updates the innier entertainment.
        /// </summary>
        /// <param name="ent">The entertainment.</param>
        /// <param name="newVal">The new value.</param>
        public void UpdateInnierEntertainment(InnerEntertainment ent, InnerEntertainment newVal)
        {
            innierEntertainmentList[innierEntertainmentList.IndexOf(ent)] = newVal;
            SerializeInnierEntertainments();
        }

        /// <summary>
        /// Updates the organised event.
        /// </summary>
        /// <param name="ev">The event.</param>
        /// <param name="newVal">The new value.</param>
        public void UpdateOrganisedEvent(OrganisedEvent ev, OrganisedEvent newVal)
        {
            organisedEventsList[organisedEventsList.IndexOf(ev)] = newVal;
            SerializeOrganisedEvents();
        }
    }
}
