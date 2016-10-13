using BookingLibrary;
using BookingLibrary.TempDatabase;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace BookingApp.ViewModel
{
    public class RoomDescriptionViewModel : ViewModelBase
    {
        public RoomDescriptionViewModel()
        {
            MessengerInstance.Register<PropertyChangedMessage<int>>(this, SearchSelectedRoomChanged);
        }

        public Room SelectedRoom { get; set; }

        private void SearchSelectedRoomChanged(PropertyChangedMessage<int> propertyDetail)
        {
            if (propertyDetail.PropertyName == "SelectedRoom")
                LoadRoomFromModel(propertyDetail.NewValue);
        }

        private void LoadRoomFromModel(int selectedRoom)
        {
            SelectedRoom = ModelController.Instance.GetRoom(selectedRoom);
            RaisePropertyChanged(() => SelectedRoom);
        }
    }
}