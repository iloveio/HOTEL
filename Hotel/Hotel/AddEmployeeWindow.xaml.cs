﻿using HumanResourcesLib;
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
        private List<Job> jobs;
        private int jobIndex = 0;
        private ListBox employeeList;

        //Supervisor sup; //for future uses
        Director dyr;

        public AddEmployeeWindow(ListBox employeeList)
        {
            InitializeComponent();
            //dyr = Director.GetInstance;
            jobs = new List<Job>();
            this.employeeList = employeeList;

            //sup = new Supervisor("Jan", "Kowalski", 1, new EmployeeStatus(EmployeeStatusName.Working, new DateTime(2016, 12, 6), new DateTime(2017, 1, 1)), new List<Employee>(), 1000, new List<Job>(), );
            //for future uses

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            jobIndex = JobsList.SelectedIndex;

            if (JobsList.SelectedIndex != -1)
            {
                JobDateFrom.Text = jobs[jobIndex].StartDate;
                JobDateTo.Text = jobs[jobIndex].Deadline;
            }
        }
      

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

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            dyr.GetFactory = new SupervisorFactory(new SubordinateFactory(), new List<Employee>());


            dyr.GetSupervisors().Add(dyr.HireAnEmployee(AddFirstName.Text, AddLastName.Text, 0, new EmployeeStatus(EmployeeStatusName.Working, DateTime.Now, new DateTime(2017, 1, 1)), float.Parse(AddWage.Text), jobs));
            employeeList.Items.Refresh();
            Close();
        }


    }
}
