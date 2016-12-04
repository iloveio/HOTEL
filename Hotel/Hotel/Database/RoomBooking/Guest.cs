using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database
{
    public class Guest
    {
        public int PESEL { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PlaceOfBirth { get; set; }
    }
}
