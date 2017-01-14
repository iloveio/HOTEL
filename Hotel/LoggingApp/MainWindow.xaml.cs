using HumanResourcesLib;
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
using BookingApp;
using Transport;

namespace LoggingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ISession<User> userSession;
        public MainWindow(ISession<User> userSession)
        {
            InitializeComponent();
            this.userSession = userSession;
        }

        private bool IsEmployeeAuthorisedToEnter(params Postion [] position )
        {

            Employee tmp = (Employee)userSession.Session;
           
           
            if (tmp.Position == position[0] || tmp.Position == position[1])
            {
                return true;
            }
            else
                return false;
        }

        private void entertainmentButton_Click(object sender, RoutedEventArgs e)
        {
           
                if (userSession.Session.GetType() == typeof(Director) || IsEmployeeAuthorisedToEnter(Postion.EventMenager,Postion.EventStaff))
                {
                    EntertainmentApp.EntertainmentWindow entertainmentWindow = new EntertainmentApp.EntertainmentWindow();
                    entertainmentWindow.Show();
                }
                else
                {
                    MessageBox.Show("Nie Masz uprawnień do otworzenia tego modułu");
                }

        }

        private void transportButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (userSession.Session.GetType() == typeof(Director) || IsEmployeeAuthorisedToEnter(Postion.Transportation, Postion.TransportationManager))
            {
                WpfApplication1.MainWindow main = new WpfApplication1.MainWindow();  //serio chłopaki WpfApplicatnion1 ??? xd
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie Masz uprawnień do otworzenia tego modułu");
            }
        }

        private void staffButton_Click(object sender, RoutedEventArgs e)
        {
            if(userSession.Session.GetType() == typeof(Director) || userSession.Session.GetType() == typeof(Supervisor))
            {
                StaffGUI.MainWindow staffWindow = new StaffGUI.MainWindow();
                staffWindow.User = userSession.Session;
                staffWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie Masz uprawnień do otworzenia tego modułu");
            }
           
        }

        private void bookingButton_Click(object sender, RoutedEventArgs e)
        {
            BookingWindow bookingWindow = new BookingWindow();
            bookingWindow.Show();
        }

        private void kitchenButton_Click(object sender, RoutedEventArgs e)
        {
            
                if (userSession.Session.GetType() == typeof(Director) || (IsEmployeeAuthorisedToEnter(Postion.KitchenManager, Postion.KitchenStaff)))
                {
                    Kitchen.MainWindow kitchenWindow = new Kitchen.MainWindow();
                    kitchenWindow.Show();
                }
                 else
                 {
                     MessageBox.Show("Nie Masz uprawnień do otworzenia tego modułu");
                 }

        }
        private void accountancyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.userSession.EndSession();
            LoggingWindow loggingWindow = new LoggingWindow();
            loggingWindow.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StaffGUI.EmployeeProfileWindow employeeProfile = new StaffGUI.EmployeeProfileWindow(this.userSession.Session);
            employeeProfile.ShowDialog();
        }
    }
}
