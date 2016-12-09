using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kitchen;

namespace Kitchen_main
{
    class Program
    {
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
