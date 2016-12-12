using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Transpport
{
    public class Guest : Transport
    {
        public string guestName;
        public string from;
        public string destination;
        public int howMany;
        GuestWindow w;

        public Guest()
        {
            w = new GuestWindow(this);
        }
        public void Show()
        {
            w.Show();
        }

    }  
}
