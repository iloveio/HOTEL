////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	EntertainmentWindow.xaml.cs
//
// summary:	Implements the entertainment window.xaml class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EntertainmentApp
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Interaction logic for EntertainmentWindow.xaml. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public partial class EntertainmentWindow : Window
    {
        /// <summary>   The col. </summary>
        public OurData col;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public EntertainmentWindow()
        {
            InitializeComponent();
            InitBinding();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by button for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AddEntertainmentWindow addWindow = new AddEntertainmentWindow(null, this);
            addWindow.Show();
        }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Init binding. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    private void InitBinding()
    {
            col = new OurData();
            InnerEntertainments.ItemsSource = col.m_InnerEntertainments;
            OrganisedEvents.ItemsSource = col.m_OrganisedEvents;
    }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by Delete for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (OrganisedEvents.SelectedItem != null)
            {
                col.removeFromCollection(col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex));
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by Edit for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (OrganisedEvents.SelectedItem != null)
            {
                AddEntertainmentWindow addWindow = new AddEntertainmentWindow(
                col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex), this);
                addWindow.Show();
            }
                
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by button4 for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if(InnerEntertainments.SelectedItem != null)
                col.removeFromCollection(col.m_InnerEntertainments.ElementAt(InnerEntertainments.SelectedIndex));
        }

        // edit

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by button5 for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (InnerEntertainments.SelectedItem != null)
            {
                AddInnerEntertainmentWindow addWindow = new AddInnerEntertainmentWindow(
                col.m_InnerEntertainments.ElementAt(InnerEntertainments.SelectedIndex), this);
                addWindow.Show();
            }
        }

        // add

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by button3 for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            AddInnerEntertainmentWindow addWindow = new AddInnerEntertainmentWindow(null, this);
            addWindow.Show();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by OrganisedEvents for selection changed events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Selection changed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void OrganisedEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrganisedEvents.SelectedItems.Count > 0)
            {
                nazwaLabel.Content = col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex).name;
                cenaLabel.Content = col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex).price;
                dataStartLabel.Content = col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex).startDate;
                dataKoniecLabel.Content = col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex).startDate;
                maxGosciLabel.Content = col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex).maximumNumberOfGuests;
                managerLabel.Content = col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex).supervisor.nameProperty + " " + col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex).supervisor.lastNameProperty;
            }

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by button_Click for 1 events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            CountPaymentWindow paymentWindow = new CountPaymentWindow(col.m_InnerEntertainments.ElementAt(InnerEntertainments.SelectedIndex), this);
            paymentWindow.Show();
        }
    }
}
