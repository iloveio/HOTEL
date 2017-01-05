////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	ViewModel\CalendarWindowManager.cs
//
// summary:	Implements the calendar window manager class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingApp.Views;
using GalaSoft.MvvmLight;

namespace BookingApp.ViewModel
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Manager for calendar windows. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class CalendarWindowManager
    {
        /// <summary>   Event queue for all listeners interested in Closed events. </summary>
        public event Action<int> Closed;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public CalendarWindowManager()
        { 
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Shows this object. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Show()
        {
            CalendarViewModel calendarViewModel = new CalendarViewModel();
            calendarViewModel.Closed += ChildWindow_Closed;
            ChildWindowManager.Instance.ShowChildWindow(new CalendarWindow() {DataContext = calendarViewModel});
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Child window closed. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="i">    Zero-based index of the. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        void ChildWindow_Closed(int i)
        {
            Closed?.Invoke(i);
            ChildWindowManager.Instance.CloseChildWindow();
        }
    }
}