using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();
            int count = 1;
            bool valid = true;

            while(count < 6)
            {
                Console.WriteLine("Please enter first and last name, and age: ");
                string[] per = Console.ReadLine().Split(" ");

                valid = Person.IsValid(per);
                
                if (valid)
                {
                    person.Add(new Person(per[0], per[1], Int32.Parse(per[2])));
                    count++;
                }
                else
                {
                    Console.WriteLine("Input values invalid, please try again!");
                }
            }
            CheckForDups(person);
            SortPerson(person);
        }

        static void CheckForDups(List<Person> prs)
        {     
            HashSet<Person> set = new HashSet<Person>();
            var dups = prs.GroupBy(x => x.LastName);

            foreach(IGrouping<string, Person> d in dups)
            {
                Console.WriteLine(d.Distinct());
            }
        }

        static void SortPerson(List<Person> prs)
        {

        }
    }
}
