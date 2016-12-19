////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Recipe.cs
//
// summary:	Implements the recipe class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A recipe. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class Recipe
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="name">             The name. </param>
        /// <param name="ingredientNames">  List of names of the ingredients. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Recipe(string name, List<string> ingredientNames )
        {
            this.name = name;
            this.ingredientNames = new List<string>(ingredientNames);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Returns the name. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <returns>   The name. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Return_Name()
        {
            return this.name;
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
            return this.ingredientNames;
        }

        /// <summary>   The name. </summary>
        private string name;
        /// <summary>   List of names of the ingredients. </summary>
        private List<string> ingredientNames;
    }
}
