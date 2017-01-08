using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Database;
using Transport.Transpport;

namespace Hotel.Transpport.Dane
{
    public class Shop :Transport
    {
        List<Object> produkt;
        ShopWindow page;
        private TransportationManager menager;
        public Shop(List<Object> prod)
        {
            produkt = prod;
            page = new ShopWindow(this);
            menager = new TransportationManager();
        }

        public Shop(List<Object> prod, TransportationManager men)
        {
            produkt = prod;
            menager = men;
            page = new ShopWindow(this);
        }

        public override bool Save()
        {
            if (menager != null)
            {
                Transportation tr = new Transportation();
                tr.date = this.date;
                tr.description = produkt.ToString() + "/n Pracownik: " + employee;
                menager.AddNewTransportation(tr);
                menager.SerializeTransport();
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
