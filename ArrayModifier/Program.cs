using System;

namespace ArrayModifier
{
    class Program
    {
        // accept input from user, list of numbers separated by spaces
        // interpret that as an int array
        // print the array's values back to the user
        // ask the user for some operation
        // print the array's new values to the user.
        static void Main(string[] args)
        {
            string input = GetInput();
            int[] array = InterpretStringAsArray(input);
            PrintArray(array);
            FindFirstRepeat(array);
        }

        static void PrintArray(int[] a)
        {
            Console.Write("Your Array: ");

            for (int i = 0; i < a.Length; i++)
            {
                string numAsString = a[i].ToString();
                Console.Write(numAsString + " ");
            }
            Console.WriteLine();
        }

        static int[] InterpretStringAsArray(string str)
        {
            string[] parts = str.Split(' ');
            int[] nums = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                nums[i] = int.Parse(parts[i]);
            }
            return nums;
        }

        // any method is going to have
        // 1. a name
        // 2. a return value: either nothing (void), or some type e.g. int
            // what result does the method need to send back to the code that uses this method.
        // 3. a list of parameters (maybe empty)
            // does the method need any input from the code that uses it to do its job.
        static string GetInput()
        {
            decimal century = decimal.Ceiling(1905 / 100);
            Console.WriteLine(century);
            Console.WriteLine("Enter a set of numbers seperated with a space: ");
            string input = Console.ReadLine();
            return input;
        }
        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
            // you use "return" to send the return value back to the
            // code that calls this method.
        }
        // method to find first repeating number in array
        static void FindFirstRepeat(int[] arr)
        {
            // initialize the first repeat num
            int min = -1;

            for (int i = arr.Length -1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        min = arr[j];
                    }
                }
            }
            if (min != -1)
            {
                Console.WriteLine("The lowest duplicate is: " + min.ToString());
            }
            else
            {
                Console.WriteLine("The array doesn't contain any duplicate!");
            }
        }
    }
}
