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
            int numCount = 0, fizzCount = 0, buzzCount = 0, fbCount = 0;

            string number = "", fizz = "", buzz = "", fizzbuzz = "";

            int[] numbers = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                numbers[i] = i + 1;
            }

            foreach (int n in numbers)
            {
                switch (n)
                {
                    case int num when n % 15 == 0:
                        fizzbuzz += n.ToString() + " FizzBuzz, ";
                        fbCount++;
                        break;
                    case int num when n % 3 == 0:
                        fizz += n.ToString() + " Fizz, ";
                        fizzCount++;
                        break; 
                    case int num when n % 5 == 0:
                        buzz += n.ToString() + " Buzz, ";
                        buzzCount++;
                        break;
                    default:
                        number += n.ToString() + " Number, ";
                        numCount++;
                        break;
                }
            }
            
#region oldcode       

            // for (int i = 1; i <= 1000; i++)
            // {
            //     if (i % 3 == 0 && i % 5 == 0)
            //     {
            //         fbCount++;
            //         Console.WriteLine("Fizzbuzz");
            //     }
            //     else if (i % 3 == 0)
            //     {
            //         fizzCount++;
            //         Console.WriteLine("Fizz");
            //     }
            //     else  if (i % 5 == 0)
            //     {
            //         buzzCount++;
            //         Console.WriteLine("Buzz");
            //     }
            //     else
            //     {
            //         numCount++;
            //         Console.WriteLine(i.ToString());
            //     }
            // }
#endregion

            string[] nbr = number.Split(", ");
            string[] f = fizz.Split(", ");
            string[] b = buzz.Split(", ");
            string[] fb = fizzbuzz.Split(", ");

            number = "";
            fizz = "";
            buzz = "";
            fizzbuzz = "";

            for (int i = 0; i < nbr.Length - 1; i++)
            { 
                if (i != 0 && i % 9 == 0)
                {
                    nbr[i] = "\n" + nbr[i];
                }
                number += nbr[i].ToString() + ", ";
            }

            for (int i = 0; i < f.Length - 1; i++)
            { 
                if (i != 0 && i % 9 == 0)
                {
                    f[i] = "\n" + f[i];
                }
                fizz += f[i].ToString() + ", ";
            }

            for (int i = 0; i < b.Length - 1; i++)
            { 
                if (i != 0 && i % 9 == 0)
                {
                    b[i] = "\n" + b[i];
                }
                buzz += b[i].ToString() + ", "; 
            }

            for (int i = 0; i < fb.Length - 1; i++)
            { 
                if (i != 0 && i % 9 == 0)
                {
                    fb[i] = "\n" + fb[i];
                }
                fizzbuzz += fb[i].ToString() + ", ";
            }


            Console.WriteLine("\nNumber count = " + numCount.ToString() + "\n" + number);
            Console.WriteLine("\nFizz count = " + fizzCount.ToString() + "\n" +  fizz);
            Console.WriteLine("\nBuzz count = " + buzzCount.ToString() + "\n" + buzz);
            Console.WriteLine("\nFizzbuzz count = " + fbCount.ToString() + "\n" + fizzbuzz);
        }
    }
}
