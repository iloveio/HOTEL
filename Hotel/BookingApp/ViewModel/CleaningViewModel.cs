using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace BookingApp.ViewModel
{
    public class CleaningViewModel
    {
        public CleaningViewModel()
        {
            SaveCommand = new RelayCommand(CreateCleaningJob);
            CancelCommand = new RelayCommand(CloseWindow);
        }


        #region Commands
        public event Action<int> Closed;
        public ICommand SaveCommand { get; }
        public ICommand CancelCommand { get; }
        #endregion

        private void CreateCleaningJob()
        {
            MessageBox.Show("Zlecenie przyjęte do realizacji");
            CloseWindow();
        }

        private void CloseWindow()
        {
            Closed?.Invoke(1);
        }
    }
}
