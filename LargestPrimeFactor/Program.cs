namespace LargestPrimeFactor
{
    public class Program
    {
        //The prime factors of 13195 are 5, 7, 13 and 29.
        //What is the largest prime factor of the number 600851475143?
        static void Main(string[] args)
        {
            // Define the number
            long number = 600851475143;
            // Initialize a variable to store the largest prime factor and start with 2
            long largestPrimeFactor = 2;

            // Check numbers from 2 up to the square root of the number
            for (long factor = 2; factor * factor <= number; factor++)
            {
                // If the number is divisible by the factor, store the factor as the largest prime factor and divide the number by the factor
                while (number % factor == 0)
                {
                    largestPrimeFactor = factor;
                    number /= factor;
                }
            }

            // If the number is greater than 1, the remaining number is the largest prime factor
            if (number > 1)
            {
                largestPrimeFactor = number;
            }

            // Print the result
            Console.WriteLine("The largest prime factor of 600851475143 is: " + largestPrimeFactor);

        }
    }
}
