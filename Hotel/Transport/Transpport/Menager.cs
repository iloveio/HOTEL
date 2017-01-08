using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Database;
using Transport.Transpport;

namespace Hotel.Transpport
{
    public class Menager
    {
        public TransportationManager mengaerDatabase;
        MenagerPage page;
         public void Show()
        {
            if(page == null)
            {
                page = new MenagerPage(this);
                page.Show();
            }
            else
            {
                page.Show();
            }
        }
        public Menager(TransportationManager men)
        {
            mengaerDatabase = men;
        }
        public void Edit(Transportation tr , Transportation newTR)
        {
            mengaerDatabase.UpdateTransport(tr, newTR);
        }
        public void Delete(Transportation tr)
        {
            mengaerDatabase.DeleteTransport(tr);
        }
    }
}
