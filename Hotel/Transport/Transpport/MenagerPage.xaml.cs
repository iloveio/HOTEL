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
using Hotel.Transpport;


namespace Transport.Transpport
{
    /// <summary>
    /// Interaction logic for MenagerPage.xaml
    /// </summary>
    public partial class MenagerPage : Window
    {
        Menager man;
        public MenagerPage(Menager men)
        {
            InitializeComponent();
            man = men;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Edit_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
