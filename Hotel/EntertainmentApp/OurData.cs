using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentApp
{
    public class OurData
    {
        public OurData()
        {
            m_OrganisedEvents = new ObservableCollection<OrganisedEvent>();
            m_InnerEntertainments = new ObservableCollection<InnerEntertainment>();

            m_OrganisedEvents.Add(new OrganisedEvent("Koncert Perfect", 6800, 350, new DateTime(2016, 12, 10), new DateTime(2016, 12, 10), new Employee()));
            m_OrganisedEvents.Add(new OrganisedEvent("Przyjęcie urodzinowe prezydenta", 15500, 100, new DateTime(2016, 04, 05), new DateTime(2016, 04, 05), new Employee()));
            m_OrganisedEvents.Add(new OrganisedEvent("Bal przebierańców", 3100, 500, new DateTime(2016, 10, 31), new DateTime(2016, 10, 31), new Employee()));

            m_InnerEntertainments.Add(new InnerEntertainment("Basen", 10));
            m_InnerEntertainments.Add(new InnerEntertainment("Kasyno", 45));
            m_InnerEntertainments.Add(new InnerEntertainment("Spa", 100));
            m_InnerEntertainments.Add(new InnerEntertainment("Bar", 13));
            m_InnerEntertainments.Add(new InnerEntertainment("Siłownia", 8));
            m_InnerEntertainments.Add(new InnerEntertainment("Kino", 15));
        }

        public ObservableCollection<OrganisedEvent> m_OrganisedEvents { get; set; }
        public ObservableCollection<InnerEntertainment> m_InnerEntertainments { get; set; }

        public void addToCollection(OrganisedEvent organisedEvent)
        {
            m_OrganisedEvents.Add(organisedEvent);
        }
        public void addToCollection(InnerEntertainment innerEntertainment)
        {
            m_InnerEntertainments.Add(innerEntertainment);
        }
        public void removeFromCollection(OrganisedEvent organisedEvent)
        {
            m_OrganisedEvents.Remove(organisedEvent);
        }
        public void removeFromCollection(InnerEntertainment innerEntertainment)
        {
            m_InnerEntertainments.Remove(innerEntertainment);
        }
    }
}
