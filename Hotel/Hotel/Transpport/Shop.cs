using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Transpport
{
    public class Shop :Transport
    {
        List<Object> produkt;
        ShopWindow w;
        /// <summary>
        /// Create object you must send List<Object>
        /// </summary>
        /// <param name="prod"></param>
        public Shop(List<Object> prod)
        {
            produkt = prod;
            w = new ShopWindow(this);
        }
        /// <summary>
        /// schow Widow to create
        /// </summary>
        public void Show()
        {
            w.Show();
        }
    }
}
