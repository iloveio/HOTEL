////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Bill.cs
//
// summary:	Implements the bill class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A bill. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class Bill
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="billID">       Identifier for the bill. </param>
        /// <param name="customerID">   Identifier for the customer. </param>
        /// <param name="dishes">       The dishes. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Bill(int billID, int customerID, List<Dish> dishes)
        {
            this.billID = billID;
            this.dishes = dishes;
        }

        /// <summary>   Identifier for the bill. </summary>
        private int billID;
        /// <summary>   Identifier for the customer. </summary>
        private int customerID;
        /// <summary>   The dishes. </summary>
        private List<Dish> dishes;
    }
}
