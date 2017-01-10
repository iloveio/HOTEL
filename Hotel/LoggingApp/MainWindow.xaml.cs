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
using System.Windows.Shapes;

namespace LoggingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void entertainmentButton_Click(object sender, RoutedEventArgs e)
        {
            EntertainmentApp.EntertainmentWindow entertainmentWindow = new EntertainmentApp.EntertainmentWindow();
            entertainmentWindow.Show();
        }

        private void transportButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void staffButton_Click(object sender, RoutedEventArgs e)
        {
            //StaffGUI.MainWindow staffWindow = new StaffGUI.MainWindow();
            //staffWindow.Show();
        }

        private void bookingButton_Click(object sender, RoutedEventArgs e)
        {
            BookingApp.BookingWindow bookingWindow = new BookingApp.BookingWindow();
            bookingWindow.Show();
        }

        private void kitchenButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void accountancyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            LoggingWindow loggingWindow = new LoggingWindow();
            loggingWindow.Show();
            this.Close();     
        }

    }
}
