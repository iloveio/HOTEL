using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using BookingApp.Model;
//using Hotel.Database;
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
            //ChangeSelectedRoomCommand = new RelayCommand<int>(ChangeSelectedRoom);
            //ChangeSelectedFloorCommand = new RelayCommand<int>(ChangeSelectedFloor);
            //SelectedFloor = 1;
            Rooms = ModelController.Instance.GetRooms();
        }

        public List<Room> Rooms { get; set; }
        //public Room SelectedRoomID { get; set; }

        //public int SelectedFloor { get; set; }

        //public ICommand ChangeSelectedRoomCommand { get; set; }
        //public ICommand ChangeSelectedFloorCommand { get; set; }

        //private void ChangeSelectedRoom(int roomId)
        //{
        //    //SelectedRoomID = ModelController.Instance.GetRoom(roomId + SelectedFloor * 100);
        //    MessengerInstance.Send(new PropertyChangedMessage<Room>(SelectedRoomID, SelectedRoomID, "SelectedRoomID"));
        //}

        //private void ChangeSelectedFloor(int floorId)
        //{
        //    SelectedFloor = floorId;
        //}

        private Room selectedRoom;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            Console.WriteLine("Hopsa hop");
            ModelController.Instance.SelectedRoomID = SelectedRoom.RoomNumber;
            //PropertyChanged?.Invoke(this, e);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        public Room SelectedRoom
        {
            get { return selectedRoom; }
            set
            {
                if (value != selectedRoom)
                {
                    selectedRoom = value;
                    OnPropertyChanged("SelectedRoom");
                }
            }
        }

        //public event PropertyChangedEventHandler PropertyChanged;
    }
}