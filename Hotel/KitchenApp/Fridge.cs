using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kitchen
{
    /// <summary> 
    /// Hold ingredients, and operates on them. </summary>
    public class Fridge
    {
        /// <summary> 
        /// Class constructor. </summary>
        public Fridge()
        {
            this.Add_Ingredient("Tomato");
            this.Add_Ingredient("Bread");
            this.Add_Ingredient("Onion");
            this.Add_Ingredient("Butter");            
            this.Add_Ingredient("Ketchup");
            this.Add_Ingredient("Weiner");
        }

        /// <summary> 
        /// Add a named ingredient. </summary>
        /// <param name="name"> Name of the ingredient to be added.</param>
        public void Add_Ingredient( string name )
        {
            this.ingredients.Add(new Ingredient(name, 15));
        }

        /// <summary> 
        /// Return a collection of ingredients. </summary>
        public ObservableCollection<Ingredient> Return_Ingredients()
        {
            return this.ingredients;
        }

        /// <summary> 
        /// Return the names of ingredients. </summary>
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

        /// <summary> 
        /// Add a list of ingredients. </summary>
        /// <param name="namedIngredients"> Names of ingredients to be added.</param>
        public void Add_Ingredients(List<string> namedIngredients)
        {
            // convert names to Ingredients

            for (int i = 0; i < namedIngredients.Count; i++)
            {
                ingredients.Add(new Ingredient(namedIngredients[i], 15));
            }
        }

        /// <summary> 
        /// Remove a named ingredient. </summary>
        /// <param name="name"> Name of the ingredient to be removed.</param>
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

        /// <summary> 
        /// Reduce the "number" attrubutes of every named ingredient. </summary>
        /// <param name="ingToReduce"> Ingredients to have their "number" attribute reduced.</param>
        public void reduceIngredient(List<Ingredient> ingToReduce )
        {
            foreach (Ingredient toReduceIngredient in ingToReduce)
            {
                foreach (Ingredient ingredient in ingredients)
                {
                    if (ingredient.name == toReduceIngredient.name)
                    {
                        ingredient.number -= 1;
                    }

                }
            }
        }

        /// <summary> 
        /// Limit the number the to-be-ordered ingredients. </summary>
        public bool numberOfIngredientsControl()
        {
            List<string> ingredientsToOrder = new List<string>();
            foreach (Ingredient ingredient in ingredients)
            {
                if (ingredient.number < 5)
                {
                    ingredientsToOrder.Add(ingredient.name);
                }
            }

            if (ingredientsToOrder.Count > 0)
            {
                MessageBox.Show("Brak Skladnika!");
                //SendIngredientsListToOrder(ingredientsToOrder);
                return false;
            }
            else return true;

        }

        /// <summary> 
        /// Send the list of ingredients' names that are to be ordered. </summary>
        /// <param name="ingredientsToOrder"> Names of ingredients to be ordered.</param>
        private void SendIngredientsListToOrder(List<String> ingredientsToOrder )
        {
            throw new NotImplementedException(); //TUTAAJ ZAIMPLEMENTOWAC WYSYLANIE DO TRANSPORTU
        }

        public void RefillIngredientsNumber(List<Ingredient> ingredientsFromTransport)
        {
            foreach (var shop in ingredientsFromTransport)
            {
                foreach (Ingredient ingredient in ingredients)
                {
                    if (ingredient.name == shop.name)
                        ingredient.number += shop.number;
                }
            }
            this.CheckIfCanSimulationGoOn();
        }

        private void CheckIfCanSimulationGoOn()
        {
            bool flag = true;
            foreach (Ingredient ingredient in ingredients)
            {
                if (ingredient.number < 5)
                    numberOfIngredientsControl();
                else
                {
                    Controller.Instance.StartSimulation();
                }
            }
        }

        /// <summary> 
        /// Collection of ingredients. </summary>
        private ObservableCollection<Ingredient> ingredients = new ObservableCollection<Ingredient>();

    }
}
