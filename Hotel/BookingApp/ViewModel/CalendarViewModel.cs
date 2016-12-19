﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	ViewModel\CalendarViewModel.cs
//
// summary:	Implements the calendar view model class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BookingLibrary;
using BookingLibrary.TempDatabase;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace BookingApp.ViewModel
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A ViewModel for the calendar. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class CalendarViewModel : ViewModelBase
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public CalendarViewModel()
        {
            SaveCommand = new RelayCommand(CreateReservation);
            CancelCommand = new RelayCommand(CloseWindow);
            ActualReservations = ModelController.Instance.GetReservationsForSelectedRoom(SelectedRoom);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Closes the window. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CloseWindow()
        {
            Closed?.Invoke(1);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the actual reservations. </summary>
        ///
        /// <value> The actual reservations. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<Reservation> ActualReservations { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the selected room. </summary>
        ///
        /// <value> The selected room. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public uint SelectedRoom { get; set; }

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
        /// <summary>   Gets or sets the identifier of the user. </summary>
        ///
        /// <value> The identifier of the user. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public uint UserId { get; set; }

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
        /// <summary>   Creates the reservation. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CreateReservation()
        {
            ModelController.Instance.CreateReservation(SelectedRoom,UserId,StartDate,EndDate);
        }
    }
}
