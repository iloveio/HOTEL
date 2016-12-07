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
