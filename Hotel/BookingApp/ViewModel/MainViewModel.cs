using System;
using System.Windows;
using System.Windows.Input;
using BookingApp.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace BookingApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            OpenCalendarCommand = new RelayCommand(OpenCalendarWindow);
            OpenCleaningCommand = new RelayCommand(OpenCleaningWindow);
        }

        public ICommand OpenCalendarCommand { get; set; }
        public ICommand OpenCleaningCommand { get; set; }

        void OpenCalendarWindow()
        {
            if (!CheckIfRoomSelected()) return;
            CalendarWindowManager calendarWindowManager = new CalendarWindowManager();
            calendarWindowManager.Show();
        }

        void OpenCleaningWindow()
        {
            if (!CheckIfRoomSelected()) return;
            CleaningWindowManager cleaningWindowManager = new CleaningWindowManager();
            cleaningWindowManager.Show();
        }

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