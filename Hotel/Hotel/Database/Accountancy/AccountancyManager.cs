using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database.Accountancy
{
    class AccountancyManager
    {
        List<Bill> billsList;

        public void FillDataWithAllBills()
        {
            using (var db = new AccountancyContext())
            {
                var query = from b in db.Bills
                            select b;

                foreach (var bill in query)
                {
                    billsList = query.ToList<Bill>();
                }
            }
        }

        public List<Bill> GetBillsList()
        {
            return billsList;
        }
    }
}
