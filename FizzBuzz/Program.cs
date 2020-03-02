using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pop pop fizz fizz oh what a relief it is!");
            FizzingBuzzing();
        }
        
        static void FizzingBuzzing()
        {
            int numCount = 0;
            int fizzCount = 0;
            int buzzCount = 0;
            int fbCount = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    fbCount++;
                    Console.WriteLine("Fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    fizzCount++;
                    Console.WriteLine("Fizz");
                }
                else  if (i % 5 == 0)
                {
                    buzzCount++;
                    Console.WriteLine("Buzz");
                }
                else
                {
                    numCount++;
                    Console.WriteLine(i.ToString());
                }
            }

            Console.WriteLine("Fizz count = " + fizzCount.ToString());
            Console.WriteLine("Buzz count = " + buzzCount.ToString());
            Console.WriteLine("Fizzbuzz count = " + fbCount.ToString());
            Console.WriteLine("Number count = " + numCount.ToString());
        }
    }
}
