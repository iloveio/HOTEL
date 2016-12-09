using EntertainmentApp;
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
    public partial class AddInnerEntertainmentWindow : Window
    {
        private EntertainmentWindow entWin;
        private InnerEntertainment ent;
        private bool entIsNull;
        public AddInnerEntertainmentWindow(InnerEntertainment entertainment, EntertainmentWindow mainWindow)
        {
            entWin = mainWindow;
            ent = entertainment;
            InitializeComponent();

            if (entertainment != null)
            {
                nazwaTextBox.Text = entertainment.name;
                cenaTextBox.Text = entertainment.price.ToString();
                entIsNull = false;
            }
        }

        private void button_Click(object sender, RoutedEventArgs eargs)
        {
            float e = (float)Convert.ToDouble(cenaTextBox.Text);
            bool valid = float.TryParse(cenaTextBox.Text.ToString(), out e);
            entWin.col.m_InnerEntertainments.Add(new InnerEntertainment(nazwaTextBox.Text, e));
            if (!entIsNull)
                entWin.col.m_InnerEntertainments.Remove(ent);
            Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
