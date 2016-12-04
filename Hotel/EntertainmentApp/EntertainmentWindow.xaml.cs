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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EntertainmentApp
{
    /// <summary>
    /// Interaction logic for EntertainmentWindow.xaml
    /// </summary>
    public partial class EntertainmentWindow : Window
    {
        private List<Entertainment> m_EntertainmentList = null;
        public EntertainmentWindow()
        {
            InitializeComponent();
            InitBinding();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OrganisedEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    private void InitBinding()
    {
            m_EntertainmentList = new List<Entertainment>();
            m_EntertainmentList.Add(new OrganisedEvent(1, "Jan", "Kowalski", 25));
            m_EntertainmentList.Add(new OrganisedEvent(2, "Adam", "Nowak", 24));
            m_EntertainmentList.Add(new OrganisedEvent(3, "Agnieszka", "Kowalczyk", 23));
            OrganisedEvents.ItemsSource = m_EntertainmentList;
    }
}
}
