using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hotel.Transpport
{
    /// <summary>
    /// Interaction logic for GuestPage.xaml
    /// </summary>
    public partial class GuestPage : Page
    {
        Guest guest;
        public GuestPage(Guest tr)
        {
            InitializeComponent();
            guest = tr;
        }
        private void DodajDane_Click(object sender, RoutedEventArgs e)
        {
            guest.from = FromData.Text;
            guest.destination = DestinationData.Text;
            guest.guest = FromData.Text;
            guest.howMany = int.Parse(HowManyData.Text);
            guest.cost = 100;
            guest.date = DateData.DisplayDate;
            MessageBox.Show("Stworzono nowe zlecenie");
            guest.Save();
        }
    }
}
