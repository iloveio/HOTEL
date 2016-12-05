using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountancyLib
{
    public class Accountant
    {
        SalaryCheck SalaryChecker = new SalaryCheck();

        public Accountant()
        {

        }

        public float DayIncome { get; private set; }

        public void MakeABill(float income, String purpose, String module)
        {
            Bill tempBill = new Bill(income, purpose, module);

            // TODO: Save tempBill to the DataBase

            DayIncome += income;
        }

        public void LastDaysIncomeDiagram(uint days)
        {
            throw new NotImplementedException();
        }

        //public Double DayIncome()
        //{

        //}

        public void NewDay()
        {
            // TODO: Save DayIncome to the DataBase

            DayIncome = 0;
            SalaryChecker.CheckEmployeeList();
        }

        public void DetailedDiagram(DateTime date, String module)
        {
            throw new NotImplementedException();
        }
    }
}
