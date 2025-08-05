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

            // If consists of uppercase letters
            Console.WriteLine(IfConsistsOfUppercaseLetters("xyz")); // output false
            Console.WriteLine(IfConsistsOfUppercaseLetters("XYZ")); // output true
            Console.WriteLine(IfConsistsOfUppercaseLetters("L9#")); // output false

            // If greater than third one 
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { 2, 7, 12 })); // output true
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { -5, -8, 50 })); // output false

            //If number is even
            Console.WriteLine(IfNumberIsEven(271)); // output false
            Console.WriteLine(IfNumberIsEven(1248)); // output true

            //If sorted ascending 
            Console.WriteLine(IfSortedAscending(new int[] { 3, 7, 10 })); // output true
            Console.WriteLine(IfSortedAscending(new int[] { 74, 62, 99 })); // output false

            // Positive, negative or zero 
            Console.WriteLine(PositiveNegativeOrZero(5.24)); // positive
            Console.WriteLine(PositiveNegativeOrZero(0.0));  // zero
            Console.WriteLine(PositiveNegativeOrZero(-994.53)); // negative

            // If year is leap
            Console.WriteLine(IfYearIsLeap(2016)); // true
            Console.WriteLine(IfYearIsLeap(2018)); // false
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
            // Check if both numbers are divisible by 2 or 3
            bool aDiv = a % 2 == 0 || a % 3 == 0;
            bool bDiv = b % 2 == 0 || b % 3 == 0;
            if (aDiv && bDiv) 
                // If both numbers are divisible by 2 and 3, return their product
            {
                return a * b;
            }
            // If neither number is divisible by 2 or 3, return their sum
            else
            {
                return a + b;
            }
        }

        // If consists of uppercase letters method
        static bool IfConsistsOfUppercaseLetters(string str)
        {
            if (str.Length != 3) return false;
            foreach (char c in str)
            {
                if (!char.IsUpper(c)) return false; 
                    // If any character is not uppercase, return false
            }
            return true;
            // If all characters are uppercase, return true
        }

        // If greater than third one method
        // Checks if multiplication or sum of first two numbers is greater than the third one
        static bool IfGreaterThanThirdOne(int[] arr)
        {
            if (arr.Length != 3) return false;
            int mult = arr[0] * arr[1];
            int sum = arr[0] + arr[1];  
            return mult > arr[2] || sum > arr[2];
        }

        // If number is even method
        static bool IfNumberIsEven(int number)
        {
            // Check if the number is even
            return number % 2 == 0;
        }

        // If sorted ascending method
        static bool IfSortedAscending(int[] arr)
        {
            if (arr.Length != 3) return false; // Ensure the array has exactly 3 elements
            return arr[0] <= arr[1] && arr[1] <= arr[2]; // Check if the array is sorted in ascending order
        }

        // Checks if a number is positive, negative, or zero
        static string PositiveNegativeOrZero(double number)
        {
            if (number > 0) return "positive";
            else if (number < 0) return "negative";
            else return "zero";
        }

        // Checks if a year is a leap year
        static bool IfYearIsLeap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
