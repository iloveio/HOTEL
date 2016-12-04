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
//using HumanResourcesLib;
//using BuilderTest;
//using System.Linq;


namespace Hotel
{
    /// <summary>
    /// Interaction logic for AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        private int isEditActive = -1;
        //Director dyr = new Director("Jan", "Kowalski", 1);

        public AddEmployeeWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

      

        private void DeleteJobButton_Click(object sender, RoutedEventArgs e)
        {
            JobsList.Items.Remove(JobsList.SelectedItem);
        }

        private void ConfirmJobButton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem item = new ListBoxItem();
            item.Content = AddJobField.Text;

            JobsList.Items.Add(item);

            AddJobField.Text = "";
        }

        private void AddJobButton_Click(object sender, RoutedEventArgs e)
        {
            isEditActive = isEditActive * (-1);

            if (isEditActive == 1)
            {
                AddJobButton.Background = new SolidColorBrush(Color.FromRgb(156, 156, 156));

                AddJobField.Height = 30;
                ConfirmJobButton.Height = 38;
            }
            else
            {
                AddJobButton.Background = new SolidColorBrush(Color.FromArgb(0, 255, 255, 255));

                AddJobField.Height = 0;
                ConfirmJobButton.Height = 0;
            }
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {

           // dyr.HireAnEmployee(AddFirstName.Text, AddLastName.Text, 0, new EmployeeStatus(EmployeeStatusName.Working, DateTime.Now, new DateTime(2017, 1, 1)), 0, JobsList.Items.OfType<BuilderTest.Job>().ToList());
            Close();
        }
    }
}
