////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Database\Accountancy\AccountancyManager.cs
//
// summary:	Implements the accountancy manager class
////////////////////////////////////////////////////////////////////////////////////////////////////

using Hotel.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Hotel.Database
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Manager for accountancies. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class AccountancyManager
    {
        /// <summary>   List of bills. </summary>
        public List<Bill> billsList { get; set; }

        public AccountancyManager()
        {
            billsList = new List<Bill>();

            FillDataWithAllBills();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Fill data with all bills. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void FillDataWithAllBills()
        {
            //XmlSerializer deserializer = new XmlSerializer(typeof(List<Bill>));
            //TextReader reader = new StreamReader(@"./billXML.xml");
            //object obj = deserializer.Deserialize(reader);
            //billsList = (List<Bill>)obj;
            //reader.Close();

            try
            {
                MyXmlSerializer<List<Bill>> serialzier = new MyXmlSerializer<List<Bill>>();
                billsList = serialzier.ReadObject(@"./billXML.xml");
            }
            catch (Exception ex)
            {

            }
        }

        public void SerializeBills()
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(List<Bill>));
            //using (TextWriter writer = new StreamWriter(@"./billXML.xml"))
            //{
            //    serializer.Serialize(writer, billsList);
            //}

            MyXmlSerializer<List<Bill>> ser = new MyXmlSerializer<List<Bill>>();
            ser.WriteObject(@"billXML.xml", billsList);
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
            billsList.Add(bill);
            SerializeBills();
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
            billsList.Remove(bill);
            SerializeBills();
        }

        public void UpdateTransport(Bill trans, Bill newVal)
        {
            billsList[billsList.IndexOf(trans)] = newVal;
            SerializeBills();
        }
    }
}
