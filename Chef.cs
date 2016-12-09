using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Chef
    {
        public Chef(Fridge fridge, CookBook cookBook, Bills bills)
        {
            this.usedFridge = fridge;
            this.usedCookBook = cookBook;
            this.usedBills = bills;

        }

        public Dish Make_Dish(string dishName )
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            List<string> ingredientNames = new List<string>();

            Dish dish = new Dish("",ingredients);

            if( this.usedCookBook.Enough_Ingredients(dishName, this.usedFridge) )
            {
                Console.WriteLine("Enough ingredients for a {0}.", dishName);

                ingredientNames = this.usedCookBook.Return_Ingredients(dishName);

                if( ingredientNames.Count > 1 )
                {
                    ingredients = Names_To_Ingredients(ingredientNames);

                    // remove ingredients from fridge

                    dish = new Dish(dishName, ingredients);

                    Console.WriteLine("Successfully created dish named \"{0}\".", dishName);
                }

                
            }


            return dish;
            
            
        }

        public List<Ingredient> Names_To_Ingredients( List<string> ingredientNames )
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            int n = ingredientNames.Count;
            for ( int i = 0; i<n; i++ )
            {
                ingredients.Add(new Ingredient(ingredientNames[i]) );
            }

            return ingredients;
        }


        private Fridge usedFridge;
        private CookBook usedCookBook;
        private Bills usedBills;

        
    }
}
