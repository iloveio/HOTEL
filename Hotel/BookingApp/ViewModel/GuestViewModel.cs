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
    public class GuestViewModel : ViewModelBase
    {
        public GuestViewModel()
        {
            SaveCommand = new RelayCommand(EndReservation);
            CancelCommand = new RelayCommand(CloseWindow);
        }

        #region Commands
        public event Action<int> Closed;
        public ICommand SaveCommand { get; }
        public ICommand CancelCommand { get; }
        #endregion

        #region Properties
        public string PESEL { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PlaceOfBirth { get; set; }
        #endregion

        private void CloseWindow()
        {
            Closed?.Invoke(1);
        }

        private void CreateNewGuestFromWindowData()
        {
          
            ModelController.Instance.CreateGuest(UInt32.Parse(PESEL), Name, Surname, PlaceOfBirth);
            MessageBox.Show("Stworzono goscia: " +  ModelController.Instance.GetGuest(UInt32.Parse(PESEL)).ToString());
        }

        private bool CheckIfDataCorrect()
        {
            if (String.IsNullOrEmpty(Name) || String.IsNullOrEmpty(Surname) || String.IsNullOrEmpty(PlaceOfBirth) || String.IsNullOrEmpty(PESEL))
            {
                MessageBox.Show("Pola nie mogą pozostać puste!");
                return false;
            }
            return true;
        }

        private void CreateReservation()
        {
            ModelController.Instance.CreateReservation(UInt32.Parse(PESEL));
            MessageBox.Show("Rezerwacja ukończona!");
        }

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
