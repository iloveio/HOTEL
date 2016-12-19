////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Database\Accountancy\AccountancyManager.cs
//
// summary:	Implements the accountancy manager class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database.Accountancy
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Manager for accountancies. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class AccountancyManager
    {
        /// <summary>   List of bills. </summary>
        List<Bill> billsList;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Fill data with all bills. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void FillDataWithAllBills()
        {
            using (var db = new AccountancyContext())
            {
                var query = from b in db.Bills
                            select b;
                billsList = query.ToList<Bill>();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Adds a new bill. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="bill"> The bill. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void AddNewBill(Bill bill)
        {
            using (var db = new AccountancyContext())
            {
                db.Bills.Add(bill);
                db.SaveChanges();
            }
            FillDataWithAllBills();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Deletes the bill by object described by bill. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="bill"> The bill. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DeleteBillByObject(Bill bill)
        {
            using (var db = new AccountancyContext())
            {
                db.Bills.Remove(bill);
                db.SaveChanges();
            }
            FillDataWithAllBills();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets bills list. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <returns>   The bills list. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<Bill> GetBillsList()
        {
            return billsList;
        }
    }
}
