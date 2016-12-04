using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentApp
{
    class OrganisedEvent : Entertainment
    {
        private int maximumNumberOfGuests { get; set; }
        private DateTime startDate { get; set; }
        private DateTime endDate { get; set; }
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
