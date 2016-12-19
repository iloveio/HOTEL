////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Database\Transportation\TransportationTestClass.cs
//
// summary:	Implements the transportation test class class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database.Transportation
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A transportation test class. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class TransportationTestClass
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Tests this object. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Test()
        {
            Transportation trans1 = new Transportation(new Employee(), DateTime.Now, "cos tam1");
            Transportation trans2 = new Transportation(new Employee(), DateTime.Now, "cos tam2");
            Transportation trans3 = new Transportation(new Employee(), DateTime.Now, "cos tam3");
            TransportationManager manager = new TransportationManager();

            manager.AddNewTransportation(trans1);
            manager.AddNewTransportation(trans2);
            manager.AddNewTransportation(trans3);

            List<Transportation> testList = manager.GetTransportationList();

            foreach(var temp in testList)
            {
                Console.WriteLine(temp.description);
            }

        }
    }
}
