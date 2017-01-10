using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    /// <summary> 
    /// List of ingredients to make a named dish, plus its price. </summary>
    public class Recipe
    {
        /// <summary> 
        /// Class constructor. </summary>
        /// <param name="name"> Name of the recipe's dish.</param>
        /// <param name="ingredientNames"> Names of the recipe's ingredients.</param>
        /// <param name="price"> Price of the recipe's dish.</param>
        public Recipe(string name, List<string> ingredientNames, int price )
        {
            this.name = name;
            this.ingredientNames = new List<string>(ingredientNames);
            this.price = price;
        }

        /// <summary> 
        /// Return recipe's dish's name. </summary>
        public string Return_Name()
        {
            return this.name;
        }

        /// <summary> 
        /// Return names of recipe's ingredients. </summary>
        public List<string> Return_ingredientNames()
        {
            return this.ingredientNames;
        }

        /// <summary> 
        /// Return the recipe's dish's price. </summary>
        public int Return_price()
        {
            return this.price;
        }

        /// <summary> 
        /// Name of the dish in the recipe. </summary>
        public string  name { get; set; }

        /// <summary> 
        /// Names of the ingredients in the recipe. </summary>
        public List<string> ingredientNames { get; set; }

        /// <summary> 
        /// Price of the dish in the recipe. </summary>
        public int price { get; set; }
    }
}
