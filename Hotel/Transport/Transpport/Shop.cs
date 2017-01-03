using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Database.Transportation;

namespace Hotel.Transpport
{
    class Shop :Transport
    {
        List<Object> produkt;
        private TransportationManager menager;
        public Shop(List<Object> prod)
        {
            produkt = prod;
            menager = new TransportationManager();
        }

        public Shop(List<Object> prod, TransportationManager men)
        {
            produkt = prod;
            menager = men;
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
