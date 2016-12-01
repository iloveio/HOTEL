using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentApp
{
    public class InnerEntertainment : Entertainment
    {

        

        public double computePayment(int hoursSpent )
        {
            return price * hoursSpent;
        }

        public string printReceipt()
        {
            return "Entertainment name: " + name + " \nPrice: " + price;
        }

    }
}
