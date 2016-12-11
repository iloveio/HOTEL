using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

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
            if (hoursComboBox.SelectedValue == null || guestComboBox.SelectedValue == null)
                ErrorMessage.Content = "Błąd, brak wyboru gościa lub godzin!";
            else
            {
                serviceLabel.Content = "- " + innEnt.name;
                priceLabel2.Content = priceLabel.Content + " zł";
                fullNameLabel.Content = guestComboBox.Text;
                ReceiptPopup.IsOpen = true;
            }
                
        }

        private void hoursComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int hours;
            bool parseOK = Int32.TryParse(hoursComboBox.SelectedValue.ToString(), out hours);
            float overallPrice = innEnt.price * hours;
            priceLabel.Content = overallPrice;
        }

        private void guestComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReceiptPopup.IsOpen = false;
        }
    }
}
