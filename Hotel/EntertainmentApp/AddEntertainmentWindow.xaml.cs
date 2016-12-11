using System;
using System.Linq;
using System.Windows;
using Hotel.Database;
using Hotel.Database.Staff;

namespace EntertainmentApp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddEntertainmentWindow : Window
    {
        private EntertainmentWindow entWin;
        private OrganisedEvent ent;
        private bool entIsNull;
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
                
                entIsNull = false;
            }
        }

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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        
    }
}
