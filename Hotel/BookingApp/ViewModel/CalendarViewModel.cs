////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	viewmodel\calendarviewmodel.cs
//
// summary:	Implements the calendarviewmodel class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BookingApp.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace BookingApp.ViewModel
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A ViewModel for the calendar. </summary>
    ///
    /// <remarks>   Radek, 08.01.2017. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class CalendarViewModel : ViewModelBase
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Radek, 08.01.2017. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public CalendarViewModel()
        {
            SaveCommand = new RelayCommand(OpenGuestsWindow);
            CancelCommand = new RelayCommand(CloseWindow);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Closes the window. </summary>
        ///
        /// <remarks>   Radek, 08.01.2017. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CloseWindow()
        {
            Closed?.Invoke(1);
        }

        #region Commands

        /// <summary>   Event queue for all listeners interested in Closed events. </summary>
        public event Action<int> Closed;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the save command. </summary>
        ///
        /// <value> The save command. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public ICommand SaveCommand { get; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the cancel command. </summary>
        ///
        /// <value> The cancel command. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public ICommand CancelCommand { get; }

        #endregion

        #region Fields

        /// <summary>   The start date. </summary>
        private DateTime startDate;
        /// <summary>   The end date. </summary>
        private DateTime endDate;

        #endregion

        #region Properties

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the start date. </summary>
        ///
        /// <value> The start date. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public DateTime StartDate
        {
            get { return startDate; }
            set
            {
                startDate = value;
                RaisePropertyChanged("StartDate");
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the end date. </summary>
        ///
        /// <value> The end date. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public DateTime EndDate
        {
            get { return endDate; }
            set
            {
                endDate = value;
                RaisePropertyChanged("EndDate");
            }
        }

        #endregion

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Opens guests window. </summary>
        ///
        /// <remarks>   Radek, 08.01.2017. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void OpenGuestsWindow()
        {
            if (!CheckIfDatesCorrect()) return;
            SaveReservationDates();
            GuestWindowManager guestWindowManager = new GuestWindowManager();
            guestWindowManager.Show();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Saves the reservation dates. </summary>
        ///
        /// <remarks>   Radek, 08.01.2017. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void SaveReservationDates()
        {
            ModelController.Instance.StartDate = StartDate;
            ModelController.Instance.EndDate = EndDate;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if dates correct. </summary>
        ///
        /// <remarks>   Radek, 08.01.2017. </remarks>
        ///
        /// <returns>   True if it succeeds, false if it fails. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private bool CheckIfDatesCorrect()
        {
            if (StartDate >= EndDate)
            {
                MessageBox.Show("Niewłaściwa data rezerwacji. Spróbuj ponownie.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
