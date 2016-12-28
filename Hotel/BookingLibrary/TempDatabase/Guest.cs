using System;

namespace BookingLibrary.TempDatabase
{
    public class Guest
    {
        public Guest(uint pesel, string name, string surname, string placeOfBirth)
        {
            PESEL = pesel;
            Name = name;
            Surname = surname;
            PlaceOfBirth = placeOfBirth;
        }

        public uint PESEL { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PlaceOfBirth { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}, {PESEL}, {PlaceOfBirth}";
        }
    }
}