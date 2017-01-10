using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    /// <summary> 
    /// List of bills, plus functions that operate on them. </summary>
    public class Bills
    {
        /// <summary> 
        /// List of bills. </summary>
        private List<Bill> bills { get; set; }

        /// <summary> 
        /// Class constructor. </summary>
        public Bills()
        {
            this.bills = new List<Bill>();
        }

        /// <summary> 
        /// Add bill to the list. </summary>
        /// <param name="customerID"> Customer's Identification Number.</param>
        public void Add_Bill(int customerID)
        {
            this.bills.Add(new Bill(customerID));

            //return this;
        }

        /// <summary> 
        /// Display all bills. </summary>
        public string Display_Bills()
        {
            string outputString = "";
            string intString = "";
            
            for(int i = 0; i<bills.Count;i++)
            {
                intString = (i+1).ToString();

                outputString += "Bill " ;
                outputString += intString;
                outputString += "#:\n";

                outputString += bills[i].Display_Bill();
                outputString += '\n';
            }

            return outputString;
        }

        /// <summary> 
        /// Add the inputed dish to the last created bill. </summary>
        /// <param name="dish"> Dish to be added.</param>
        public void Add_Dish_To_Newest_Bill( Dish dish )
        {
            //Console.WriteLine("Added dish to newest bill.");

            Return_Last_Bill().Add_Dish(dish);
        }

        /// <summary> 
        /// Return the newest bill. </summary>
        public Bill Return_Last_Bill()
        {
            if(bills.Count>0) return bills[bills.Count - 1];

            return null;
        }

        /// <summary> 
        /// Return the list of bills. </summary>
        public List<Bill> returnBillsList()
        {
            return bills;
        }

        /// <summary> 
        /// Set the list of bills. </summary>
        /// <param name="setBills"> Bills to be set.</param>
        public void SetBillsList(List<Bill> setBills)
        {
            bills = setBills;
        }

        /// <summary> 
        /// Return income. </summary>
        public int getIncome()
        {
            int summary = 0;

            foreach (Bill bill in bills)
            {
                summary += bill.totalCost;
            }
            return summary;
        }
    }
}
