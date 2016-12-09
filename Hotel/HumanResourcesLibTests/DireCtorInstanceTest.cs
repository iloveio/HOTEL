using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HumanResourcesLib;
using System.Collections.Generic;

namespace HumanResourcesLibTests
{
    [TestClass]
    public class DireCtorInstanceTest
    {
        private Director testDirector;
        [TestMethod]
        public void CreatingDirecotr()
        {
            Director.InstantiateDirector("TestName","Last",0,new List<Employee>());
            testDirector = Director.GetInstance;
            Assert.AreNotEqual(null, testDirector);
        }
    }
}
