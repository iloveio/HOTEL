using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Transpport
{
    class Shop :Transport
    {
        List<Object> produkt;
        public Shop(List<Object> prod)
        {
            produkt = prod;   
        }
    }
}
