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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hotel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Director dyr;
        

        public MainWindow()
        {
            InitializeComponent();
            /*Director.InstantiateDirector("Jan", "Kowalski", 1, new List<Employee>());
            dyr = Director.GetInstance;

            dyr.GetFactory = new SupervisorFactory(new SubordinateFactory(), new List<Employee>());
            List<Job> jobs = new List<Job>();
            Supervisor sup = new Supervisor("john", "mccree", 1);
            Job job = new Job(sup, "zarządanie pracownikami", new DateTime(2016, 12, 07), new DateTime(2016, 12, 30));
            jobs.Add(job);
            dyr.GetSupervisors().Add(dyr.HireAnEmployee("test1", "test2", 0, new EmployeeStatus(EmployeeStatusName.HalfPayLeave, DateTime.Now, new DateTime(2017, 1, 1)), 0, jobs));
            dyr.GetSupervisors().Add(dyr.HireAnEmployee("tttt", "tttt", 0, new EmployeeStatus(EmployeeStatusName.Working, DateTime.Now, new DateTime(2017, 1, 1)), 110, new List<Job>()));*/
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            Window employeeDataView = new EmployeeDataWindow();
            employeeDataView.Show();
        }
    }
}
