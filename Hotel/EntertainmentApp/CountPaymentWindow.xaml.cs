using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace EntertainmentApp
{
    /// <summary>
    /// Interaction logic for CountPaymentWindow.xaml
    /// </summary>

    
    public partial class CountPaymentWindow : Window
    {
        public ObservableCollection<int> Numbers { get; set; }
        private EntertainmentWindow entWindow;
        private InnerEntertainment innEnt;

        public CountPaymentWindow(InnerEntertainment ent, EntertainmentWindow entWindow)
        {
            this.entWindow = entWindow;
            innEnt = ent;

            InitializeComponent();

            entLabel.Content = ent.name;
            priceLabel.Content = "----";
            guestComboBox.ItemsSource = entWindow.col.m_Guests;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            // sendInfoToAccountancyModule(guest, priceLabel.Content);
        }

        private void printReceiptButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void hoursComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int hours;
            bool parseOK = Int32.TryParse(hoursComboBox.SelectedValue.ToString(), out hours);
            float overallPrice = innEnt.price * hours;
            priceLabel.Content = overallPrice;
        }
    }
}
