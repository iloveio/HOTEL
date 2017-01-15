////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	DireCtorInstanceTest.cs
//
// summary:	Implements the dire constructor instance test class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HumanResourcesLib;
using System.Collections.Generic;

namespace HumanResourcesLibTests
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   (Unit Test Class) a dire constructor instance test. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    [TestClass]
    public class DireCtorInstanceTest
    {
        /// <summary>   The test director. </summary>
        private Director testDirector;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   (Unit Test Method) creating direcotr. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void CreatingDirecotr()
        {
            Director dyr = new Director("asd", "asda", 1, new List<Employee>(), "asd", "asda");
            dyr.HireAnEmployee("1123", "qweq", 1, new EmployeeStatus(EmployeeStatusName.ErnedLeave, DateTime.Now, DateTime.Now), 11f, new List<Job>(), "aaa", "aa", Postion.Accounting);
        }
    }
}
