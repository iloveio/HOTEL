using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{

    /// <summary> 
    /// A building block of dishes. </summary>
    public class Ingredient
    {
        /// <summary> 
        /// Class constructor. </summary>
        /// <param name="name"> Ingredient's name.</param>
        /// <param name="number"> Ingredient's ID number.</param>
        public Ingredient(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        /// <summary> 
        /// Return ingredient's name. </summary>
        public string Return_Name()
        {
            return this.name;
        }

        /// <summary> 
        /// Reduce the "number" attribute by 1. </summary>
        public void reduceNumber()
        {
            this.number = this.number - 1;
        }

        /// <summary> 
        /// The ingredient's name. </summary>
        public string name { get; set; }

        /// <summary> 
        /// The ingredient's identification number. </summary>
        public int number { get; set; }
    }
}
