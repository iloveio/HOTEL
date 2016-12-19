////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Dish.cs
//
// summary:	Implements the dish class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A dish. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class Dish
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="dishName">     Name of the dish. </param>
        /// <param name="ingredients">  The ingredients. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Dish(string dishName, List<Ingredient> ingredients)
        {
            this.dishName = dishName;
            this.ingredients = new List<Ingredient>(ingredients);            
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
            return this.dishName;
        }

        /// <summary>   Name of the dish. </summary>
        private string dishName;
        /// <summary>   The ingredients. </summary>
        private List<Ingredient> ingredients = new List<Ingredient>();
    }
}
