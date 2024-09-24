using ConsoleApp1;
using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            // Declare variables to store the numbers
            int number1, number2, sum;

            // Prompt the user to enter the first number
            Console.Write("Enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to enter the second number
            Console.Write("Enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            // Add the two numbers
            sum = Addition.Add(number1, number2);

            // Display the result
            Console.WriteLine("The sum of {0} and {1} is {2}.", number1, number2, sum);

            // Ask the user if they want to perform another addition
            Console.Write("Do you want to add another pair of numbers? (y/n): ");
            string response = Console.ReadLine();

            // Exit the loop if the user does not want to continue
            if (response.ToLower() != "y")
            {
                break;
            }
        }
    }
}
