using System;
using System.Collections.Generic;

namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            Person prs = new Person();
            int count = 0;

            bool valid = false;

            while(count < 6)
            {
                Console.WriteLine("Please enter first and last name, and age: ");
                string[] per = Console.ReadLine().Split(" ");

                valid = prs.StringValid(per[0]);
                valid = prs.StringValid(per[1]);
                valid = prs.IntValid(per[2]);
                
                if (valid)
                {
                    prs.FirstName = per[0];
                    prs.LastName = per[1];
                    prs.PersonAge = Int32.Parse(per[2]);
                    count++;
                }
                else
                {
                    Console.WriteLine("Input values invalid, please try again!");
                }
            }

            Console.WriteLine(prs.ToString());
        }
    }
}
