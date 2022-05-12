using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceQuoteApplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

            //The user enters their packages weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            //If the user entered a weight above 50, they will receive a message it is too large and the program will end
            if(weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //The user enters the package width, height length
            Console.WriteLine("\nPlease enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            int dimensionSum = length + width + height;

            //If the sum of the dimensions entered by the user is greater than 50
            //Display a message and end the program
            if (dimensionSum > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //The length, width and height are multiplied
            //Result is assigned to packageDimensions
            int packageDimensions = length * width * height;

            //The priceQuote value is assigned by multiplying packageDimensions and the weight. That result is then divided by 100
            decimal priceQuote = (packageDimensions * weight) / 100;

            //Display the price quote to the user using currency formatting
            Console.WriteLine("\nYour estimated total for shipping this package is: " + priceQuote.ToString("c") + "\nThank you.");
            Console.ReadLine();
        }
    }
}
