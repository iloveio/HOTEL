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
            Console.WriteLine("Hello.");

            Fridge fridge = new Fridge() ;
            List<Ingredient> ingredients = fridge.Return_Ingredients();

            Chef chef = new Chef();
            Dish dish = chef.Make_Dish("Tomato sandwich",ingredients);

            Console.ReadKey();
        }








    }

    

    

    

    

    
}
