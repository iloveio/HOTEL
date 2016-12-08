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
                billsList = query.ToList<Bill>();
            }
        }

        public void AddNewBill(Bill bill)
        {
            using (var db = new AccountancyContext())
                db.Bills.Add(bill);
        }

        public void DeleteBillByObject(Bill bill)
        {
            using (var db = new AccountancyContext())
                db.Bills.Remove(bill);
        }

        public List<Bill> GetBillsList()
        {
            return billsList;
        }
    }
}
