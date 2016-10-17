using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    

    class Ingredient
    {
        public Ingredient(string name)
        {
            this.name = name;
        }

        public string Name()
        {
            return this.name;
        }

        private string name;
    }
}
