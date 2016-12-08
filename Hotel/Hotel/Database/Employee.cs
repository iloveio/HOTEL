using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Database
{
    public class Employee
    {
        [Key]
        public int id { get;set;}
    }
}
