using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentApp
{
    public abstract class Entertainment
    {
        protected float price { get; set; }
        protected string name { get; set; }
        protected List<Employee> employeeList { get; set; }

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
