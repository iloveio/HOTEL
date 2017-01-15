////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	MainWindow.xaml.cs
//
// summary:	Implements the main window.xaml class
////////////////////////////////////////////////////////////////////////////////////////////////////

using Hotel.Database;
using HumanResourcesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace StaffGUI
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Interaction logic for MainWindow.xaml. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public partial class MainWindow : Window
    {
        IManager manager;
        StaffManager staffManager;
        User user;

        public User User
        {
            get { return user; }
            set { user = value; }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public MainWindow()
        {
            InitializeComponent();
        

       
        
            
            //manager = new Director("Jan", "Kowalski", 1, new List<Employee>(), "testLogin", "qwerty123");

            //Supervisor sup = new Supervisor("Zenek", "Martyniuk", 1, "testLogin11", "qwerty123");

            //manager.HireAnEmployee("Zenek", "Martyniuk", 1, "testLogin11", "qwerty123", new List<Job>());
           
            staffManager = new StaffManager();
            staffManager.AddNewDirector((Director)manager);
            staffManager.SerializeDirectors();
            staffManager.SerializeJobs();
            staffManager.SerializeSubordinates();
            staffManager.SerializeSupervisor();

            /*dyr.GetFactory = new SupervisorFactory(new SubordinateFactory(), new List<Employee>());
            List<Job> jobs = new List<Job>();
            Supervisor sup = new Supervisor("john", "mccree", 1);
            Job job = new Job(sup, "zarządanie pracownikami", new DateTime(2016, 12, 07), new DateTime(2016, 12, 30));
            jobs.Add(job);
            dyr.GetSupervisors().Add(dyr.HireAnEmployee("test1", "test2", 0, new EmployeeStatus(EmployeeStatusName.HalfPayLeave, DateTime.Now, new DateTime(2017, 1, 1)), 0, jobs));
            dyr.GetSupervisors().Add(dyr.HireAnEmployee("tttt", "tttt", 0, new EmployeeStatus(EmployeeStatusName.Working, DateTime.Now, new DateTime(2017, 1, 1)), 110, new List<Job>()));*/
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
            manager = (IManager)User;

            if (manager.GetType() == typeof(Supervisor))
            {
                Supervisor sup = (Supervisor)manager;
                for (int i = 0; i < staffManager.supervisorList.Count; i++)
                {
                    if (sup.Login == staffManager.supervisorList[i].Login)
                    {
                        staffManager.supervisorList[i] = sup;
                    }
                }             
                staffManager.SerializeSupervisor();
            }

            if (manager.GetType() == typeof(Director))
            {
                Director dyr = (Director)manager;
                for (int i=0; i < staffManager.directorList.Count; i++)
                {
                    if(dyr.Login == staffManager?.directorList[i]?.Login)
                    {
                        staffManager.directorList[i] = dyr;
                    }
                }
                staffManager.SerializeDirectors();
            }
            
            
            Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by ViewButton for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            manager = (IManager)User;

            Window employeeDataView = new EmployeeDataWindow(manager);
            employeeDataView.Show();
        }
    }
}
