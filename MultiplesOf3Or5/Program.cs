using System.Collections.Generic;

namespace MultiplesOf3Or5
{
    internal class Program
    {
        //İf we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000.
        static void Main(string[] args)
        {
            int sum = 0;

            // Loop through numbers from 1 to 999
            for (int i = 1; i < 1000; i++)
            {
                // If the number is a multiple of 3 or 5, add it to the sum
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            // Print the result
            Console.WriteLine("The sum of all multiples of 3 or 5 below 1000 is: " + sum);

        }
    }
}
