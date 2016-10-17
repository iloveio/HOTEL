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
    public class CalendarViewModel : ViewModelBase
    {
        public CalendarViewModel()
        {
            SaveCommand = new RelayCommand(CreateReservation);
            CancelCommand = new RelayCommand(CloseWindow);
            ActualReservations = ModelController.Instance.GetReservationsForSelectedRoom(SelectedRoom);
        }

        private void CloseWindow()
        {
            Closed(1);
        }

        public List<Reservation> ActualReservations { get; set; }
        public uint SelectedRoom { get; set; }

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

        public uint UserId { get; set; }
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
        private void CreateReservation()
        {
            ModelController.Instance.CreateReservation(SelectedRoom,UserId,StartDate,EndDate);
        }
    }
}
