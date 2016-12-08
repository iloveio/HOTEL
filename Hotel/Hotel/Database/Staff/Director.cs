using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Database.Staff
{
    public class Director
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public virtual List<Employee> supervisors { get; set; }

        public Director(int id, string name, string lastname, List<Employee> supervisors)
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
            this.supervisors = supervisors;
        }
    }
}
