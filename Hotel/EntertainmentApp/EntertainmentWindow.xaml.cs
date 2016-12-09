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

    private void InitBinding()
    {
            col = new OurData();
            InnerEntertainments.ItemsSource = col.m_InnerEntertainments;
            OrganisedEvents.ItemsSource = col.m_OrganisedEvents;
    }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if(OrganisedEvents.SelectedItem!=null)
                col.m_OrganisedEvents.RemoveAt(OrganisedEvents.SelectedIndex);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (OrganisedEvents.SelectedItem != null)
            {
                AddEntertainmentWindow addWindow = new AddEntertainmentWindow(
                col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex), this);
                addWindow.Show();
            }
                
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if(InnerEntertainments.SelectedItem != null)
                col.m_InnerEntertainments.RemoveAt(InnerEntertainments.SelectedIndex);
        }

        // edit
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
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            AddInnerEntertainmentWindow addWindow = new AddInnerEntertainmentWindow(null, this);
            addWindow.Show();
        }

        private void OrganisedEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrganisedEvents.SelectedItems.Count > 0)
            {
                nazwaLabel.Content = col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex).name;
                cenaLabel.Content = col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex).price;
                dataStartLabel.Content = col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex).startDate;
                dataKoniecLabel.Content = col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex).startDate;
                maxGosciLabel.Content = col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex).maximumNumberOfGuests;
                managerLabel.Content = col.m_OrganisedEvents.ElementAt(OrganisedEvents.SelectedIndex).supervisor.ToString();

            }

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            CountPaymentWindow paymentWindow = new CountPaymentWindow(col.m_InnerEntertainments.ElementAt(InnerEntertainments.SelectedIndex), this);
            paymentWindow.Show();
        }
    }
}
