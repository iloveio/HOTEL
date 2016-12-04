using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddEntertainmentWindow : Window
    {
        public AddEntertainmentWindow(Entertainment entertainment, ObservableCollection<Entertainment> eventList)
        {
            InitializeComponent();
            if (entertainment != null)
            {
                nazwaTextBox.AppendText(entertainment.name);
                cenaTextBox.AppendText(entertainment.price.ToString());
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
