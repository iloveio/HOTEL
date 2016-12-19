////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Views\CalendarWindow.xaml.cs
//
// summary:	Implements the calendar window.xaml class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookingApp.Views
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Interaction logic for CalendarWindow.xaml. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public partial class CalendarWindow : UserControl
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public CalendarWindow()
        {
            InitializeComponent();
            CalendarDateRange cdr = new CalendarDateRange(DateTime.MinValue, DateTime.Today);
            startDatePicker.BlackoutDates.Add(cdr);
            endDatePicker.BlackoutDates.Add(cdr);
        }
    }
}
