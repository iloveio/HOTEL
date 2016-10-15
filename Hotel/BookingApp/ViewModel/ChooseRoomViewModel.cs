using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace BookingApp.ViewModel
{
    public class ChooseRoomViewModel : ViewModelBase
    {
        public ChooseRoomViewModel()
        {
            ChangeSelectedRoomCommand = new RelayCommand<int>(ChangeSelectedRoom);
            ChangeSelectedFloorCommand = new RelayCommand<int>(ChangeSelectedFloor);
            SelectedFloor = 1;
        }


        public int SelectedRoom { get; set; }

        public int SelectedFloor { get; set; }

        public ICommand ChangeSelectedRoomCommand { get; set; }
        public ICommand ChangeSelectedFloorCommand { get; set; }

        private void ChangeSelectedRoom(int roomId)
        {
            SelectedRoom = roomId + SelectedFloor * 100;
            MessengerInstance.Send(new PropertyChangedMessage<int>(0, SelectedRoom, "SelectedRoom"));
        }

        private void ChangeSelectedFloor(int floorId)
        {
            SelectedFloor = floorId;
        }
    }
}