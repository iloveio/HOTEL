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
            MessengerInstance.Register<PropertyChangedMessage<Room>>(this, SearchSelectedRoomChanged);
        }

        public Room SelectedRoom { get; set; }

        private void SearchSelectedRoomChanged(PropertyChangedMessage<Room> propertyDetail)
        {
            if (propertyDetail.PropertyName != "SelectedRoom") return;
            SelectedRoom = propertyDetail.NewValue;
            RaisePropertyChanged(() => SelectedRoom);
        }
    }
}