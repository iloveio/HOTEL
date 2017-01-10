using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    /// <summary> 
    /// Stores info on what dishes were bought by which customer, plus their total price.</summary>
    public class Bill
    {
        /// <summary> 
        /// Class constructor. </summary>
        /// <param name="customerID"> Customer's Identification Number.</param>
        public Bill(int customerID)
        {
            this.customerID = customerID;
            dishes = new List<Dish>();
            this.totalCost = 0;

        }

        /// <summary> 
        /// Adds dish to the bill. </summary>
        /// <param name="dish"> Dish to be added.</param>
        public void Add_Dish( Dish dish )
        {
            dishes.Add( dish );
            totalCost+=dish.Return_Price();
        }

        /// <summary> 
        /// Displays bill's contents. </summary>
        public string Display_Bill()
        {
            string outputString = "";
            string custID = customerID.ToString();

            int n = dishes.Count;

            outputString += "\nList of dishes in the bill of customer #";
            outputString += custID;
            outputString += ":\n";

            for(int i = 0; i<n; i++ )
            {
                outputString += "- ";
                outputString += dishes[i].Return_Name() ;
                outputString += '\n';
            }

            outputString += "\n\nTotal cost: ";
            outputString += totalCost.ToString();
            outputString += ".";

            return outputString;
        }        
        
        /// <summary> 
        /// Returns total cost of the bill. </summary>
        public int Return_TotalCost()
        {
            return this.totalCost;
        }

        /// <summary> 
        /// Returns customer's ID number. </summary>
        public int getCustomerID()
        {
            return customerID;
        }

        /// <summary> 
        /// Returns the list of dishes from the bill. </summary>
        public List<Dish> getDishesList()
        {
            return dishes;
        }

        /// <summary> 
        /// Customer's Identifictation Number. </summary>
        public int customerID { get; set; }

        /// <summary> 
        /// List of dishes on the bill.</summary>
        public List<Dish> dishes { get; set; }
        
        /// <summary> 
        /// Total cost of bill </summary>
        public int totalCost { get; set; }
    }
}
