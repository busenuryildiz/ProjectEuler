using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LargestPalindromeProduct
{
    public class Program
    {
        //A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is
        //9009 91 x 99.
        //Find the largest palindrome made from the product of two 3-digit numbers.
        static void Main(string[] args)
        {
            // Initialize a variable to store the largest palindrome
            int largestPalindrome = 0;
            // Check all possible products of two 3-digit numbers
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    // Calculate the product
                    int product = i * j;
                    // Convert the product to a string
                    string productString = product.ToString();
                    // Check if the product is a palindrome
                    if (productString == Reverse(productString))
                    {
                        // If the product is a palindrome and greater than the current largest palindrome, update the largest palindrome
                        if (product > largestPalindrome)
                        {
                            largestPalindrome = product;
                        }
                    }
                }
            }
            // Print the result
            Console.WriteLine("The largest palindrome made from the product of two 3-digit numbers is: " + largestPalindrome);
        }
        // Function to reverse a string
        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
