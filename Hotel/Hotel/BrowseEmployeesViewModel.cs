using HumanResourcesLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class BrowseEmployeesViewModel : ViewModelBase
    {
        private ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public BrowseEmployeesViewModel()
        {
            employees.Add(new Subordinate("test", "test", 1, new EmployeeStatus(EmployeeStatusName.Working, new DateTime(2016, 12, 12), new DateTime(2016, 12, 13)), 10, new List<Job>()));
        }

        public ObservableCollection<Employee> GetEmployees { get { return employees; } set { employees = value; } }



    }
}
