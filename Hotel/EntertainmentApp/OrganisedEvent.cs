using System;
using System.Collections.Generic;

namespace EntertainmentApp
{
    class OrganisedEvent : Entertainment
    {
        public OrganisedEvent(string name, float price, int maximumNumberOfGuests,
            DateTime startDate, DateTime endDate, Employee supervisor)
        {
            this.name = name;
            this.price = price;
            this.maximumNumberOfGuests = maximumNumberOfGuests;
            this.startDate = startDate;
            this.endDate = endDate;
            this.supervisor = supervisor;
        }

        public int maximumNumberOfGuests { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public Employee supervisor { get; set; }
        public List<Guest> guestList { get; set; }

        public void addGuest(Guest guest)
        {
            guestList.Add(guest);
        }
        public void removeGuest(Guest guest)
        {
            guestList.Remove(guest);
        }
    }
}
