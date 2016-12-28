using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingApp.Views;

namespace BookingApp.ViewModel
{
    public class CleaningWindowManager
    {
        public event Action<int> Closed;

        public CleaningWindowManager()
        {

        }

        public void Show()
        {
            CleaningViewModel cleaningViewModel = new CleaningViewModel();
            cleaningViewModel.Closed += ChildWindow_Closed;
            ChildWindowManager.Instance.ShowChildWindow(new CleaningWindow() { DataContext = cleaningViewModel });
        }

        void ChildWindow_Closed(int i)
        {
            Closed?.Invoke(i);
            ChildWindowManager.Instance.CloseChildWindow();
        }
    }
}
