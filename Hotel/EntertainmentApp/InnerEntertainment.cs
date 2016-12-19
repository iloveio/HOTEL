////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	InnerEntertainment.cs
//
// summary:	Implements the inner entertainment class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Database;

namespace EntertainmentApp
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   An inner entertainment. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class InnerEntertainment : Entertainment
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="name">     The name. </param>
        /// <param name="price">    The price. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public InnerEntertainment(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Calculates the payment. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="hoursSpent">   The hours spent. </param>
        ///
        /// <returns>   The calculated payment. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public double computePayment(int hoursSpent )
        {
            return price * hoursSpent;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Print receipt. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="guest">    The guest. </param>
        ///
        /// <returns>   A string. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string printReceipt(Guest guest)
        {
            return "Entertainment name: " + name + " \nPrice: " + price
                + "\nGuest: " + guest.Name + " " + guest.Surname;
        }

    }
}
