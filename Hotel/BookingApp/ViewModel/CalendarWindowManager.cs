using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingApp.Views;
using GalaSoft.MvvmLight;

namespace BookingApp.ViewModel
{
    public class CalendarWindowManager
    {
        public event Action<int> Closed;

        public CalendarWindowManager()
        { 
        }

        public void Show()
        {
            CalendarViewModel calendarViewModel = new CalendarViewModel();
            calendarViewModel.Closed += ChildWindow_Closed;
            ChildWindowManager.Instance.ShowChildWindow(new CalendarWindow() {DataContext = calendarViewModel});
        }

        void ChildWindow_Closed(int i)
        {
            Closed?.Invoke(i);
            ChildWindowManager.Instance.CloseChildWindow();
        }
    }
}