using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Database;

namespace EntertainmentApp
{
    public abstract class Entertainment
    {
        public float price { get; set; }
        public string name { get; set; }
        public List<Employee> employeeList { get; set; }

        public void addEmployeeToShift(Employee employee)
        {
            employeeList.Add(employee);
        }
        public void removeEmployeeFromShift(Employee employee)
        {
            employeeList.Remove(employee);
        }
    }
}
