using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Database;

namespace Hotel.Transpport
{
    public class Menager
    {
        public TransportationManager mengaerDatabase;
        public Menager(TransportationManager men)
        {
            mengaerDatabase = men;
        }

    }
}
