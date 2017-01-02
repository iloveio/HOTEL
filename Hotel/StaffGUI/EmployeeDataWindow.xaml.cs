////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	EmployeeDataWindow.xaml.cs
//
// summary:	Implements the employee data window.xaml class
////////////////////////////////////////////////////////////////////////////////////////////////////

using Hotel.Database.Staff;
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


namespace StaffGUI
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Interaction logic for EmployeeDataWindow.xaml. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public partial class EmployeeDataWindow : Window
    {
        /// <summary>   The is edit active. </summary>
        private int isEditActive = -1;
        /// <summary>   The is add job active. </summary>
        private int isAddJobActive = -1;
        /// <summary>   Zero-based index of the. </summary>
        private int index = 0;
        /// <summary>   Zero-based index of the job. </summary>
        private int jobIndex = 0;
        /// <summary>   The dyr. </summary>
        //Director dyr;
        /// <summary>   The status. </summary>
        EmployeeStatusName status;

        StaffManager staffManager;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public EmployeeDataWindow(StaffManager staffManager)
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
            this.staffManager = staffManager;

            browseEmployeeList.ItemsSource = staffManager.directorList[0].GetSupervisors();
            
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by EditButton for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

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

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by DeleteButton for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (browseEmployeeList.SelectedIndex != -1)
            {
                staffManager.directorList[0].GetSupervisors().RemoveAt(browseEmployeeList.SelectedIndex);
                //staffManager.DeleteSupervisor(browseEmployeeList.)
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

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by AddButton for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Window addEmployeeView = new AddEmployeeWindow(browseEmployeeList, staffManager);
            addEmployeeView.Show();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by ExitButton for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            if (isEditActive == 1)
            {
                if (browseEmployeeList.SelectedIndex != -1)
                {
                    staffManager.directorList[0].GetSupervisors()[index].nameProperty = editFirstName.Text;
                    staffManager.directorList[0].GetSupervisors()[index].lastNameProperty = editLastName.Text;
                    staffManager.directorList[0].GetSupervisors()[index].Wage = float.Parse(editWage.Text);
                    if (StatusesList.SelectedIndex != -1)
                    {
                        switch (StatusesList.SelectedIndex)
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
                                status = EmployeeStatusName.HalfPayLeave;
                                break;
                            case 4:
                                status = EmployeeStatusName.ExtraOrdinaryLeave;
                                break;
                            case 5:
                                status = EmployeeStatusName.ErnedLeave;
                                break;
                        }
                        EmployeeStatus employeeStatus = new EmployeeStatus(status, DateTime.Parse(datePicker.Text), DateTime.Parse(datePickerTo.Text));
                        // EmployeeStatus employeeStatus = new EmployeeStatus(EmployeeStatusName.Working, new DateTime(2016, 12, 12), new DateTime(2016, 12, 12));
                        staffManager.directorList[0].GetSupervisors()[index].EmployeeStatus = employeeStatus;
                    }
                    //browseEmployeeList.InvalidateArrange();
                    //browseEmployeeList.UpdateLayout();
                    browseEmployeeList.Items.Refresh();
                    //isEditActive = -1;
                    //ExitButton.UpdateLayout();

                    //staffManager.UpdateSupervisor(dyr.GetSupervisors()[index], new Supervisor(editFirstName.Text, editLastName.Text), float.Parse(editWage.Text), emplo)
                }
            }
            else
            {
                Close();
            }


        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by AddJobButton for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

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

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by DeleteJobButton for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void DeleteJobButton_Click(object sender, RoutedEventArgs e)
        {
            if (JobsListBrowse.SelectedIndex != -1)
            {
                JobDateFrom.Clear();
                JobDateTo.Clear();
                SupervisorField.Clear();

                staffManager.directorList[0].GetSupervisors()[index].jobsProperty.RemoveAt(JobsListBrowse.SelectedIndex);
                JobsListBrowse.Items.Remove(JobsListBrowse.SelectedItem);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by ConfirmJobButton for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ConfirmJobButton_Click(object sender, RoutedEventArgs e)
        {
            if (AddJobDateFromField.SelectedDate != null && AddJobDateToField.SelectedDate != null)
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = AddJobField.Text;

                DateTime dateFrom = DateTime.Parse(AddJobDateFromField.Text);
                DateTime dateTo = DateTime.Parse(AddJobDateToField.Text);

                Job job = new Job(AddJobField.Text, dateFrom, dateTo);

                staffManager.directorList[0].GetSupervisors()[index].jobsProperty.Add(job);

                JobsListBrowse.Items.Add(item);

                AddJobField.Text = "";

                JobsListBrowse.UpdateLayout();
            }

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by editJob for text changed events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Text changed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void editJob_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by JobsListBrowse for selection changed events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Selection changed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void JobsListBrowse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            jobIndex = JobsListBrowse.SelectedIndex;

            JobDateFrom.Clear();
            JobDateTo.Clear();
            SupervisorField.Clear();

            if (staffManager.directorList[0].GetSupervisors()[index].jobsProperty.Count != 0)
            {
                if (JobsListBrowse.SelectedIndex != -1)
                {
                    JobDateFrom.Text = staffManager.directorList[0].GetSupervisors()[index].jobsProperty[jobIndex].StartDate;
                    JobDateTo.Text = staffManager.directorList[0].GetSupervisors()[index].jobsProperty[jobIndex].Deadline;

                    if (staffManager.directorList[0].GetSupervisors()[index].jobsProperty[jobIndex].JobSupervisor != null)
                        SupervisorField.Text = staffManager.directorList[0].GetSupervisors()[index].jobsProperty[jobIndex].JobSupervisorName;
                }



                //SupervisorField.Text = jobIndex.ToString();
            }

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by StatusesList for selection changed events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Selection changed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void StatusesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            From.Height = 30;
            To.Height = 30;
            datePicker.Height = 30;
            datePickerTo.Height = 30;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Event handler. Called by browseEmployeeList for selection changed events.
        /// </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Selection changed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void browseEmployeeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (browseEmployeeList.SelectedIndex != -1)
            {
                index = browseEmployeeList.SelectedIndex;
                //editFirstName.DataContext = dyr.GetSupervisors()[index];
                editFirstName.Text = staffManager.directorList[0].GetSupervisors()[index].nameProperty;
                editLastName.Text = staffManager.directorList[0].GetSupervisors()[index].lastNameProperty;
                //StatusesList.SelectedItem = dyr.GetSupervisors()[index].employeeStatusName;
                //var listBoxItem = (ListBoxItem)StatusesList.ItemContainerGenerator.ContainerFromIndex(2);
                //listBoxItem.Focus();
                datePicker.SelectedDate = staffManager.directorList[0].GetSupervisors()[index].employeeStatusDateFrom;
                datePickerTo.SelectedDate = staffManager.directorList[0].GetSupervisors()[index].employeeStatusDateTo;
                editWage.Text = staffManager.directorList[0].GetSupervisors()[index].wageProperty;

                JobsListBrowse.Items.Clear();
                JobsListBrowse.UpdateLayout();
                //JobsListBrowse.ItemsSource = dyr.GetSupervisors()[index].jobsProperty;
                for (int i = 0; i < staffManager.directorList[0].GetSupervisors()[index].Jobs.Count; i++)
                {
                    ListBoxItem item = new ListBoxItem();
                    item.Content = staffManager.directorList[0].GetSupervisors()[index].jobsProperty[i].Description;
                    JobsListBrowse.Items.Add(item);
                }
            }
        }
    }
}
