
using Hotel.Transpport;
using Hotel.Database;
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
using Kitchen;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TransportationManager tr;
        List<Ingredient> list;
        public MainWindow()
        {
            InitializeComponent();
            list = new List<Ingredient>();
            tr = new TransportationManager();
        }

        private void Menager_Click(object sender, RoutedEventArgs e)
        {
            Menager menager = new Menager(tr);
            menager.Show();
        }

        private void Shop_Click(object sender, RoutedEventArgs e)
        {
            Hotel.Transpport.Dane.Shop p = new Hotel.Transpport.Dane.Shop(list, tr);
            p.Show();
        }

        private void Guest_Click(object sender, RoutedEventArgs e)
        {
            Hotel.Transpport.Dane.Guest g = new Hotel.Transpport.Dane.Guest(tr);
            g.Show();
        }
    }
}
