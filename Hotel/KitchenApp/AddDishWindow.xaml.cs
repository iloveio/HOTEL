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

namespace Kitchen
{
    /// <summary>
    /// Interaction logic for AddDishWindow.xaml
    /// </summary>
    public partial class AddDishWindow : Window
    {
        public AddDishWindow()
        {
            InitializeComponent();
            comboBox.ItemsSource = Controller.Instance.kitchen.fridge.Return_ingredientNames();
            comboBox1.ItemsSource = Controller.Instance.kitchen.fridge.Return_ingredientNames();
            comboBox2.ItemsSource = Controller.Instance.kitchen.fridge.Return_ingredientNames();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String dishName = textBox.Text;
            int price = int.Parse(textBox1.Text);
            String ing1 = comboBox.Text;
            String ing2 = comboBox1.Text;
            String ing3 = comboBox2.Text;
            List<string> ingredientNames = new List<string>();
            ingredientNames.Add(ing1);
            ingredientNames.Add(ing2);
            ingredientNames.Add(ing3);
            Controller.Instance.kitchen.cookBook.recipes.Add(new Recipe(dishName, ingredientNames, price));

            MessageBox.Show("New recipe added: " + dishName);
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();

        }
    }
}
