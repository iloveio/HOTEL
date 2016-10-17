using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Fridge
    {
        public Fridge()
        {
            Console.WriteLine("Fridge Constructor.");
            List<string> ingredientNames = new List<string>(new string[] { "Tomato", "Butter","Bread" });
            this.Add_Ingredients(ingredientNames);
        }

        public void Request_Ingredients(List<string> orderNames)
        {
            Console.WriteLine("Request.");
            // send list of names to outside database.
        }

        public List<Ingredient> Return_Ingredients()
        {
            return this.ingredients;
        }

        public void Add_Ingredients(List<string> namedIngredients)
        {
            // convert names to Ingredients
            Console.WriteLine("{0} ingredients:", namedIngredients.Count);

            for (int i = 0; i < namedIngredients.Count; i++)
            {
                ingredients.Add(new Ingredient(namedIngredients[i]));
                Console.WriteLine("{0} added.", namedIngredients[i]);
            }

            //List<Ingredient> newIngredients = Names_To_Ingredients(namedIngredients);

            //this.ingredients.AddRange(newIngredients);
        }

        public void Remove_Ingredients(List<string> namedIngredients)
        {
            // Remove ingredients based on name                                    
        }

        private List<Ingredient> ingredients = new List<Ingredient>();
    }
}
