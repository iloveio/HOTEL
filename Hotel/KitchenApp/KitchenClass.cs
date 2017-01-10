using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    /// <summary> 
    /// Contains top-level classes used for the kitchen's simulation. </summary>
    public class KitchenClass
    {
        /// <summary> 
        /// List of bills. </summary>
        public Bills bills = new Bills();

        /// <summary> 
        /// Kitchen's fridge. </summary>
        public Fridge fridge = new Fridge();

        /// <summary> 
        /// Kitchen's cook book. </summary>
        public CookBook cookBook = new CookBook();

        /// <summary> 
        /// Kitchen's chef. </summary>
        public Chef chef;

        /// <summary> 
        /// Newest customer's Identification Number. </summary>
        public int newestCustomerID = 0;

        /// <summary> 
        /// Class constructor. </summary>
        public KitchenClass()
        {
            chef = new Chef(fridge, cookBook, bills);
        }

        /// <summary> 
        /// Order a dish to be put on the newly-created bill. </summary>
        /// <param name="dishName"> Name of dish to be ordered</param>
        public List<string> Order_Dish(string dishName)
        {
            List<string> missingIngredientsNames = cookBook.List_Missing_Ingredients(dishName, fridge);

            if (missingIngredientsNames.Count == 0)
            {
                bills.Add_Dish_To_Newest_Bill(chef.Make_Dish(dishName));
            }
            else
            {
                Console.WriteLine(" Missing ingredients to make the \"{0}\" dish:", dishName);
                for (int i = 0; i < missingIngredientsNames.Count; i++)
                {
                    Console.WriteLine(" - {0}", missingIngredientsNames[i]);
                }

                
            }

            return missingIngredientsNames;
        }

        /// <summary> 
        /// Call the CookBook's method of the same name, to list ingredients that are missing from the fridge, to make the named dish. </summary>
        /// <param name="dishName"> Name of dish for the fridge to be checked against.</param>
        public List<string> List_Missing_Ingredients( string dishName )
        {
            return this.cookBook.List_Missing_Ingredients(dishName, this.fridge);
        }

        /// <summary> 
        /// Create a new bill for the customer whose ID number is given. </summary>
        /// <param name="customerID"> Identification number of the customer.</param>
        public void New_Bill_For_Customer( int customerID )
        {
            bills.Add_Bill(customerID);
        }

        /// <summary> 
        /// Return all bills. </summary>
        public String Display_Bills()
        {
            return bills.Display_Bills();

        }

        /// <summary> 
        /// Return the list of bills. </summary>
        public Bills returnBillsList()
        {
            return bills;
        }


    }
}
