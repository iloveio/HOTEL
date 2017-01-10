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
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        private List<Recipe> recipesToList = null;
        private List<string> ingredientsToShow;

        public MenuWindow()
        {
            InitializeComponent();
            InitBinding();
        }

        private void InitBinding()
        {
            recipesToList = new List<Recipe>();
            recipesToList = Controller.Instance.kitchen.cookBook.getRecipesList();
            DishList.ItemsSource = recipesToList;
            comboBox.ItemsSource = Controller.Instance.kitchen.cookBook.getDishNames();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AddDishWindow addDishWindow = new AddDishWindow();
            addDishWindow.Show();
            this.Close();

        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            //var item = DishList.SelectedItem.ToString();
            ////MessageBox.Show(DishList.SelectedItem.ToString());
            //if (item == null)
            //{
            //    MessageBox.Show("chuj" + item);
            //    return;               
            //}
            //else
            //{
            //    MessageBox.Show("cos jest" + item);
            //}
            ////MessageBox.Show(item.Return_Name());
            //if (item != null)
            //{
            //   // ingredientsToShow = new List<string>(item.Return_ingredientNames());
            //}
            //if(ingredientsToShow == null)
            //   // MessageBox.Show(item.Return_Name());
            //ShowIngredientsOnList(ingredientsToShow);
        }

        private void ShowIngredientsOnList(List<string> ingredientsList )
        {
            IngredientsList.ItemsSource = ingredientsList;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String selectedDish = comboBox.Text;
            List<String> ingredientsList = null;

            if (comboBox.Text == null)
                return;

            foreach (Recipe recipe in recipesToList)
            {
                if (selectedDish == recipe.name)
                {
                    ingredientsList = new List<String>();
                    ingredientsList = recipe.Return_ingredientNames();
                    ShowIngredientsOnList(ingredientsList);
                }
            }
        }
    }
}
