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

namespace Hotel.Transpport
{
    /// <summary>
    /// Interaction logic for GuestWindow.xaml
    /// </summary>
    public partial class GuestWindow : Window
    {
        Guest gs;
        public GuestWindow(Guest tr)
        {
            InitializeComponent();
            gs = tr;
        }
        private void DodajDane_Click_1(object sender, RoutedEventArgs e)
        {
            gs.guestName = GuestData.Text.ToString();
            gs.from = FromData.Text.ToString();
            gs.destination = DestinationData.Text.ToString();
            gs.howMany = int.Parse(HowManyData.Text.ToString());
            gs.date = DateData.DisplayDate;
            if (!gs.Save())
            {
                MessageBox.Show("brak bołaczenia z bazą");
            }

            this.Close();
        }
    }
}
