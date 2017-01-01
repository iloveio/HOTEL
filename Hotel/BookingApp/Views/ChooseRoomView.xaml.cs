using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using BookingApp.Model;
using BookingLibrary;
using BookingLibrary.TempDatabase;
using GalaSoft.MvvmLight.Messaging;

namespace BookingApp.Views
{
    /// <summary>
    ///     Interaction logic for ChooseRoomView.xaml
    /// </summary>
    public partial class ChooseRoomView : UserControl
    {
        public ChooseRoomView()
        {
            InitializeComponent();
            Messenger.Default.Register<UpdateListView>(this, FilterList);
        }

        private void FilterList(UpdateListView action)
        {
            roomsListView.ItemsSource = null;
            if (action.PreferredRoom != null)
            {
                var filterList = (from r in ModelController.Instance.GetRooms()
                                  where (r.IsTv == action.PreferredRoom.IsTv
                                 && r.HasOutlook == action.PreferredRoom.HasOutlook
                                 && r.IsBalcony == action.PreferredRoom.IsBalcony
                                 && r.NumberOfRooms == action.PreferredRoom.NumberOfRooms
                                 && r.Size == action.PreferredRoom.Size)
                                  select r).ToList();
                roomsListView.ItemsSource = filterList;
            }
            else
            {
                roomsListView.ItemsSource = ModelController.Instance.GetRooms();
            }

        }
    }
}