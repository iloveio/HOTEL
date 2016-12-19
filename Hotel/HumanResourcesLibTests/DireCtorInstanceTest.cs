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
            Director.InstantiateDirector("TestName","Last",0,new List<Employee>());
            testDirector = Director.GetInstance;
            Assert.AreNotEqual(null, testDirector);
        }
    }
}
