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
    /// Interaction logic for ShopWindow.xaml
    /// </summary>
    public partial class ShopWindow : Window
    {
        Hotel.Transpport.Dane.Shop shop;
        public ShopWindow(Hotel.Transpport.Dane.Shop p)
        {
            InitializeComponent();
            shop = p;
        }

        private void DodajDane_Click(object sender, RoutedEventArgs e)
        {
            shop.date = (DateTime)DateData.SelectedDate;
            if (shop.Save() == true)
            {
                MessageBox.Show("Zapisano do bazy");
            }
            else
            {
                MessageBox.Show("Brak połaczenia z baządanych");
            }
        }
    }
}
