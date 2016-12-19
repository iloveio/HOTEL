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
using Hotel.Transpport;

namespace Hotel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Gosc_Click_1(object sender, RoutedEventArgs e)
        {
            Guest gu = new Guest();
            gu.Show();

        }

        private void Menager_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Brak połączenia z baza danych");
        }

        private void Shop_Click(object sender, RoutedEventArgs e)
        {
            Shop sh = new Shop(new List<object>());
        }
    }
}
