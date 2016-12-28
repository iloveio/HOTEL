using System;
using System.Collections.Generic;
using System.Windows.Input;
using BookingLibrary.TempDatabase;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace BookingApp.ViewModel
{
    public class RoomSearchViewModel : ViewModelBase
    {
        public RoomSearchViewModel()
        {
            RoomDetails = new List<uint> {1, 2, 3, 4};  //very clever method for binding number of rooms/size in xaml
            SelectedRoom = new Room();
            SearchCommand = new RelayCommand(SaveDesirableRoom);
            //MessengerInstance.Register<PropertyChangedMessage<Room>>(this, SearchSelectedRoomChanged);
        }
        #region Properties
        public Room SelectedRoom { get; set; }
        public List<uint> RoomDetails { get; set; } 
        public string Size { get; set; }
        public string NumberOfRooms { get; set; }
        public bool isTv { get; set; }
        public bool isBalcony { get; set; }
        public bool hasOutlook { get; set; }
        #endregion
        public ICommand SearchCommand { get; }
        //private void SearchSelectedRoomChanged(PropertyChangedMessage<Room> propertyDetail)
        //{
        //    if (propertyDetail.PropertyName != "SelectedRoom") return;
        //    SelectedRoomID = propertyDetail.NewValue;
        //    RaisePropertyChanged(() => SelectedRoomID);
        //}

        private void SaveDesirableRoom()
        {
            SelectedRoom.Size = UInt32.Parse(Size);
            SelectedRoom.NumberOfRooms = UInt32.Parse(NumberOfRooms);  
            SelectedRoom.IsBalcony = isBalcony;
            SelectedRoom.IsTv = isTv;
            SelectedRoom.HasOutlook = hasOutlook;
        }
    }
}