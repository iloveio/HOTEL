using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingApp.Views;

namespace BookingApp.ViewModel
{
    public class GuestWindowManager
    {

        public event Action<int> Closed;

        public GuestWindowManager()
        {
                
        }

        public void Show()
        {
            GuestViewModel guestViewModel = new GuestViewModel();
            guestViewModel.Closed += ChildWindow_Closed;
            ChildWindowManager.Instance.ShowChildWindow(new GuestWindow() { DataContext = guestViewModel });
        }

        void ChildWindow_Closed(int i)
        {
            Closed?.Invoke(i);
            ChildWindowManager.Instance.CloseChildWindow();
        }
    }
}
