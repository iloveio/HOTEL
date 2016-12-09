using System.Collections.Generic;
using System.Windows.Input;
using BookingLibrary;
using BookingLibrary.TempDatabase;
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
            Rooms = ModelController.Instance.GetRooms();
        }

        public List<Room> Rooms { get; set; }
        public Room SelectedRoom { get; set; }

        public int SelectedFloor { get; set; }

        public ICommand ChangeSelectedRoomCommand { get; set; }
        public ICommand ChangeSelectedFloorCommand { get; set; }

        private void ChangeSelectedRoom(int roomId)
        {
            SelectedRoom = ModelController.Instance.GetRoom(roomId + SelectedFloor * 100);
            MessengerInstance.Send(new PropertyChangedMessage<Room>(SelectedRoom, SelectedRoom, "SelectedRoom"));
        }

        private void ChangeSelectedFloor(int floorId)
        {
            SelectedFloor = floorId;
        }
    }
}