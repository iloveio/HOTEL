using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentApp
{
    public class Guest
    {
        public Guest(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public string name { get;set;}
        public string surname { get; set; }
        public int ID { get; set; }

        public string fullName
        {
            get
            {
                return surname + " " + name;
            }
        }

    }
}
