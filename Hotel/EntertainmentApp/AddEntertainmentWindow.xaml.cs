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

            if (entertainment != null)
            {
                nazwaTextBox.Text = entertainment.name;
                cenaTextBox.Text = entertainment.price.ToString();
                entIsNull = false;
            }
        }

        private void button_Click(object sender, RoutedEventArgs eargs)
        {
            float e = (float)Convert.ToDouble(cenaTextBox.Text);
            bool valid = float.TryParse(cenaTextBox.Text.ToString(), out e);
            entWin.col.m_OrganisedEvents.Add(new OrganisedEvent(nazwaTextBox.Text, e, 999, datePicker.SelectedDate ?? DateTime.Now, datePicker.SelectedDate ?? DateTime.Now, new Supervisor(0, "Pioter", "Cham", null, 20000, new EmployeeStatus(new DateTime(2016, 04, 05), new DateTime(2016, 04, 05), "ZAROBIONY"), null)));
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
