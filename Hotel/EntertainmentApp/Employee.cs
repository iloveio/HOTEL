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
        override public string ToString()
        {
            return name + " " + surname;
        }
    }
}
