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
using System.Windows.Shapes;

namespace Transport.Transpport
{
    /// <summary>
    /// Interaction logic for GuestWindow.xaml
    /// </summary>
    public partial class GuestWindow : Window
    {
        Hotel.Transpport.Dane.Guest guest;
        public GuestWindow(Hotel.Transpport.Dane.Guest tr)
        {
            InitializeComponent();
            guest = tr;
        }
        private void DodajDane_Click(object sender, RoutedEventArgs e)
        {
            guest.from = FromData.Text.ToString();
            guest.destination = DestinationData.Text.ToString();
            guest.guest = FromData.Text.ToString();
            guest.howMany = int.Parse(HowManyData.Text.ToString());
            guest.cost = 100;
            guest.date = DateData.DisplayDate;
            if (guest.Save() == true)
            {
                MessageBox.Show("Zapisano do bazy");
            }
            else
            {
                MessageBox.Show("Brak połaczenia z baządanych");
            }
            this.Close();

        }
    }
}
