﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	ViewModel\GuestViewModel.cs
//
// summary:	Implements the guest view model class
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
    /// <summary>   A ViewModel for the guest. </summary>
    ///
    /// <remarks>   Radek, 15.01.2017. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class GuestViewModel : ViewModelBase
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Radek, 15.01.2017. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public GuestViewModel()
        {
            SaveCommand = new RelayCommand(EndReservation);
            CancelCommand = new RelayCommand(CloseWindow);
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

        #region Properties

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the pesel. </summary>
        ///
        /// <value> The pesel. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string PESEL { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the name. </summary>
        ///
        /// <value> The name. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Name { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the person's surname. </summary>
        ///
        /// <value> The surname. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Surname { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the place of birth. </summary>
        ///
        /// <value> The place of birth. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string PlaceOfBirth { get; set; }
        #endregion

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Closes the window. </summary>
        ///
        /// <remarks>   Radek, 15.01.2017. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CloseWindow()
        {
            Closed?.Invoke(1);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Creates new guest from window data. </summary>
        ///
        /// <remarks>   Radek, 15.01.2017. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CreateNewGuestFromWindowData()
        {
          
            ModelController.Instance.CreateGuest(UInt32.Parse(PESEL), Name, Surname, PlaceOfBirth);
            MessageBox.Show("Stworzono goscia: " +  ModelController.Instance.GetGuest(UInt32.Parse(PESEL)).ToString());
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if data correct. </summary>
        ///
        /// <remarks>   Radek, 15.01.2017. </remarks>
        ///
        /// <returns>   True if it succeeds, false if it fails. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private bool CheckIfDataCorrect()
        {
            if (String.IsNullOrEmpty(Name) || String.IsNullOrEmpty(Surname) || String.IsNullOrEmpty(PlaceOfBirth) || String.IsNullOrEmpty(PESEL))
            {
                MessageBox.Show("Pola nie mogą pozostać puste!");
                return false;
            }
            return true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Creates the reservation. </summary>
        ///
        /// <remarks>   Radek, 15.01.2017. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CreateReservation()
        {
            ModelController.Instance.CreateReservation(UInt32.Parse(PESEL));
            MessageBox.Show("Rezerwacja ukończona!");
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Ends a reservation. </summary>
        ///
        /// <remarks>   Radek, 15.01.2017. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void EndReservation()
        {
            if (!CheckIfDataCorrect()) return;
            CreateNewGuestFromWindowData();
            CreateReservation();
            CloseWindow();
            //TODO TU POŁACZ SIE Z KSIEGOWOSCIA
        }

        
    }
}
