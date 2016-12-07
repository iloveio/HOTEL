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

namespace EntertainmentApp
{
    /// <summary>
    /// Interaction logic for CountPaymentWindow.xaml
    /// </summary>
    public partial class CountPaymentWindow : Window
    {
        public CountPaymentWindow(InnerEntertainment ent)
        {
            InitializeComponent();
            entLabel.Content = ent.name;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void printReceiptButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
