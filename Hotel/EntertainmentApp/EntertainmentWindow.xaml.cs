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
        private ObservableCollection<OrganisedEvent> m_EntertainmentList;
        public EntertainmentWindow()
        {
            InitializeComponent();
            InitBinding();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AddEntertainmentWindow addWindow = new AddEntertainmentWindow(null);
            addWindow.ShowDialog();
        }

        private void OrganisedEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    private void InitBinding()
    {
            m_EntertainmentList = new ObservableCollection<OrganisedEvent>(); ;
            m_EntertainmentList.Add(new OrganisedEvent("Koncert Tedasa", 50, 400, new DateTime(2016,12,10), new DateTime(2016, 12, 10), new Employee()));
            m_EntertainmentList.Add(new OrganisedEvent("Koncert Tedasa", 50, 400, new DateTime(2016, 12, 10), new DateTime(2016, 12, 10), new Employee()));
            m_EntertainmentList.Add(new OrganisedEvent("Koncert Tedasa", 50, 400, new DateTime(2016, 12, 10), new DateTime(2016, 12, 10), new Employee()));
            OrganisedEvents.ItemsSource = m_EntertainmentList;
    }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if(OrganisedEvents.SelectedItem!=null)
            m_EntertainmentList.RemoveAt(OrganisedEvents.SelectedIndex);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
