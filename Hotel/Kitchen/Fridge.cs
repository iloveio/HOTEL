////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Fridge.cs
//
// summary:	Implements the fridge class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A fridge. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class Fridge
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Fridge()
        {
            this.Add_Ingredient("Tomato");
            this.Add_Ingredient("Bread");
            this.Add_Ingredient("Butter");

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Adds an ingredient. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="name"> The name. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Add_Ingredient( string name )
        {
            this.ingredients.Add(new Ingredient(name));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Request ingredients. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="orderNames">   List of names of the orders. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Request_Ingredients(List<string> orderNames)
        {
            Console.WriteLine("Request.");
            // send list of names to outside database.
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Returns the ingredients. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <returns>   The ingredients. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<Ingredient> Return_Ingredients()
        {
            return this.ingredients;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Returns ingredient names. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <returns>   The ingredient names. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<string> Return_ingredientNames()
        {
            List<string> ingredientNames = new List<string>();
            int n = ingredients.Count;
            for( int i = 0; i<n; i++ )
            {
                string thisName = ingredients[i].Return_Name();
                ingredientNames.Add(thisName);
            }

            return ingredientNames;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Adds the ingredients. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="namedIngredients"> The named ingredients. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Add_Ingredients(List<string> namedIngredients)
        {
            // convert names to Ingredients

            for (int i = 0; i < namedIngredients.Count; i++)
            {
                ingredients.Add(new Ingredient(namedIngredients[i]));
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Removes the ingredient described by name. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="name"> The name. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Remove_Ingredient( string name )
        {
            int n = this.ingredients.Count;
            int found = -1;

            for( int i = 0; i<n; i++)
            {
                if (this.ingredients[i].Return_Name() == name)
                {
                    found = i;
                    break;
                }
            }

            if (found >= 0) this.ingredients.RemoveAt(found);
            else Console.WriteLine("[Fridge::Remove_Ingredient(): Couldn't find the {0} in the Fridge.]", name);
        }

        /// <summary>   The ingredients. </summary>
        private List<Ingredient> ingredients = new List<Ingredient>();
    }
}
