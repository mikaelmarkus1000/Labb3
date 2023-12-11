using Labb3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class Person
    {
        public Gender Gender { get; set; }
        public Hair Hair { get; set; }
        public DateTime Birthday { get; set; }
        public Name Name { get; set; }

        public string EyeColour { get; set; }
        

        // Constructor to initialize properties
        public Person(Gender gender, Hair hair, DateTime birthday, string eyeColour, Name name)
        {
            Gender = gender;
            Hair = hair;
            Birthday = birthday;
            EyeColour = eyeColour;
            Name = name;
        }

        // Override ToString method for custom output
        public override string ToString()
        {
            return  $"\nName: {Name.FirstName} {Name.LastName} " +
                    $"\nGender: {Gender}" +
                    $"\nHair Length: {Hair.HairLength} Centimeters" +
                    $"\nHair Color: {Hair.HairColour}" +
                    $"\nBirthday: {Birthday:dd,MM,yyyy}" +
                    $"\nEye Colour: {EyeColour}";




        }
    }
}



