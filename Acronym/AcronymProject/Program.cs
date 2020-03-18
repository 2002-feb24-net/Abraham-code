using System;

namespace AcronymProject
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a series of words to create an acronym: ");
            string acronym = CreateAcronym(Console.ReadLine();
            Console.WriteLine("Your acronym: " + acronym.ToUpper())
        }

        static string CreateAcronym(string acr)
        {
            string phrase = "";
            string[] newPhrase = acr.Split(' ');
            foreach (string s in newPhrase)
            {
                phrase += s.Substring(0,  1);
            }
            return phrase;
        }
    }
}
