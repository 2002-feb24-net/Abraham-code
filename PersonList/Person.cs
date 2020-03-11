using System;

namespace PersonList
{
    class Person
    {            
        private string firstName;
        private string lastName;
        private int personAge;
        // parameter constructor
        public Person(string f, string l, int a)
        {
            FirstName = f;
            LastName = l;
            PersonAge = a;
        }
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

        static public bool IsValid(string[] value)
        {
            bool flag = true;
            if (value[0] == "" || value[1] == "")
            {
                flag = false;
            }
            
            int number;
            bool succsess = Int32.TryParse(value[2], out number);

            if (succsess == true && flag == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}