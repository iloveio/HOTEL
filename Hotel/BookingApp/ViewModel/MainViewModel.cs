////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	ViewModel\MainViewModel.cs
//
// summary:	Implements the main view model class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows;
using System.Windows.Input;
using BookingApp.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace BookingApp.ViewModel
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A ViewModel for the main. </summary>
    ///
    /// <remarks>   Radek, 15.01.2017. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class MainViewModel : ViewModelBase
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Radek, 15.01.2017. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public MainViewModel()
        {
            OpenCalendarCommand = new RelayCommand(OpenCalendarWindow);
            OpenCleaningCommand = new RelayCommand(OpenCleaningWindow);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the open calendar command. </summary>
        ///
        /// <value> The open calendar command. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public ICommand OpenCalendarCommand { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the open cleaning command. </summary>
        ///
        /// <value> The open cleaning command. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public ICommand OpenCleaningCommand { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Opens calendar window. </summary>
        ///
        /// <remarks>   Radek, 15.01.2017. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        void OpenCalendarWindow()
        {
            if (!CheckIfRoomSelected()) return;
            CalendarWindowManager calendarWindowManager = new CalendarWindowManager();
            calendarWindowManager.Show();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Opens cleaning window. </summary>
        ///
        /// <remarks>   Radek, 15.01.2017. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        void OpenCleaningWindow()
        {
            if (!CheckIfRoomSelected()) return;
            CleaningWindowManager cleaningWindowManager = new CleaningWindowManager();
            cleaningWindowManager.Show();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if room selected. </summary>
        ///
        /// <remarks>   Radek, 15.01.2017. </remarks>
        ///
        /// <returns>   True if it succeeds, false if it fails. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private bool CheckIfRoomSelected()
        {
            if (ModelController.Instance.SelectedRoomID == 0)
            {
                MessageBox.Show("Nie wybrano pokoju");
                return false;
            }
            return true;
        }
    }
}