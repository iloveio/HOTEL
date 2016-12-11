using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Database;

namespace EntertainmentApp
{
    public class InnerEntertainment : Entertainment
    {
        public InnerEntertainment(string name, float price)
        {
            this.name = name;
            this.price = price;
        }
        
        public double computePayment(int hoursSpent )
        {
            return price * hoursSpent;
        }

        public string printReceipt(Guest guest)
        {
            return "Entertainment name: " + name + " \nPrice: " + price
                + "\nGuest: " + guest.Name + " " + guest.Surname;
        }

    }
}
