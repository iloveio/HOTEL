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
using System.Windows.Shapes;

namespace Hotel
{
    /// <summary>
    /// Interaction logic for EmployeeProfileWindow.xaml
    /// </summary>
    public partial class EmployeeProfileWindow : Window
    {
        public EmployeeProfileWindow()
        {
            InitializeComponent();
        }

        private void ExitModule_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
