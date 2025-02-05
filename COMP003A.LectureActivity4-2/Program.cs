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
            GreetUser(); // Greets user

            Console.Write("Enter the first number: "); // Input 2 numbers and calculate sum
            int num1 = int.Parse(Console.ReadLine()); // Parse user input to integer

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine()); // Parse user input to integer

            int sum = CalculateSum(num1, num2); // Call method and store result
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");

            int[] numbers = { 10, 20, 30, 40, 50 }; // Display the contents and initilize an array
            Console.WriteLine("Array contents: ");
            DisplayArray(numbers); // Call method to print array
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
