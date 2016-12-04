using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EntertainmentApp
{
    /// <summary>
    /// Interaction logic for EntertainmentWindow.xaml
    /// </summary>
    public partial class EntertainmentWindow : Window
    {
        public OurData col;
        public EntertainmentWindow()
        {
            InitializeComponent();
            InitBinding();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AddEntertainmentWindow addWindow = new AddEntertainmentWindow(null, this);
            addWindow.Show();
        }

        private void OrganisedEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    private void InitBinding()
    {
            col = new OurData();
            col.addToCollection(new OrganisedEvent("Koncert Tedasa", 50, 400, new DateTime(2016, 12, 10), new DateTime(2016, 12, 10), new Employee()));
            col.addToCollection(new OrganisedEvent("Koncert Tedasa", 50, 400, new DateTime(2016, 12, 10), new DateTime(2016, 12, 10), new Employee()));
            col.addToCollection(new OrganisedEvent("Koncert Tedasa", 50, 400, new DateTime(2016, 12, 10), new DateTime(2016, 12, 10), new Employee()));
            OrganisedEvents.ItemsSource = col.m_OrganisedEvents;
    }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if(OrganisedEvents.SelectedItem!=null)
                col.m_OrganisedEvents.RemoveAt(OrganisedEvents.SelectedIndex);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            AddEntertainmentWindow addWindow = new AddEntertainmentWindow(
                col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex), this);
            addWindow.Show();
        }
    }
}
