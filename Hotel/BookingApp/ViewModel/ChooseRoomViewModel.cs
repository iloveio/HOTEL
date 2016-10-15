using System;
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
        }

        public int SelectedRoom { get; set; }

        public ICommand ChangeSelectedRoomCommand { get; set; }

        private void ChangeSelectedRoom(int roomId)
        {
            SelectedRoom = roomId;
            MessengerInstance.Send(new PropertyChangedMessage<int>(0, SelectedRoom, "SelectedRoom"));
        }
    }
}