////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	ModelControllerTests.cs
//
// summary:	Implements the model controller tests class
////////////////////////////////////////////////////////////////////////////////////////////////////

using BookingLibrary;
using BookingLibrary.TempDatabase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookingLibraryUnitTests
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   (Unit Test Class) a model controller tests. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    [TestClass]
    public class ModelControllerTests
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   (Unit Test Method) tests model controller singleton. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void ModelControllerSingletonTest()
        {
            var modelController = ModelController.Instance;
            Assert.IsNotNull(modelController);
            Assert.IsInstanceOfType(modelController, typeof(ModelController));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   (Unit Test Method) tests get user name. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

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

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   (Unit Test Method) tests get room query. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void GetRoomQueryTest()
        {
            var testRoom = ModelController.Instance.GetRoom(2);
            Assert.IsNotNull(testRoom);
            Assert.IsInstanceOfType(testRoom, typeof(Room));
          //  Assert.AreEqual(2, testRoom.Id);
            Assert.AreEqual(5, testRoom.FloorNumber);
        }
    }
}