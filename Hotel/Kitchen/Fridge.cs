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
            this.Add_Ingredient("Tomato");
            this.Add_Ingredient("Bread");
            this.Add_Ingredient("Butter");

        }

        public void Add_Ingredient( string name )
        {
            this.ingredients.Add(new Ingredient(name));
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

        public void Add_Ingredients(List<string> namedIngredients)
        {
            // convert names to Ingredients

            for (int i = 0; i < namedIngredients.Count; i++)
            {
                ingredients.Add(new Ingredient(namedIngredients[i]));
            }
        }

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

        private List<Ingredient> ingredients = new List<Ingredient>();
    }
}
