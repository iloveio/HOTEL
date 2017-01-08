using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Database;
using Transport.Transpport;

namespace Hotel.Transpport.Dane
{
    public class Guest : Transport
    {
        public string guest;
        public string from;
        public string destination;
        public int howMany;
        private TransportationManager menager;
        GuestWindow page;

        public Guest(TransportationManager men)
        {
            menager = men;
            page = new GuestWindow(this);
        }
        public Guest()
        {
            menager = new TransportationManager();
        }
        public override bool Save()
        {
            if (menager != null)
            {
                Transportation tr = new Transportation();
                tr.date = this.date;
                tr.description = "/n Pracownik: " + employee+ "/n Guest Name: " +guest+"/n How many people: "+ howMany+ "/n Destination: " + destination+ "/n From: "+from;
                menager.AddNewTransportation(tr);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Show()
        {
            page.Show();
        }
    }  
}
