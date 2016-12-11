using System;
using System.Collections.Generic;
using Hotel.Database;

namespace EntertainmentApp
{
    public class OrganisedEvent : Entertainment
    {
        public OrganisedEvent(string name, float price, int maximumNumberOfGuests,
            DateTime startDate, DateTime endDate, Employee supervisor)
        {
            this.name = name;
            this.price = price;
            this.maximumNumberOfGuests = maximumNumberOfGuests;
            this.startDate = startDate.ToShortDateString();
            this.endDate = endDate.ToShortDateString();
            this.supervisor = supervisor;
        }

        public int maximumNumberOfGuests { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
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
