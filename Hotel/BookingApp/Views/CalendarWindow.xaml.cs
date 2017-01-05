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
using BookingApp.Model;
using Hotel.Database;

namespace BookingApp.Views
{
    /// <summary>
    /// Interaction logic for CalendarWindow.xaml
    /// </summary>
    public partial class CalendarWindow : UserControl
    {
        public List<Reservation> ActualReservations { get; set; }

        public CalendarWindow()
        {
            InitializeComponent();
            var SelectedRoom = ModelController.Instance.SelectedRoomID;
            ActualReservations = ModelController.Instance.GetReservationsForSelectedRoom(SelectedRoom);
            foreach (var reservation in ActualReservations)
            {
                CalendarDateRange range = new CalendarDateRange(reservation.ReservationStart,reservation.ReservationEnd);
                startDatePicker.BlackoutDates.Add(range);
                endDatePicker.BlackoutDates.Add(range);
            }
            CalendarDateRange cdr = new CalendarDateRange(DateTime.MinValue, DateTime.Today.AddDays(-1));
            startDatePicker.BlackoutDates.Add(cdr);
            endDatePicker.BlackoutDates.Add(cdr);
        }
    }
}
