////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	BrowseEmployeesViewModel.cs
//
// summary:	Implements the browse employees view model class
////////////////////////////////////////////////////////////////////////////////////////////////////

using HumanResourcesLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A ViewModel for the browse employees. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class BrowseEmployeesViewModel
    {
        /// <summary>   The employees. </summary>
        private ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public BrowseEmployeesViewModel()
        {
            employees.Add(new Subordinate("test", "test", 1, new EmployeeStatus(EmployeeStatusName.Working, new DateTime(2016, 12, 12), new DateTime(2016, 12, 13)), 10, new List<Job>(),"testLogin","qwerty123",Postion.Accounting));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the get employees. </summary>
        ///
        /// <value> The get employees. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public ObservableCollection<Employee> GetEmployees { get { return employees; } set { employees = value; } }



    }
}
