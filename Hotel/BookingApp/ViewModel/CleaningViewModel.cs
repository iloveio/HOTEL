using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BookingApp.Model;
using GalaSoft.MvvmLight.Command;

namespace BookingApp.ViewModel
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A ViewModel for the cleaning. </summary>
    ///
    /// <remarks>   Radek, 08.01.2017. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

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

        #region Properties
        public string Description { get; set; } 
        #endregion

        private void CreateCleaningJob()
        {
            ModelController.Instance.CreateCleaningJob(Description);
            MessageBox.Show("Zlecenie przyjęte do realizacji");
            CloseWindow();
        }

        private void CloseWindow()
        {
            Closed?.Invoke(1);
        }
    }
}
