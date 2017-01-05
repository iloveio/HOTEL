using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Database;

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
                Transportation tr = new Transportation();
                tr.date = this.date;
                tr.description = produkt.ToString() + "/n Pracownik: " + employee;
                menager.AddNewTransportation(tr);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
