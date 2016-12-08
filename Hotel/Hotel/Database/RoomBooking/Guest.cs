using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Database
{
    public class Guest
    {
        [Key]
        public int PESEL { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PlaceOfBirth { get; set; }

        public Guest(int pesel, string name, string surname, string placeofbirth)
        {
            this.PESEL = pesel;
            this.Name = name;
            this.Surname = surname;
            this.PlaceOfBirth = placeofbirth;
        }
    }
}
