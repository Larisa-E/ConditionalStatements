using System.Xml;

namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Absolute value
            Console.WriteLine(AbsoluteValue(6831)); //output 6832
            Console.WriteLine(AbsoluteValue(-392)); // output 392

            // Divisible by 2 or 3 
            Console.WriteLine(DivisibleBy2Or3(15, 30)); // output 450
            Console.WriteLine(DivisibleBy2Or3(2, 90)); // output 180
            Console.WriteLine(DivisibleBy2Or3(7, 12)); // output 19

        }

        // Absolute value method 
        static int AbsoluteValue(int number)
        {
            // If number is less than 0, return its negation, else return the number itsel
            return number < 0 ? -number : number;
        }

        // Divisible by 2 or 3 method
        static int DivisibleBy2Or3(int a, int b)
        {
            // If both numbers are divisible by 2 and 3, return their product
            if (a % 2 == 0 && a % 3 == 0 && b % 2 == 0 && b % 3 == 0)
            {
                return a * b;
            }
            // If only one of the numbers is divisible by 2 or 3, return their sum
            else if (a % 2 == 0 || a % 3 == 0 || b % 2 == 0 || b % 3 == 0)
            {
                return a + b;
            }
            // If neither number is divisible by 2 or 3, return their sum
            else
            {
                return a + b;
            }
        }
    }
}
