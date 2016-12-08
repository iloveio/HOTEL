using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Database.Transportation
{
    public class Transportation
    {
        public Transportation(Employee emp, DateTime date, string desc)
        {
            employee = emp;
            this.date = date;
            description = desc;
        }
        public virtual Employee employee { get; set; }
        public DateTime date { get; set; }
        [Key]
        public string description { get; set; }

    }
}
