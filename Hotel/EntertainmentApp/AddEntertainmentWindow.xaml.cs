////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	AddEntertainmentWindow.xaml.cs
//
// summary:	Implements the add entertainment window.xaml class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows;
using Hotel.Database;
using HumanResourcesLib;

namespace EntertainmentApp
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Interaction logic for Window1.xaml. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public partial class AddEntertainmentWindow : Window
    {
        /// <summary>   The ent window. </summary>
        private EntertainmentWindow entWin;
        /// <summary>   The ent. </summary>
        private OrganisedEvent ent;
        /// <summary>   True if ent is null. </summary>
        private bool entIsNull;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="entertainment">    The entertainment. </param>
        /// <param name="mainWindow">       The main window. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public AddEntertainmentWindow(OrganisedEvent entertainment, EntertainmentWindow mainWindow)
        {
            
            entWin = mainWindow;
            ent = entertainment;
            InitializeComponent();
            managerComboBox.ItemsSource = entWin.col.m_Supervisors;

            if (entertainment != null)
            {
                nazwaTextBox.Text = entertainment.name;
                cenaTextBox.Text = entertainment.price.ToString();
                maxGosciTextBox.Text = entertainment.maximumNumberOfGuests.ToString();
                managerComboBox.Text = entertainment.supervisor.ToString();
                datePickerStart.Text = entertainment.startDate;
                datePickerEnd.Text = entertainment.endDate;
                
                entIsNull = false;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by button for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="eargs">    Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button_Click(object sender, RoutedEventArgs eargs)
        {
            float e = (float)Convert.ToDouble(cenaTextBox.Text);
            int g = Convert.ToInt32(maxGosciTextBox.Text);
            bool valid = float.TryParse(cenaTextBox.Text.ToString(), out e);
            entWin.col.m_OrganisedEvents.Add(new OrganisedEvent
                (nazwaTextBox.Text, e, g, datePickerStart.SelectedDate ?? DateTime.Now, datePickerEnd.SelectedDate ?? DateTime.Now, (Supervisor)managerComboBox.SelectedItem));
            if (!entIsNull)
                entWin.col.m_OrganisedEvents.Remove(ent);
            Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by button1 for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
