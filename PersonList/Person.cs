using System;

namespace PersonList
{
    class Person
    {            
        private string firstName;
        private string lastName;
        private int personAge;

        public string FirstName 
        { 
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int PersonAge
        {
            get { return personAge; }
            set { personAge = value; }
        }

        public bool StringValid(string value)
        {
            if (value != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IntValid(string value)
        {
            int number;
            bool succsess = Int32.TryParse(value, out number);
            return succsess;
        }
    }
}