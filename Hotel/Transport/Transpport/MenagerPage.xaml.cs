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
using Hotel.Database;



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
            foreach(Transportation t in man.mengaerDatabase.transportationsList)
            {
                listBox.Items.Add(t);
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            Transportation selected = (Transportation)listBox.SelectedItem;
            // man.Pay(selected.cost);
            listBox.Items.RemoveAt(listBox.SelectedIndex);
            man.Delete(selected);
        }

        private void Edit_Click_1(object sender, RoutedEventArgs e)
        {
            Transportation tr = new Transportation();
            Transportation selected = (Transportation)listBox.SelectedItem;
            Window po = new EditMenager(selected,tr);
            po.Show();
            man.Edit(selected, tr );
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Transportation selected = (Transportation)listBox.SelectedItem;
            listBox.Items.RemoveAt(listBox.SelectedIndex);
            man.Delete(selected);
        }
    }
}
