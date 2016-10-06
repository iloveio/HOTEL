using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookingLibrary;

namespace BookingLibraryUnitTests
{
    [TestClass]
    public class ModelControllerTests
    {
        [TestMethod]
        public void ModelControllerSingletonTest()
        {
            var modelController = ModelController.Instance;
            Assert.IsNotNull(modelController);
            Assert.IsInstanceOfType(modelController, typeof(ModelController));
        }

        [TestMethod]
        public void GetUserNameTest()
        {
            var modelController = ModelController.Instance;
            var receivedName = modelController.Name;

            Assert.IsInstanceOfType(receivedName, typeof(string));
            Assert.AreEqual("Dupa", receivedName);

            modelController.Name = "Dupsko";

            modelController = null;
            receivedName = null;

            Assert.IsNull(modelController);
            Assert.IsNull(receivedName);

            modelController = ModelController.Instance;
            receivedName = modelController.Name;

            Assert.IsInstanceOfType(receivedName, typeof(string));
            Assert.AreEqual("Dupsko", receivedName);
        }
    }
}
