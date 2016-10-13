using BookingLibrary;
using BookingLibrary.TempDatabase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        public void GetRoomQueryTest()
        {
            var testRoom = ModelController.Instance.GetRoom(2);
            Assert.IsNotNull(testRoom);
            Assert.IsInstanceOfType(testRoom, typeof(Room));
            Assert.AreEqual(2, testRoom.Id);
            Assert.AreEqual(5, testRoom.FloorNumber);
        }
    }
}