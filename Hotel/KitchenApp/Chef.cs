using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kitchen
{
    /// <summary> 
    /// Creates dishes from ingredients and puts them on a bill. </summary>
    public class Chef
    {
        /// <summary> 
        /// Class constructor. </summary>
        /// <param name="fridge"> Fridge accessed by the chef.</param>
        /// <param name="cookBook"> Cook book accessed by the chef.</param>
        /// <param name="bills"> Bills accessed by the chef.</param>
        public Chef(Fridge fridge, CookBook cookBook, Bills bills)
        {
            this.usedFridge = fridge;
            this.usedCookBook = cookBook;
            this.usedBills = bills;

        }

        /// <summary> 
        /// Create dish, based on the dish name. </summary>
        /// <param name="dishName"> Dish to be made.</param>
        public Dish Make_Dish(string dishName )
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            List<string> ingredientNames = new List<string>();

            Dish dish = new Dish("",ingredients,0);

                ingredientNames = this.usedCookBook.Return_Ingredients(dishName);

            if (ingredientNames.Count > 1)
            {
                ingredients = Names_To_Ingredients(ingredientNames);

                // remove ingredients from fridge
                foreach (Ingredient ingredient in ingredients)
                {
                    foreach (Ingredient ing in Controller.Instance.kitchen.fridge.Return_Ingredients())
                    {
                        if (ingredient.name == ing.name)
                        {
                            if (ing.number == 0)
                            {
                                MessageBox.Show("Can't make dish" + dishName);
                                return dish;
                            }
                        }
                    }
                }
               

                int price = usedCookBook.Name_To_Price(dishName);
                dish = new Dish(dishName, ingredients, price);
                Controller.Instance.kitchen.fridge.reduceIngredient(ingredients);

                Console.WriteLine(" Successfully created dish named \"{0}\".\n", dishName);
            }
            else Console.WriteLine("Too few ingredients in {0}'s recipe.", dishName);

            return dish;            
            
        }

        /// <summary> 
        /// Convert names of ingredients into ingredients. </summary>
        /// <param name="ingredientNames"> Names to be converted.</param>
        public List<Ingredient> Names_To_Ingredients( List<string> ingredientNames )
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            int n = ingredientNames.Count;
            for ( int i = 0; i<n; i++ )
            {
                ingredients.Add(new Ingredient(ingredientNames[i], 15));
            }

            return ingredients;
        }

        /// <summary> 
        /// Fridge accessed by the chef. </summary>
        private Fridge usedFridge;

        /// <summary> 
        /// Cook book accessed by the chef. </summary>
        private CookBook usedCookBook;

        /// <summary> 
        /// List of bills accessed by the chef. </summary>
        private Bills usedBills;

        
    }
}
