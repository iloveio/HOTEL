////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Chef.cs
//
// summary:	Implements the chef class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A chef. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class Chef
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="fridge">   The fridge. </param>
        /// <param name="cookBook"> The cook book. </param>
        /// <param name="bills">    The bills. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Chef(Fridge fridge, CookBook cookBook, Bills bills)
        {
            this.usedFridge = fridge;
            this.usedCookBook = cookBook;
            this.usedBills = bills;

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Makes a dish. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="dishName"> Name of the dish. </param>
        ///
        /// <returns>   A Dish. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

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

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Names to ingredients. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="ingredientNames">  List of names of the ingredients. </param>
        ///
        /// <returns>   A List&lt;Ingredient&gt; </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

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


        /// <summary>   The used fridge. </summary>
        private Fridge usedFridge;
        /// <summary>   The used cook book. </summary>
        private CookBook usedCookBook;
        /// <summary>   The used bills. </summary>
        private Bills usedBills;

        
    }
}
