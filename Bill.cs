using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Bill
    {
        public Bill(int billID, List<Dish> dishes)
        {
            this.billID = billID;
            this.dishes = dishes;
        }

        private int billID;
        private List<Dish> dishes;
    }
}
