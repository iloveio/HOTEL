using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Bills
    {
        public Bills() {}

        public void Add_Bill(Bill bill)
        {
            this.bills.Add(bill);
        }

        private List<Bill> bills;
    }
}
