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
            Fridge fridge = new Fridge() ;

            fridge.Add_Ingredient("Tomato");
            fridge.Add_Ingredient("Bread");
            fridge.Add_Ingredient("Butter");

            //List<Ingredient> ingredients = fridge.Return_Ingredients();

            Chef chef = new Chef();
            Dish dish = chef.Make_Dish("Tomato sandwich",fridge);

            Console.ReadKey();
        }

    }
}
