using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SmallestMultiple
{
    public class Program
    {
        //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        //What is the smallest positive number that is evenly divisible by ali of the numbers from 1 to 20?
        static void Main(string[] args)
        {
            // Initialize a variable to store the result
            int result = 1;
            // Initialize a variable to store the maximum number
            int maxNumber = 20;
            // Initialize a variable to store the current number
            int currentNumber = 1;
            // Repeat the process for all numbers from 1 to 20
            while (currentNumber <= maxNumber)
            {
                // If the result is divisible by the current number, increment the current number
                if (result % currentNumber == 0)
                {
                    currentNumber++;
                }
                // If the result is not divisible by the current number, increment the result and reset the current number
                else
                {
                    result++;
                    currentNumber = 1;
                }
            }
            // Print the result
            Console.WriteLine("The smallest positive number that is evenly divisible by all of the numbers from 1 to 20 is: " + result);
        }
    }
}
