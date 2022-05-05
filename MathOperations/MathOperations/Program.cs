using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main()
        {
            //User is prompted to enter a number
            Console.WriteLine("Enter a number to be used in the following math operations");

            //The number the user entered is assigned to the userNumber variable
            int userNumber = Convert.ToInt32(Console.ReadLine());

            //Using userNumber the following math operations are performed
            int resultOne = userNumber * 50;
            int resultTwo = userNumber + 25;
            double resultThree = Convert.ToDouble(userNumber) / 12.5;
            bool resultFour = userNumber > 50;
            double resultFive = Convert.ToDouble(userNumber) % 7;

            //The userNumber value is displayed to the user along with the results
            //of the math operations
            Console.WriteLine("\nYour number is " + userNumber.ToString());
            Console.WriteLine(userNumber.ToString() + " * " + 50 + " = " + resultOne.ToString());
            Console.WriteLine(userNumber.ToString() + " + " + 25 + " = " + resultTwo.ToString());
            Console.WriteLine(userNumber.ToString() + " / " + 12.5 + " = " + resultThree.ToString());
            Console.WriteLine(userNumber.ToString() + " is greater than " + 50 + " = " + resultFour.ToString());
            Console.WriteLine(userNumber.ToString() + " % " + 7 + " = " + resultFive.ToString());

            Console.ReadLine();
        }
    }
}
