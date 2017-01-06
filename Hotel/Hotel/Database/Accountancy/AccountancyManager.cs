using Hotel.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Hotel.Database
{

    /// <summary>
    /// Class AccountancyManager.
    /// </summary>
    public class AccountancyManager
    {
        /// <summary>
        /// Gets or sets the bills list.
        /// </summary>
        /// <value>The bills list.</value>
        public List<Bill> billsList { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountancyManager"/> class.
        /// </summary>
        public AccountancyManager()
        {
            billsList = new List<Bill>();

            FillDataWithAllBills();
        }

        /// <summary>
        /// Fills the data with all bills.
        /// </summary>
        public void FillDataWithAllBills()
        {
            try
            {
                MyXmlSerializer<List<Bill>> serialzier = new MyXmlSerializer<List<Bill>>();
                billsList = serialzier.ReadObject(@"./billXML.xml");
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Serializes the bills.
        /// </summary>
        public void SerializeBills()
        {
            MyXmlSerializer<List<Bill>> ser = new MyXmlSerializer<List<Bill>>();
            ser.WriteObject(@"billXML.xml", billsList);
        }

        /// <summary>
        /// Adds the new bill.
        /// </summary>
        /// <param name="bill">The bill.</param>
        public void AddNewBill(Bill bill)
        {
            billsList.Add(bill);
            SerializeBills();
        }

        /// <summary>
        /// Deletes the bill by object.
        /// </summary>
        /// <param name="bill">The bill.</param>
        public void DeleteBillByObject(Bill bill)
        {
            billsList.Remove(bill);
            SerializeBills();
        }

        /// <summary>
        /// Updates the bill.
        /// </summary>
        /// <param name="trans">The trans.</param>
        /// <param name="newVal">The new value.</param>
        public void UpdateBill(Bill trans, Bill newVal)
        {
            billsList[billsList.IndexOf(trans)] = newVal;
            SerializeBills();
        }
    }
}
