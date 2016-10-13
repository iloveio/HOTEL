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
            ChangeSelectedRoomCommand = new RelayCommand(ChangeSelectedRoom);
            ChangeSelectedRoomCommand2 = new RelayCommand(ChangeSelectedRoom2);
        }

        public int SelectedRoom { get; set; }

        public ICommand ChangeSelectedRoomCommand { get; set; }

        public ICommand ChangeSelectedRoomCommand2 { get; set; }

        private void ChangeSelectedRoom()
        {
            SelectedRoom = 1;
            MessengerInstance.Send(new PropertyChangedMessage<int>(0, SelectedRoom, "SelectedRoom"));
        }

        private void ChangeSelectedRoom2()
        {
            SelectedRoom = 45;
            MessengerInstance.Send(new PropertyChangedMessage<int>(0, SelectedRoom, "SelectedRoom"));
        }
    }
}