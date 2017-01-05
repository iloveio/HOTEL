using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Database
{
    class EntertainmentManager
    {
        public List<InnerEntertainment> innierEntertainmentList;
        public List<OrganisedEvent> organisedEventsList;

        public EntertainmentManager()
        {
            innierEntertainmentList = new List<InnerEntertainment>();
            organisedEventsList = new List<OrganisedEvent>();

            DeserializeInnierEntertainments();
            DeserializeOrganisedEvents();
        }

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

        void SerializeInnierEntertainments()
        {
            MyXmlSerializer<List<InnerEntertainment>> ser = new MyXmlSerializer<List<InnerEntertainment>>();
            ser.WriteObject(@"innerEntertainmentXML.xml", innierEntertainmentList);
        }

        void SerializeOrganisedEvents()
        {
            MyXmlSerializer<List<OrganisedEvent>> ser = new MyXmlSerializer<List<OrganisedEvent>>();
            ser.WriteObject(@"organisedEventXML.xml", organisedEventsList);
        }

        public void AddNewInnierEntertainment(InnerEntertainment ent)
        {
            innierEntertainmentList.Add(ent);
            SerializeInnierEntertainments();
        }

        public void AddNEwOrganisedEvent(OrganisedEvent ev)
        {
            organisedEventsList.Add(ev);
            SerializeOrganisedEvents();
        }

        public void DeleteInnierEntertainment(InnerEntertainment ent)
        {
            innierEntertainmentList.Remove(ent);
            SerializeInnierEntertainments();
        }

        public void DeleteOrganisedEvent(OrganisedEvent ev)
        {
            organisedEventsList.Remove(ev);
            SerializeOrganisedEvents();
        }

        public void UpdateInnierEntertainment(InnerEntertainment ent, InnerEntertainment newVal)
        {
            innierEntertainmentList[innierEntertainmentList.IndexOf(ent)] = newVal;
            SerializeInnierEntertainments();
        }

        public void UpdateOrganisedEvent(OrganisedEvent ev, OrganisedEvent newVal)
        {
            organisedEventsList[organisedEventsList.IndexOf(ev)] = newVal;
            SerializeOrganisedEvents();
        }
    }
}
