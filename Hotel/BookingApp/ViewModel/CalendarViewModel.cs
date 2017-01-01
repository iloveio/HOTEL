using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BookingApp.Model;
using BookingLibrary.TempDatabase;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace BookingApp.ViewModel
{
    public class CalendarViewModel : ViewModelBase
    {
        public CalendarViewModel()
        {
            SaveCommand = new RelayCommand(OpenGuestsWindow);
            CancelCommand = new RelayCommand(CloseWindow);
        }

        private void CloseWindow()
        {
            Closed?.Invoke(1);
        }

        #region Commands

        public event Action<int> Closed;
        public ICommand SaveCommand { get; }

        public ICommand CancelCommand { get; }

        #endregion

        #region Fields

        private DateTime startDate;
        private DateTime endDate;

        #endregion

        #region Properties

        public DateTime StartDate
        {
            get { return startDate; }
            set
            {
                startDate = value;
                RaisePropertyChanged("StartDate");
            }
        }

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

        private void OpenGuestsWindow()
        {
            if (!CheckIfDatesCorrect()) return;
            SaveReservationDates();
            GuestWindowManager guestWindowManager = new GuestWindowManager();
            guestWindowManager.Show();
        }

        private void SaveReservationDates()
        {
            ModelController.Instance.StartDate = StartDate;
            ModelController.Instance.EndDate = EndDate;
        }


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
