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
        public Hair Hair { set; get; }
        public DateTime Birthday { set; get; }

        //Constructor
        public Person(Gender gender, Hair hair, DateTime birthday)
        {
            Gender = gender;
            Hair = hair;
            DateTime = birthday;
        }

        public override string ToString()
        {
            return $"Gender: {Gender}, Hair Length:{Hair.HairLength}";
        }

    }
}



