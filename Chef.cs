using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Chef
    {
        public Chef()
        {
            Console.WriteLine("Chef constructor.");

        }

        public Dish Make_Dish(string dishName, Fridge fridge )
        {
            List<Ingredient> ingredients = fridge.Return_Ingredients();

            List<Ingredient> empty = new List<Ingredient>();
            Dish dish = new Dish("", empty);

            int i1 = -1,
                i2 = -1,
                i3 = -1;

            List<Ingredient> usedIngredients = new List<Ingredient>();

            if (dishName == "Tomato sandwich")
            {
                for (int i = 0; i < ingredients.Count; i++)
                {
                    if (i1 == -1 && ingredients[i].Name() == "Bread")
                    {
                        i1 = i;
                        usedIngredients.Add(ingredients[i1]);
                        Console.WriteLine("Found bread.");
                    }
                    if (i2 == -1 && ingredients[i].Name() == "Butter")
                    {
                        i2 = i;
                        usedIngredients.Add(ingredients[i2]);
                        Console.WriteLine("Found butter.");
                    }
                    if (i3 == -1 && ingredients[i].Name() == "Tomato")
                    {
                        i3 = i;
                        usedIngredients.Add(ingredients[i3]);
                        Console.WriteLine("Found tomato.");
                    }

                    if (i1 >= 0)
                    {
                        if (i2 >= 0)
                        {
                            if (i3 >= 0)
                            {
                                Console.WriteLine("{0} created.", dishName);
                                dish = new Dish("Tomato sandwich", usedIngredients);
                                
                                // Remove_Named_Ingredients()
                            }
                            //else Console.WriteLine("Tomato not present.");
                        }
                        //else Console.WriteLine("Butter not present.");
                    }
                    //else Console.WriteLine("Bread not present.");
                }
            }
            else Console.WriteLine("No such dish as \"{0}\" in the menu.",dishName);

            return dish;
            
        }
    }
}
