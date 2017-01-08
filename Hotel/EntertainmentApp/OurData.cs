////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	OurData.cs
//
// summary:	Implements our data class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.ObjectModel;
using Hotel.Database;
using HumanResourcesLib;

namespace EntertainmentApp
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   our data. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class OurData
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public OurData()
        {
            m_OrganisedEvents = new ObservableCollection<OrganisedEvent>();
            m_InnerEntertainments = new ObservableCollection<InnerEntertainment>();

            m_RoomBookingManager = new RoomBookingManager();
            m_RoomBookingManager.AddNewGuest(new Guest(1922313,"Angelo","Micheal","POLAND"));
            m_RoomBookingManager.AddNewGuest(new Guest(2811313, "Halinka", "Chudzinka", "POLAND"));
            m_StaffManager = new StaffManager();
            m_EntManager = new EntertainmentManager();

            m_Guests = new ObservableCollection<Guest>(m_RoomBookingManager.guestsList);
            m_Supervisors = new ObservableCollection<Supervisor>(m_StaffManager.supervisorList);

            m_OrganisedEvents.Add(new OrganisedEvent("Koncert Perfect", 6800, 350, new DateTime(2016, 12, 10), new DateTime(2016, 12, 10), new Supervisor("Piotr", "Szynka", 0, "piosz", "admin123")));
            m_OrganisedEvents.Add(new OrganisedEvent("Przyjęcie urodzinowe prezydenta", 15500, 100, new DateTime(2016, 04, 05), new DateTime(2016, 04, 05), new Supervisor("Piotr", "Szynka", 0, "piosz", "admin123")));
            m_OrganisedEvents.Add(new OrganisedEvent("Bal przebierańców", 3100, 500, new DateTime(2016, 10, 31), new DateTime(2016, 10, 31), new Supervisor("Piotr", "Szynka", 0, "piosz", "admin123")));

            m_InnerEntertainments.Add(new InnerEntertainment("Basen", 10));
            m_InnerEntertainments.Add(new InnerEntertainment("Kasyno", 45));
            m_InnerEntertainments.Add(new InnerEntertainment("Spa", 100));
            m_InnerEntertainments.Add(new InnerEntertainment("Bar", 13));
            m_InnerEntertainments.Add(new InnerEntertainment("Siłownia", 8));
            m_InnerEntertainments.Add(new InnerEntertainment("Kino", 15));

            m_Supervisors.Add(new Supervisor("Piotr", "Szynka", 0, "piosz", "admin123"));
            m_Supervisors.Add(new Supervisor("Bartosz", "Cham", 1, "bartch", "heH"));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the organised events. </summary>
        ///
        /// <value> The m organised events. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public ObservableCollection<OrganisedEvent> m_OrganisedEvents { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the inner entertainments. </summary>
        ///
        /// <value> The m inner entertainments. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public ObservableCollection<InnerEntertainment> m_InnerEntertainments { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the guests. </summary>
        ///
        /// <value> The m guests. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public RoomBookingManager m_RoomBookingManager { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the supervisors. </summary>
        ///
        /// <value> The m supervisors. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public StaffManager m_StaffManager { get; set; }

        public ObservableCollection<Guest> m_Guests { get; set; }
        public ObservableCollection<Supervisor> m_Supervisors { get; set; }

        public EntertainmentManager m_EntManager { get; set; }
        
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Adds to the collection. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="organisedEvent">   The organised event. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void addToCollection(OrganisedEvent organisedEvent)
        {
            m_OrganisedEvents.Add(organisedEvent);
            m_EntManager.AddNEwOrganisedEvent(organisedEvent);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Adds to the collection. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="innerEntertainment">   The inner entertainment. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void addToCollection(InnerEntertainment innerEntertainment)
        {
            m_InnerEntertainments.Add(innerEntertainment);
            m_EntManager.AddNewInnierEntertainment(innerEntertainment);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Removes from collection described by innerEntertainment. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="organisedEvent">   The organised event. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void removeFromCollection(OrganisedEvent organisedEvent)
        {
            m_OrganisedEvents.Remove(organisedEvent);
            m_EntManager.DeleteOrganisedEvent(organisedEvent);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Removes from collection described by innerEntertainment. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="innerEntertainment">   The inner entertainment. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void removeFromCollection(InnerEntertainment innerEntertainment)
        {
            m_InnerEntertainments.Remove(innerEntertainment);
            m_EntManager.DeleteInnierEntertainment(innerEntertainment);
        }
    }
}
