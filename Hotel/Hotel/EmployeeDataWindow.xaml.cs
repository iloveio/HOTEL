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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Hotel
{
    /// <summary>
    /// Interaction logic for EmployeeDataWindow.xaml
    /// </summary>
    public partial class EmployeeDataWindow : Window
    {
        private int isEditActive = -1;
        private int isAddJobActive = -1;


        public EmployeeDataWindow()
        {
            InitializeComponent();
            ListBoxItem item1 = new ListBoxItem();
            ListBoxItem item2 = new ListBoxItem();
            ListBoxItem item3 = new ListBoxItem();
            ListBoxItem item4 = new ListBoxItem();
            ListBoxItem item5 = new ListBoxItem();
            ListBoxItem item6 = new ListBoxItem();

            /*item1.Content = EmployeeStatusName.Working;
            item2.Content = EmployeeStatusName.SickLeave;
            item3.Content = EmployeeStatusName.MaternityOrPaternityLeave;
            item4.Content = EmployeeStatusName.HalfPayLeave;
            item5.Content = EmployeeStatusName.ExtraOrdinaryLeave;
            item6.Content = EmployeeStatusName.ErnedLeave;*/
            item1.Content = "Working";
            item2.Content = "SickLeave";
            item3.Content = "MaternityLeave";
            item4.Content = "HalfPayLeave";
            item5.Content = "ExtraOrdinaryLeave";
            item6.Content = "ErnedLeave";

            StatusesList.Items.Add(item1);
            StatusesList.Items.Add(item2);
            StatusesList.Items.Add(item3);
            StatusesList.Items.Add(item4);
            StatusesList.Items.Add(item5);
            StatusesList.Items.Add(item6);

            datePicker.SelectedDate = DateTime.Now;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            isEditActive = isEditActive * (-1);

            if (isEditActive == 1)
            {
                EditButton.Background = new SolidColorBrush(Color.FromRgb(156, 156, 156));
                ExitButton.Content = "Apply changes";

                editFirstName.Height = 30;
                editLastName.Height = 30;
                StatusesList.Height = 30;
                editWage.Height = 30;
                JobsListBrowse.Height = 127;
                FirstName.Height = 30;
                LastName.Height = 30;
                Status.Height = 30;
                Wage.Height = 30;
                Jobs.Height = 30;
                AddJobButton.Height = 38;
                DeleteJobButton.Height = 38;

                browseEmployeeList.Height = 200; 
                Thickness editButtonMargin = EditButton.Margin;
                editButtonMargin.Top = 294;
                EditButton.Margin = editButtonMargin;
                Thickness deleteButtonMargin = DeleteButton.Margin;
                deleteButtonMargin.Top = 294;
                DeleteButton.Margin = deleteButtonMargin;
                Thickness addButtonMargin = AddButton.Margin;
                addButtonMargin.Top = 294;
                AddButton.Margin = addButtonMargin;
            }
            else
            {
                EditButton.Background = new SolidColorBrush(Color.FromArgb(0, 255, 255, 255));
                ExitButton.Content = "Close";

                editFirstName.Height = 0;
                editLastName.Height = 0;
                StatusesList.Height = 0;
                editWage.Height = 0;
                JobsListBrowse.Height = 0;
                FirstName.Height = 0;
                LastName.Height = 0;
                Status.Height = 0;
                Wage.Height = 0;
                Jobs.Height = 0;
                AddJobButton.Height = 0;
                DeleteJobButton.Height = 0;
                From.Height = 0;
                To.Height = 0;
                datePicker.Height = 0;
                datePickerTo.Height = 0;

                browseEmployeeList.Height = 380;
                Thickness editButtonMargin = EditButton.Margin;
                editButtonMargin.Top = 490;
                EditButton.Margin = editButtonMargin;
                Thickness deleteButtonMargin = DeleteButton.Margin;
                deleteButtonMargin.Top = 490;
                DeleteButton.Margin = deleteButtonMargin;
                Thickness addButtonMargin = AddButton.Margin;
                addButtonMargin.Top = 490;
                AddButton.Margin = addButtonMargin;
            }
            
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Window addEmployeeView = new AddEmployeeWindow();
            addEmployeeView.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            if(isEditActive == 1)
            {
                //call function
            }

            Close();
        }

        private void AddJobButton_Click(object sender, RoutedEventArgs e)
        {
            isAddJobActive = isAddJobActive * (-1);

            if (isAddJobActive == 1)
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

        private void DeleteJobButton_Click(object sender, RoutedEventArgs e)
        {
            JobsListBrowse.Items.Remove(JobsListBrowse.SelectedItem);
        }

        private void ConfirmJobButton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem item = new ListBoxItem();
            item.Content = AddJobField.Text;

            JobsListBrowse.Items.Add(item);

            AddJobField.Text = "";
        }

        private void editJob_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void JobsListBrowse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // editJob.Text = JobsListBrowse.SelectedItem.ToString();
        }

        private void StatusesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            From.Height = 30;
            To.Height = 30;
            datePicker.Height = 30;
            datePickerTo.Height = 30;
        }
    }
}
