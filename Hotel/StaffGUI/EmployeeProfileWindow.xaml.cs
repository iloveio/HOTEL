////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	EmployeeProfileWindow.xaml.cs
//
// summary:	Implements the employee profile window.xaml class
////////////////////////////////////////////////////////////////////////////////////////////////////

using Hotel.Database;
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
using HumanResourcesLib;

namespace StaffGUI
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Interaction logic for EmployeeProfileWindow.xaml. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public partial class EmployeeProfileWindow : Window
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        StaffManager staffManager;

        User user;

        public EmployeeProfileWindow(User user)
        {
            InitializeComponent();
            staffManager = new StaffManager();
            this.user = user;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by ExitModule for click events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Routed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ExitModule_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by JobsList for selection changed events. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Selection changed event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void JobsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
