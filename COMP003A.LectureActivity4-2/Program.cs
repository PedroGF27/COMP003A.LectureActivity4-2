// Pedro Garcia
// COMP003A
// Johnathan Cruz
// Practice implementing methods in C#
namespace COMP003A.LectureActivity4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        /// <summary>
        /// Greets the user by their name
        /// </summary>
        static void GreetUser()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine(); // store user input in {name}
            Console.WriteLine($"Hello, {name}! Welcome to the Methods Activity!");
        }
        /// <summary>
        /// Calculate sum of 2 numbers and returns result
        /// </summary>
        /// <param name="num1">Integer 1</param>
        /// <param name="num2">Integer 2</param>
        /// <returns></returns>
        static int CalculateSum(int num1, int num2)
        {
            return num1 + num2; // Add 2 numbers and return result
        }
        /// <summary>
        /// Display contents of array.
        /// </summary>
        /// <param name="numbers">Array collection of integers</param>
        static void DisplayArray(int[] numbers)
        {
            foreach (int num in numbers) // loop through array
            {
                Console.WriteLine(num); // Print each number
            }
        }
    }
}
