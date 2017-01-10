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
    /// Interaction logic for AddIngredientWindow.xaml
    /// </summary>
    public partial class AddIngredientWindow : Window
    {
        public AddIngredientWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String ingredientName;
            ingredientName = textBox.Text;
            MessageBox.Show("New Ingredient Added:" + ingredientName);
            Controller.Instance.kitchen.fridge.Add_Ingredient(ingredientName);
            IngredientsWindow ingredientsWindow = new IngredientsWindow();
            ingredientsWindow.Show();
            this.Close();

        }
    }
}
