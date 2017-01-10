using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Kitchen
{
    /// <summary> 
    /// Manages the kitchen simulation. </summary>
    public class Controller
    {
        /// <summary> 
        /// Controller of instances. </summary>
        public static Controller instanceController;

        /// <summary> 
        /// KitchenClass object to be managed by the controller. </summary>
        public KitchenClass kitchen;

        /// <summary> 
        /// Dispatcher timer. </summary>
        private DispatcherTimer timer;

        /// <summary> 
        /// ID number of the current customer. </summary>
        public int currentClientId;

        /// <summary> 
        /// Controller Constructor. </summary>
        public Controller()
        {
            kitchen = new KitchenClass();
            currentClientId = 1;
            StartSimulation();
        }

        /// <summary> 
        /// New instance controller. </summary>
        public static Controller Instance => instanceController ?? (instanceController = new Controller());

        /// <summary> 
        /// Starts the kitchen's simulation. </summary>
        public void StartSimulation()
        {

            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Start();


            //kitchen.New_Bill_For_Customer(1);

            //// Order_Dish outputs a List<string>

            //List<string> missingIngredients = new List<string>();

            //missingIngredients.AddRange(kitchen.Order_Dish("Tomato sandwich"));
            //missingIngredients.AddRange(kitchen.Order_Dish("Tomato sandwich"));

            //missingIngredients.AddRange(kitchen.Order_Dish("Hot dog"));

            //kitchen.New_Bill_For_Customer(2);
            //missingIngredients.AddRange(kitchen.Order_Dish("Hot dog"));
            //missingIngredients.AddRange(kitchen.Order_Dish("Tomato sandwich"));

            //kitchen.Display_Bills();



        }

        /// <summary> 
        /// Starts a new bill and orders few random dishes. </summary>
        /// <param name="sender"> Sender of the information.</param>
        /// <param name="e"> Event arguments.</param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            List<string> missingIngredients = new List<string>();
            kitchen.New_Bill_For_Customer(currentClientId);
            int numbeOfRecipes = Controller.Instance.kitchen.cookBook.recipes.Count();
            //MessageBox.Show("Number of recipes is: " + numbeOfRecipes);
            List<string> dishNames = Controller.Instance.kitchen.cookBook.getDishNames();
            Random rand = new Random();
            int howMuchDishes = rand.Next(1, 8);
            for (int i = 0; i < howMuchDishes; i++)
            {
                int recipeIndex = rand.Next(0, numbeOfRecipes);
                missingIngredients.AddRange(kitchen.Order_Dish(dishNames[recipeIndex]));

            }
            if(!kitchen.fridge.numberOfIngredientsControl())
                timer.Stop();

            currentClientId++;
        }
    }
}
