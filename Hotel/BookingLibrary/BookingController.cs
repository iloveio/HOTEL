using BookingLibrary.TempDatabase;
using System.Collections.Generic;

namespace BookingLibrary
{
    public class BookingController
    {
        #region Props
        private ModelController modelController;
        private User user;
        private List<Room> rooms;
        #endregion

        #region Methods
        public BookingController(ModelController modelController)
        {
            this.modelController = modelController;
            GetUser();
            GetRooms();
        }

        private User GetUser()
        {
            return modelController.GetUser();
        }

        private List<Room> GetRooms()
        {
            return modelController.GetRooms();
        } 
        #endregion
    }
}