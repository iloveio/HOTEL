using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Bill
    {
        public Bill(int billID, int customerID, List<Dish> dishes)
        {
            this.billID = billID;
            this.dishes = dishes;
        }

        private int billID;
        private int customerID;
        private List<Dish> dishes;
    }
}
