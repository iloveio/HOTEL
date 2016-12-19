////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	CountPaymentWindow.xaml.cs
//
// summary:	Implements the count payment window.xaml class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using Hotel.Database.Accountancy;

namespace EntertainmentApp
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Interaction logic for CountPaymentWindow.xaml. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public partial class CountPaymentWindow : Window
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the numbers. </summary>
        ///
        /// <value> The numbers. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public ObservableCollection<int> Numbers { get; set; }
        /// <summary>   The ent window. </summary>
        private EntertainmentWindow entWindow;
        /// <summary>   The inn ent. </summary>
        private InnerEntertainment innEnt;
        /// <summary>   Manager for accumulate. </summary>
        private AccountancyManager accManager;
        /// <summary>   The overall price. </summary>
        private float overallPrice;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="ent">          The ent. </param>
        /// <param name="entWindow">    The ent window. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public CountPaymentWindow(InnerEntertainment ent, EntertainmentWindow entWindow)
        {
            accManager = new AccountancyManager();
            this.entWindow = entWindow;
            innEnt = ent;

            InitializeComponent();

            entLabel.Content = ent.name;
            priceLabel.Content = "----";
            guestComboBox.ItemsSource = entWindow.col.m_Guests;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by CancelButton for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by OkButton for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            accManager.AddNewBill(new Bill(5, (int)overallPrice, "Entertainment", "Accountancy"));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by printReceiptButton for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

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

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by hoursComboBox for selection changed events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Selection changed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void hoursComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int hours;
            bool parseOK = Int32.TryParse(hoursComboBox.SelectedValue.ToString(), out hours);
            overallPrice = innEnt.price * hours;
            priceLabel.Content = overallPrice;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by guestComboBox for selection changed events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Selection changed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void guestComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by Button for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReceiptPopup.IsOpen = false;
        }
    }
}
