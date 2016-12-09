using HumanResourcesLib;
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
        private int index = 0;
        private int jobIndex = 0;
        Director dyr;
        EmployeeStatusName status;

        public EmployeeDataWindow()
        {
            InitializeComponent();

            ListBoxItem item1 = new ListBoxItem();
            ListBoxItem item2 = new ListBoxItem();
            ListBoxItem item3 = new ListBoxItem();
            ListBoxItem item4 = new ListBoxItem();
            ListBoxItem item5 = new ListBoxItem();
            ListBoxItem item6 = new ListBoxItem();

            item1.Content = EmployeeStatusName.Working;
            item2.Content = EmployeeStatusName.SickLeave;
            item3.Content = EmployeeStatusName.MaternityOrPaternityLeave;
            item4.Content = EmployeeStatusName.HalfPayLeave;
            item5.Content = EmployeeStatusName.ExtraOrdinaryLeave;
            item6.Content = EmployeeStatusName.ErnedLeave;

            StatusesList.Items.Add(item1);
            StatusesList.Items.Add(item2);
            StatusesList.Items.Add(item3);
            StatusesList.Items.Add(item4);
            StatusesList.Items.Add(item5);
            StatusesList.Items.Add(item6);

            //datePicker.SelectedDate = DateTime.Now;
            //dyr = Director.GetInstance;           
            //browseEmployeeList.ItemsSource = dyr.GetSupervisors();
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
                JobsListBrowse.Height = 80;
                JobDateFrom.Height = 30;
                JobDateTo.Height = 30;
                JobDateFromText.Height = 30;
                JobDateToText.Height = 30;
                SupervisorText.Height = 30;
                SupervisorField.Height = 30;
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
                JobDateFrom.Height = 0;
                JobDateTo.Height = 0;
                JobDateFromText.Height = 0;
                JobDateToText.Height = 0;
                SupervisorText.Height = 0;
                SupervisorField.Height = 0;
                AddJobDateFromText.Height = 0;
                AddJobDateToText.Height = 0;
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
                AddJobDateFromField.Height = 0;
                AddJobDateToField.Height = 0;
                ConfirmJobButton.Height = 0;
                AddJobField.Height = 0;

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
            if(browseEmployeeList.SelectedIndex != -1)
            {
                dyr.GetSupervisors().RemoveAt(browseEmployeeList.SelectedIndex);
                browseEmployeeList.Items.Refresh();
                editFirstName.Clear();
                editLastName.Clear();
                editWage.Clear();
                StatusesList.Items.Refresh();
                JobsListBrowse.Items.Clear();
                JobsListBrowse.Items.Refresh();
                JobDateFrom.Clear();
                JobDateTo.Clear();
                SupervisorField.Clear();
            }       
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Window addEmployeeView = new AddEmployeeWindow(browseEmployeeList);
            addEmployeeView.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            if(isEditActive == 1)
            {
                if(browseEmployeeList.SelectedIndex != -1)
                {
                    dyr.GetSupervisors()[index].nameProperty = editFirstName.Text;
                    dyr.GetSupervisors()[index].lastNameProperty = editLastName.Text;
                    dyr.GetSupervisors()[index].Wage = float.Parse(editWage.Text);
                    if (StatusesList.SelectedIndex != -1)
                    {
                        switch(StatusesList.SelectedIndex)
                        {
                            case 0:
                                status = EmployeeStatusName.Working;
                                break;
                            case 1:
                                status = EmployeeStatusName.SickLeave;
                                break;
                            case 2:
                                status = EmployeeStatusName.MaternityOrPaternityLeave;
                                break;
                            case 3:
                                status = EmployeeStatusName.ExtraOrdinaryLeave;
                                break;
                            case 4:
                                status = EmployeeStatusName.ErnedLeave;
                                break;
                            case 5:
                                status = EmployeeStatusName.HalfPayLeave;
                                break;
                        }
                        EmployeeStatus employeeStatus = new EmployeeStatus(status, DateTime.Parse(datePicker.Text), DateTime.Parse(datePickerTo.Text));
                       // EmployeeStatus employeeStatus = new EmployeeStatus(EmployeeStatusName.Working, new DateTime(2016, 12, 12), new DateTime(2016, 12, 12));
                        dyr.GetSupervisors()[index].EmployeeStatus = employeeStatus;
                    }
                    //browseEmployeeList.InvalidateArrange();
                    //browseEmployeeList.UpdateLayout();
                    browseEmployeeList.Items.Refresh();
                    //isEditActive = -1;
                    //ExitButton.UpdateLayout();
                }    
            }
            else
            {
                Close();
            }

            
        }

        private void AddJobButton_Click(object sender, RoutedEventArgs e)
        {
            isAddJobActive = isAddJobActive * (-1);

            if (isAddJobActive == 1)
            {
                AddJobButton.Background = new SolidColorBrush(Color.FromRgb(156, 156, 156));

                AddJobField.Height = 30;
                ConfirmJobButton.Height = 38;
                AddJobDateFromField.Height = 25;
                AddJobDateToField.Height = 25;
                AddJobDateFromText.Height = 30;
                AddJobDateToText.Height = 30;
            }
            else
            {
                AddJobButton.Background = new SolidColorBrush(Color.FromArgb(0, 255, 255, 255));

                AddJobField.Height = 0;
                ConfirmJobButton.Height = 0;
                AddJobDateFromField.Height = 0;
                AddJobDateToField.Height = 0;
                AddJobDateFromText.Height = 0;
                AddJobDateToText.Height = 0;
            }
        }

        private void DeleteJobButton_Click(object sender, RoutedEventArgs e)
        {
            if(JobsListBrowse.SelectedIndex != -1)
            {
                JobDateFrom.Clear();
                JobDateTo.Clear();
                SupervisorField.Clear();

                dyr.GetSupervisors()[index].jobsProperty.RemoveAt(JobsListBrowse.SelectedIndex);
                JobsListBrowse.Items.Remove(JobsListBrowse.SelectedItem);
            }     
        }

        private void ConfirmJobButton_Click(object sender, RoutedEventArgs e)
        {
            if(AddJobDateFromField.SelectedDate != null && AddJobDateToField.SelectedDate != null)
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = AddJobField.Text;

                DateTime dateFrom = DateTime.Parse(AddJobDateFromField.Text);
                DateTime dateTo = DateTime.Parse(AddJobDateToField.Text);

                Job job = new Job(AddJobField.Text, dateFrom, dateTo);

                dyr.GetSupervisors()[index].jobsProperty.Add(job);

                JobsListBrowse.Items.Add(item);

                AddJobField.Text = "";

                JobsListBrowse.UpdateLayout();
            }
            
        }

        private void editJob_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void JobsListBrowse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            jobIndex = JobsListBrowse.SelectedIndex;

            JobDateFrom.Clear();
            JobDateTo.Clear();
            SupervisorField.Clear();

            if(dyr.GetSupervisors()[index].jobsProperty.Count != 0)
            {
                if (JobsListBrowse.SelectedIndex != -1)
                {
                    JobDateFrom.Text = dyr.GetSupervisors()[index].jobsProperty[jobIndex].StartDate;
                    JobDateTo.Text = dyr.GetSupervisors()[index].jobsProperty[jobIndex].Deadline;

                    if (dyr.GetSupervisors()[index].jobsProperty[jobIndex].JobSupervisor != null)
                        SupervisorField.Text = dyr.GetSupervisors()[index].jobsProperty[jobIndex].JobSupervisorName;
                }

                

                //SupervisorField.Text = jobIndex.ToString();
            }
            
        }

        private void StatusesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            From.Height = 30;
            To.Height = 30;
            datePicker.Height = 30;
            datePickerTo.Height = 30;
        }

        private void browseEmployeeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(browseEmployeeList.SelectedIndex != -1)
            {
                index = browseEmployeeList.SelectedIndex;
                //editFirstName.DataContext = dyr.GetSupervisors()[index];
                editFirstName.Text = dyr.GetSupervisors()[index].nameProperty;
                editLastName.Text = dyr.GetSupervisors()[index].lastNameProperty;
                //StatusesList.SelectedItem = dyr.GetSupervisors()[index].employeeStatusName;
                //var listBoxItem = (ListBoxItem)StatusesList.ItemContainerGenerator.ContainerFromIndex(2);
                //listBoxItem.Focus();
                datePicker.SelectedDate = dyr.GetSupervisors()[index].employeeStatusDateFrom;
                datePickerTo.SelectedDate = dyr.GetSupervisors()[index].employeeStatusDateTo;
                editWage.Text = dyr.GetSupervisors()[index].wageProperty;

                JobsListBrowse.Items.Clear();
                JobsListBrowse.UpdateLayout();
                //JobsListBrowse.ItemsSource = dyr.GetSupervisors()[index].jobsProperty;
                for (int i = 0; i < dyr.GetSupervisors()[index].Jobs.Count; i++)
                {
                    ListBoxItem item = new ListBoxItem();
                    item.Content = dyr.GetSupervisors()[index].jobsProperty[i].Description;
                    JobsListBrowse.Items.Add(item);
                }
            }       
        }
    }
}
