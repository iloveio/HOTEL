using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;


namespace Kitchen
{
    /// <summary> 
    /// Contains many recipes, and methods of operation on them. </summary>
    public class CookBook
    {

        public bool showComments = false;

        /// <summary> 
        /// List of recipes. </summary>
        public List<Recipe> recipes { get; set; }

        /// <summary> 
        /// Class constructor. </summary>
        public CookBook()
        {
            recipes = new List<Recipe>();
            List<string> ingredientNames = new List<string>();
            ingredientNames.Add("Bread");
            ingredientNames.Add("Butter");
            ingredientNames.Add("Tomato");
            (this.recipes).Add(new Recipe("Tomato sandwich", ingredientNames,5));

            // --

            ingredientNames.Clear();

            ingredientNames.Add("Bread");
            ingredientNames.Add("Weiner");
            ingredientNames.Add("Ketchup");
            (this.recipes).Add(new Recipe("Hot dog", ingredientNames,7));

            this.Display_Recipes();
        }

        /// <summary> 
        /// Outputs the price of a named dish. </summary>
        /// <param name="dishName"> Name of dish to be price-checked.</param>
        public int Name_To_Price( string dishName )
        {
            for( int i = 0; i<this.recipes.Count; i++ )
            {
                if (recipes[i].Return_Name() == dishName) return recipes[i].Return_price();
            }

            Console.WriteLine("CookBook::Name_To_Price(): there is no dish named \"{0}\".", dishName);
            return -1;
        }

        /// <summary> 
        /// List missing ingredients in the fridge, needed to finish the named dish. </summary>
        /// <param name="dishName"> Dish to be compared with fridge's contents.</param>
        /// <param name="fridge"> Fridge to be scanned for ingredients.</param>
        public List<string> List_Missing_Ingredients( string dishName, Fridge fridge )
        {
            List<string> outputList = new List<string>();

            int n = recipes.Count;

            int recipeID = -1;
            for( int i = 0; i<n; i++)
            {
                string thisRecipeName = recipes[i].Return_Name();

                if( thisRecipeName == dishName ) // find recipe with the requested name
                {
                    recipeID = i;
                    break;
                }
            }

            List<string> recipeIngredientNames = new List<string>();
            List<string> fridgeIngredientNames = fridge.Return_ingredientNames();

            if (recipeID >= 0) recipeIngredientNames = recipes[recipeID].Return_ingredientNames();
            else
            {
                Console.WriteLine("Zero recipes with name \"{0}\" found.",dishName);
                return outputList; // return false if there are no recipes with the requested name
            }


            int nrec = recipeIngredientNames.Count;
            int nfri = fridgeIngredientNames.Count;


            for( int i = 0; i<nrec; i++ )
            {
                bool thisIngredientFound = false;
                for( int j = 0; j<nfri; j++)
                {
                    if (showComments) Console.WriteLine("- Comparing {0} and {1} ...",recipeIngredientNames[i], fridgeIngredientNames[j]);
                    

                    if ( recipeIngredientNames[i]== fridgeIngredientNames[j]) // find in fridge the #i inredient listed in the recipe
                    {
                        thisIngredientFound = true;
                        break;
                    }
                }

                if( thisIngredientFound == false ) outputList.Add(recipeIngredientNames[i]);

            }

            Console.WriteLine("Missing ingredients: {0}", outputList.Count);

            return outputList;
        }


        /// <summary> 
        /// (Dis)confirm that there are enough ingredients in the fridge to make the named dish. </summary>
        /// <param name="dishName"> Dish to be compared with fridge's contents.</param>
        /// <param name="fridge"> Fridge to be scanned for ingredients.</param>
        public bool Enough_Ingredients(string dishName, Fridge fridge)
        {

            int n = recipes.Count;

            int recipeID = -1;
            for (int i = 0; i < n; i++)
            {
                string thisRecipeName = recipes[i].Return_Name();

                if (thisRecipeName == dishName) // find recipe with the requested name
                {
                    recipeID = i;
                    if (showComments) Console.WriteLine("- Chosen recipe for: {0}", thisRecipeName);
                    break;
                }
            }

            /// <summary> 
            /// ... </summary>
            List<string> recipeIngredientNames = new List<string>();

            /// <summary> 
            /// ... </summary>
            List<string> fridgeIngredientNames = fridge.Return_ingredientNames();

            /// <summary> 
            /// ... </summary>
            if (recipeID >= 0) recipeIngredientNames = recipes[recipeID].Return_ingredientNames();
            else
            {
                Console.WriteLine("Zero recipes with name \"{0}\" found.", dishName);
                Console.WriteLine("CookBook::Enough_Ingredients() - return false");
                return false; // return false if there are no recipes with the requested name
            }

            int nrec = recipeIngredientNames.Count;

            int nfri = fridgeIngredientNames.Count;

            int foundIngredients = 0;

            for (int i = 0; i < nrec; i++)
            {
                for (int j = 0; j < nfri; j++)
                {
                    if (showComments) Console.WriteLine("- Comparing {0} and {1} ...", recipeIngredientNames[i], fridgeIngredientNames[j]);


                    if (recipeIngredientNames[i] == fridgeIngredientNames[j]) // find in fridge the #i inredient listed in the recipe
                    {
                        if (showComments) Console.WriteLine("Found fridge ingredient: {0}", fridgeIngredientNames[j]);
                        foundIngredients++;
                        break;
                    }
                }

                if (showComments) Console.WriteLine("Found {0} ingredients.", foundIngredients);
                if (foundIngredients == nrec)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary> 
        /// Return the list of ingredients in the recipe. </summary>
        /// <param name="dishName"> Dish which's ingredients are to be returned.</param>
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

        /// <summary> 
        /// Display all recipes in the cook book. </summary>
        public void Display_Recipes()
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

        /// <summary> 
        /// Return the list of recipes. </summary>
        public List<Recipe> getRecipesList()
        {
            return recipes;
        }

        /// <summary> 
        /// Return the dish names. </summary>
        public List<string> getDishNames()
        {
            List<String> recipesNames = new List<string>();
            //MessageBox.Show(recipes.Count.ToString());
            foreach (Recipe recipe in recipes)
            {
                String name = recipe.name;
                recipesNames.Add(name);
            }
            return recipesNames;
        }

        

    }
}
