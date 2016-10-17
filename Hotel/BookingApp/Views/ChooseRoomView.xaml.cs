using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using BookingLibrary;
using BookingLibrary.TempDatabase;

namespace BookingApp.Views
{
    /// <summary>
    ///     Interaction logic for ChooseRoomView.xaml
    /// </summary>
    public partial class ChooseRoomView : UserControl
    {
        /// <summary>
        /// OK, so what i did here is TOTALL SHIT !!! NEVER DO IT LIKE THIS
        /// ...
        /// ...
        /// ...but it works....
        /// </summary>
        /// TODO: GET RID OF IT!!!!

        private readonly List<Button> buttons;
        private int selectedFloor;
        private readonly List<Room> rooms;

        public ChooseRoomView()
        {
            InitializeComponent();

            selectedFloor = 1;

            buttons = new List<Button> {Room1Button, Room2Button};
            rooms = ModelController.Instance.GetRooms();
            ProcessButtonsBackgroundChange();
        }

        private void ProcessButtonsBackgroundChange()
        {
            foreach (var button in buttons)
            {
                var room = (from r in rooms
                           where r.RoomNumber == Convert.ToInt32(button.Uid) + selectedFloor * 100
                           select r).First();
                button.Background = room.IsEmpty ? Brushes.Green : Brushes.Red;
            }
        }

        private void FloorButton_OnCLick(object sender, RoutedEventArgs e)
        {
            var b = sender as Button;
            selectedFloor = Convert.ToInt32(b.Uid);
            ProcessButtonsBackgroundChange();
        }
    }
}