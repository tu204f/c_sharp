using System;
using System.Collections.Generic;
using System.Text;

namespace PersonClass
{
    class Person
    {
        public Person(string firstrName, string lastName)
        {
            this.FirstName = firstrName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return this.FirstName + " " + LastName;
        }


        public new bool Equals(Object obj)
        {
            Person person = (Person)obj;
            return (this.FirstName == person.FirstName) && (this.LastName == person.LastName);
        }

    }
}
