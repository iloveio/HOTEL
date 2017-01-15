////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	AddEmployeeWindow.xaml.cs
//
// summary:	Implements the add employee window.xaml class
////////////////////////////////////////////////////////////////////////////////////////////////////


using Hotel.Database;
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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
//using HumanResourcesLib;
//using BuilderTest;
//using System.Linq;


namespace StaffGUI
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Interaction logic for AddEmployeeWindow.xaml. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public partial class AddEmployeeWindow : Window
    {
        /// <summary>   The is edit active. </summary>
        private int isEditActive = -1;
        /// <summary>   The jobs. </summary>
        private List<Job> jobs;
        /// <summary>   Zero-based index of the job. </summary>
        private int jobIndex = 0;
        /// <summary>   List of employees. </summary>
        private ListBox employeeList;

        //Supervisor sup; //for future uses
        /// <summary>   The dyr. </summary>
        //Director dyr;

        StaffManager staffManager;

        Postion position;

        IManager manager;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="employeeList"> List of employees. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public AddEmployeeWindow(ListBox employeeList, IManager manager)
        {
            InitializeComponent();
            //dyr = Director.GetInstance;
            jobs = new List<Job>();
            this.employeeList = employeeList;
            staffManager = new StaffManager();
            this.manager = manager;

            ListBoxItem item1 = new ListBoxItem();
            ListBoxItem item2 = new ListBoxItem();
            ListBoxItem item3 = new ListBoxItem();
            ListBoxItem item4 = new ListBoxItem();
            ListBoxItem item5 = new ListBoxItem();
            ListBoxItem item6 = new ListBoxItem();
            ListBoxItem item7 = new ListBoxItem();
            ListBoxItem item8 = new ListBoxItem();
            ListBoxItem item9 = new ListBoxItem();
            ListBoxItem item10 = new ListBoxItem();

            item1.Content = Postion.Accounting;
            item2.Content = Postion.AccountingMenager;
            item3.Content = Postion.EventMenager;
            item4.Content = Postion.EventStaff;
            item5.Content = Postion.KitchenManager;
            item6.Content = Postion.KitchenStaff;
            item7.Content = Postion.RoomService;
            item8.Content = Postion.RoomServiceMenager;
            item9.Content = Postion.Transportation;
            item10.Content = Postion.TransportationManager;

            PositionsList.Items.Add(item1);
            PositionsList.Items.Add(item2);
            PositionsList.Items.Add(item3);
            PositionsList.Items.Add(item4);
            PositionsList.Items.Add(item5);
            PositionsList.Items.Add(item6);
            PositionsList.Items.Add(item7);
            PositionsList.Items.Add(item8);
            PositionsList.Items.Add(item9);
            PositionsList.Items.Add(item10);


            //sup = new Supervisor("Jan", "Kowalski", 1, new EmployeeStatus(EmployeeStatusName.Working, new DateTime(2016, 12, 6), new DateTime(2017, 1, 1)), new List<Employee>(), 1000, new List<Job>(), );
            //for future uses

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by ListBox for selection changed events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Selection changed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            jobIndex = JobsList.SelectedIndex;

            if (JobsList.SelectedIndex != -1)
            {
                JobDateFrom.Text = jobs[jobIndex].StartDate;
                JobDateTo.Text = jobs[jobIndex].Deadline;
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
            if (JobsList.SelectedIndex != -1)
            {
                JobDateFrom.Clear();
                JobDateTo.Clear();

                jobs.RemoveAt(JobsList.SelectedIndex);
                JobsList.Items.Remove(JobsList.SelectedItem);
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

                jobs.Add(job);

                JobsList.Items.Add(item);

                AddJobField.Text = "";

                JobsList.UpdateLayout();
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
            isEditActive = isEditActive * (-1);

            if (isEditActive == 1)
            {
                AddJobButton.Background = new SolidColorBrush(Color.FromRgb(156, 156, 156));

                AddJobField.Height = 30;
                ConfirmJobButton.Height = 38;
                AddJobDateFromText.Height = 30;
                AddJobDateToText.Height = 30;
                AddJobDateFromField.Height = 30;
                AddJobDateToField.Height = 30;
                AddJobDateFromField.Height = 24;
                AddJobDateToField.Height = 24;
            }
            else
            {
                AddJobButton.Background = new SolidColorBrush(Color.FromArgb(0, 255, 255, 255));

                AddJobField.Height = 0;
                ConfirmJobButton.Height = 0;
                AddJobDateFromText.Height = 0;
                AddJobDateToText.Height = 0;
                AddJobDateFromField.Height = 0;
                AddJobDateToField.Height = 0;
                AddJobDateFromField.Height = 0;
                AddJobDateToField.Height = 0;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by AddEmployeeButton for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            //staffManager.directorList[0].GetFactory = new SupervisorFactory(new List<Employee>());

            try
            {
                Enum.TryParse(PositionsList.SelectedItem.ToString(), out position);

            Employee emp;

            emp = manager.HireAnEmployee(AddFirstName.Text, AddLastName.Text, 0, new EmployeeStatus(EmployeeStatusName.Working, DateTime.Now, new DateTime(2017, 10, 10)), float.Parse(AddWage.Text), jobs, AddLogin.Text, AddPassword.Text, position);
            if (emp.GetType() == typeof(Supervisor))
            {
                staffManager.AddNewSupervisor((Supervisor)emp);
            }

            if (emp.GetType() == typeof(Subordinate))
            {
                staffManager.AddNewSubordinate((Subordinate)emp);
            }
            //staffManager.AddNewSupervisor((Supervisor)manager.HireAnEmployee(AddFirstName.Text, AddLastName.Text, 0, new EmployeeStatus(EmployeeStatusName.Working, DateTime.Now, new DateTime(2017, 10, 10)), float.Parse(AddWage.Text), jobs, AddLogin.Text, AddPassword.Text, position));
            //staffManager.directorList[0].GetSupervisors().Add(staffManager.directorList[0].HireAnEmployee(AddFirstName.Text, AddLastName.Text, 0, new EmployeeStatus(EmployeeStatusName.Working, DateTime.Now, new DateTime(2017, 10, 10)), float.Parse(AddWage.Text), jobs, AddLogin.Text, AddPassword.Text, position));       
            staffManager.SerializeSupervisor();
            staffManager.SerializeSubordinates();
            staffManager.FillDataWithAllSubordinates();
            staffManager.FillDataWithAllSupervisor();
            employeeList.Items.Refresh();
            Close();
            }
            catch (NullReferenceException n)
            {

                MessageBox.Show("Musisz Wybrac Pole Position");
               
            }
        }


    }
}
