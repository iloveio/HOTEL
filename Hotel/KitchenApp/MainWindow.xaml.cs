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

namespace Kitchen
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            IngredientsWindow ingredientsWindow = new IngredientsWindow();
            ingredientsWindow.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            OrdersHistoryWindow ordersHistoryWindow = new OrdersHistoryWindow();
            ordersHistoryWindow.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            IncomeWindow incomeWindow = new IncomeWindow();
            incomeWindow.Show();
        }
    }
}
