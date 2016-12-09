using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountancyLib
{
    class SalaryCheck
    {
        Accountant Accounter = new Accountant();

        public SalaryCheck() { }

        public List<HumanResources.Employee> EmployeeList { get; private set; }

        public void SalaryDate()
        {
            // TODO: Get salary date of Employees
        }

        public void CheckEmployeeList()
        {
            // TODO: Get list of Employees from the DataBase
            EmployeeList = DataBase.GetAllEmployees();

            foreach (var employee in EmployeeList)
            {
                PaySalary(employee);
            }

            // TODO: Send flag to the DataBase
        }

        private void PaySalary(HumanResources.Employee employee)
        {
            Accounter.MakeABill(employee.Wage, "Salary", "Accountancy");
        }
    }
}
