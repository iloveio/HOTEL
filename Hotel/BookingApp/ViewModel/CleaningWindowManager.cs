////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	ViewModel\CleaningWindowManager.cs
//
// summary:	Implements the cleaning window manager class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingApp.Views;

namespace BookingApp.ViewModel
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Manager for cleaning windows. </summary>
    ///
    /// <remarks>   Radek, 15.01.2017. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class CleaningWindowManager
    {
        /// <summary>   Event queue for all listeners interested in Closed events. </summary>
        public event Action<int> Closed;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Radek, 15.01.2017. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public CleaningWindowManager()
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Shows this object. </summary>
        ///
        /// <remarks>   Radek, 15.01.2017. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Show()
        {
            CleaningViewModel cleaningViewModel = new CleaningViewModel();
            cleaningViewModel.Closed += ChildWindow_Closed;
            ChildWindowManager.Instance.ShowChildWindow(new CleaningWindow() { DataContext = cleaningViewModel });
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Child window closed. </summary>
        ///
        /// <remarks>   Radek, 15.01.2017. </remarks>
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
