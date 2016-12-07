using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentApp
{
    public class Employee
    {
        private string name {get; set;}
        private string surname { get; set; }
        public Employee (string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public Employee (Employee emp)
        {
            name = emp.name;
            surname = emp.surname;
        }
        override public string ToString()
        {
            return name + " " + surname;
        }
    }
}
