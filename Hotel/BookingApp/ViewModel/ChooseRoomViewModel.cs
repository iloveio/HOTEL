////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	viewmodel\chooseroomviewmodel.cs
//
// summary:	Implements the chooseroomviewmodel class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using BookingApp.Model;
//using Hotel.Database;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Hotel.Database;

namespace BookingApp.ViewModel
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A ViewModel for the choose room. </summary>
    ///
    /// <remarks>   Radek, 08.01.2017. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class ChooseRoomViewModel : ViewModelBase
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Radek, 08.01.2017. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public ChooseRoomViewModel()
        {
            //ChangeSelectedRoomCommand = new RelayCommand<int>(ChangeSelectedRoom);
            //ChangeSelectedFloorCommand = new RelayCommand<int>(ChangeSelectedFloor);
            //SelectedFloor = 1;
            Rooms = ModelController.Instance.GetRooms();
            Messenger.Default.Register<UpdateListView>(this, UncheckSelectedRoom);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Uncheck selected room. </summary>
        ///
        /// <remarks>   Radek, 08.01.2017. </remarks>
        ///
        /// <param name="obj">  The object. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void UncheckSelectedRoom(UpdateListView obj)
        {
            SelectedRoom = null;
            ModelController.Instance.SelectedRoomID = 0;
        }

        //private void FilterList(UpdateListView action)
        //{
        //    Rooms = (from r in Rooms
        //             where r.ToString() == action.PreferredRoom.ToString()
        //             select r).ToList();
        //}

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the rooms. </summary>
        ///
        /// <value> The rooms. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

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

        /// <summary>   The selected room. </summary>
        private Room selectedRoom;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Executes the property changed action. </summary>
        ///
        /// <remarks>   Radek, 08.01.2017. </remarks>
        ///
        /// <param name="e">    Event information to send to registered event handlers. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (SelectedRoom == null) return;
            ModelController.Instance.SelectedRoomID = SelectedRoom.RoomNumber;
            //PropertyChanged?.Invoke(this, e);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Executes the property changed action. </summary>
        ///
        /// <remarks>   Radek, 08.01.2017. </remarks>
        ///
        /// <param name="propertyName"> Name of the property. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the selected room. </summary>
        ///
        /// <value> The selected room. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

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