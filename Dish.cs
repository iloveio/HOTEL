using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Dish
    {
        public Dish(string dishName, List<Ingredient> ingredients)
        {
            this.dishName = dishName;
            this.ingredients = new List<Ingredient>(ingredients);            
        }

        public string Return_Name()
        {
            return this.dishName;
        }

        private string dishName;
        private List<Ingredient> ingredients = new List<Ingredient>();
    }
}
