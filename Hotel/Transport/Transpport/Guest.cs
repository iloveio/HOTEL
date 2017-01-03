using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Database.Transportation;

namespace Hotel.Transpport
{
    public class Guest : Transport
    {
        public string guest;
        public string from;
        public string destination;
        public int howMany;
        private TransportationManager menager;

        public Guest(TransportationManager men)
        {
            menager = men;
        }
        public Guest()
        {
            menager = new TransportationManager();
        }
        public override bool Save()
        {
            if (menager != null)
            {
                menager.AddNewTransportation(this);
                return true;
            }
            else
            {
                return false;
            }
        }
    }  
}
