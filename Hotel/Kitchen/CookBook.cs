////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	CookBook.cs
//
// summary:	Implements the cook book class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Kitchen
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A cook book. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class CookBook
    {
                                                /// <summary>   True to show, false to hide the comments. </summary>
                                                public bool showComments = false;
        

        /// <summary>   True to display comments. </summary>
        public bool displayComments = false;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public CookBook()
        {
            List<string> ingredientNames = new List<string>();
            ingredientNames.Add("Bread");
            ingredientNames.Add("Butter");
            ingredientNames.Add("Tomato");
            //Recipe thisRecipe = new Recipe("Tomato sandwich", ingredientNames);
            (this.recipes).Add(new Recipe("Tomato sandwich", ingredientNames));

            // --

            ingredientNames.Clear();

            ingredientNames.Add("Bread");
            ingredientNames.Add("Weiner");
            ingredientNames.Add("Ketchup");
            //thisRecipe = new Recipe("Hot dog", ingredientNames);
            (this.recipes).Add(new Recipe("Hot dog", ingredientNames));

            this.Display_Recipes();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Enough ingredients. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="dishName"> Name of the dish. </param>
        /// <param name="fridge">   The fridge. </param>
        ///
        /// <returns>   True if it succeeds, false if it fails. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool Enough_Ingredients( string dishName, Fridge fridge )
        {
            Console.WriteLine("CookBook::Enough_Ingredients() - start");

            int n = recipes.Count;

            int recipeID = -1;
            for( int i = 0; i<n; i++)
            {
                string thisRecipeName = recipes[i].Return_Name();

                if( thisRecipeName == dishName ) // find recipe with the requested name
                {
                    recipeID = i;
                    if (showComments)  Console.WriteLine("- Chosen recipe for: {0}", thisRecipeName);
                    break;
                }
            }

            List<string> recipeIngredientNames = new List<string>();
            List<string> fridgeIngredientNames = fridge.Return_ingredientNames();

            if (recipeID >= 0) recipeIngredientNames = recipes[recipeID].Return_ingredientNames();
            else
            {
                Console.WriteLine("Zero recipes with name \"{0}\" found.",dishName);
                Console.WriteLine("CookBook::Enough_Ingredients() - return false");
                return false; // return false if there are no recipes with the requested name
            }


            int nrec = recipeIngredientNames.Count;
            int nfri = fridgeIngredientNames.Count;

            int foundIngredients = 0;

            for( int i = 0; i<nrec; i++ )
            {
                for( int j = 0; j<nfri; j++)
                {
                    if (showComments) Console.WriteLine("- Comparing {0} and {1} ...",recipeIngredientNames[i], fridgeIngredientNames[j]);
                    

                    if ( recipeIngredientNames[i]== fridgeIngredientNames[j]) // find in fridge the #i inredient listed in the recipe
                    {
                        if (showComments) Console.WriteLine("Found fridge ingredient: {0}", fridgeIngredientNames[j]);
                        foundIngredients++;
                        break;
                    }
                }

                if (showComments) Console.WriteLine("Found {0} ingredients.", foundIngredients);
                if (foundIngredients == nrec)
                {
                    Console.WriteLine("CookBook::Enough_Ingredients() - return true");
                    return true; // return true if all recipe ingredients were found in the fridge
                }
                //else Console.WriteLine("Not all ingredients found for dish {0}.", dishName);
            }


            Console.WriteLine("CookBook::Enough_Ingredients() - return false");
            return false;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Returns the ingredients. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="dishName"> Name of the dish. </param>
        ///
        /// <returns>   The ingredients. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<string> Return_Ingredients( string dishName )
        {
            List<string> ingredientNames = new List<string>();

            int n = this.recipes.Count;
            for( int i = 0; i<n; i++ )
            {
                if ( this.recipes[i].Return_Name() == dishName )
                {
                    return this.recipes[i].Return_ingredientNames();
                }
            }

            Console.WriteLine("There is no dish named \"{0}\" in the CookBook.",dishName);

            return ingredientNames;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Displays the recipes. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Display_Recipes()
        {
            if (showComments)
            {
                Console.WriteLine("\n----------------");
                Console.WriteLine("All recipes:");
                int n = this.recipes.Count;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("\n{0}:", recipes[i].Return_Name());
                    List<string> recipeNames = recipes[i].Return_ingredientNames();

                    int m = recipeNames.Count;

                    for (int j = 0; j < m; j++) Console.WriteLine("* {0}", recipeNames[j]);
                }
                Console.WriteLine("----------------\n");
            }
            
        }

        /// <summary>   The recipes. </summary>
        private List<Recipe> recipes = new List<Recipe>();

    }
}
