using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace BookingApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            OpenCalendarCommand = new RelayCommand(OpenCalendarWindow);
        }

        public ICommand OpenCalendarCommand { get; set; }

        void OpenCalendarWindow()
        {
            CalendarWindowViewModel calendarWindowViewModel = new CalendarWindowViewModel();
            calendarWindowViewModel.Show();
        }
    }
}