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
using Hotel.Database;

namespace Transport.Transpport
{
    /// <summary>
    /// Interaction logic for EditMenager.xaml
    /// </summary>
    public partial class EditMenager : Window
    {
        Transportation oldT;
        Transportation newT;
        public EditMenager(Transportation oldTr, Transportation newTR)
        {
            oldT = oldTr;
            newT = newTR;
            InitializeComponent();
            DateData.SelectedDate = oldT.date;
            Dane.Text = oldT.description;
        }

        private void DodajDane_Click(object sender, RoutedEventArgs e)
        {
            newT.date = (DateTime)DateData.SelectedDate;
            newT.description = Dane.Text.ToString();
        }
    }
}
