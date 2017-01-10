using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    /// <summary> 
    /// Contains a list of ingredients it is made of. </summary>
    public class Dish
    {
        /// <summary> 
        /// Class constructor. </summary>
        /// <param name="dishName"> Dish which's ingredients are to be returned.</param>
        public Dish(string dishName, List<Ingredient> ingredients, int price )
        {
            this.dishName = dishName;
            this.ingredients = new List<Ingredient>(ingredients);
            this.price = price;
            takeIngredients();
        }

        /// <summary> 
        /// Reduces the number of each ingredient. </summary>
        private void takeIngredients()
        {
            foreach (Ingredient ingredient in ingredients)
            {
                ingredient.reduceNumber();
            }
        }

        /// <summary> 
        /// Returns the dish's name. </summary>
        public string Return_Name()
        {
            return this.dishName;
        }

        /// <summary> 
        /// Returns the dish's price. </summary>
        public int Return_Price()
        {
            return this.price;
        }

        /// <summary> 
        /// Name of the dish. </summary>
        public string dishName { get; set; }

        /// <summary> 
        /// List of ingredients that make this dish. </summary>
        public List<Ingredient> ingredients { get; set; } = new List<Ingredient>();

        /// <summary> 
        /// Price of this dish. </summary>
        public int price { get; set; }
    }
}
