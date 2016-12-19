////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Main.cs
//
// summary:	Implements the main class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kitchen;

namespace Kitchen_main
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A program. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class Program
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Main entry-point for this application. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        static void Main()
        {

            CookBook cookBook = new CookBook();

            Fridge fridge = new Fridge() ;

            Bills bills = new Bills() ;

            Chef chef = new Chef(fridge, cookBook, bills);
            Dish dish = chef.Make_Dish("Tomato sandwich");

            Console.WriteLine("Main: Made dish: \"{0}\"",dish.Return_Name());

            // --





            //Console.WriteLine("** Enough-ingredients' truth value = {0}\n",cookBook.Enough_Ingredients("Tomato sandwich", fridge));


            Console.ReadKey();












        }

    }
}
