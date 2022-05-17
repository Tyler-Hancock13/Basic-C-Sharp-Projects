using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare 3 string variables and display them using string concatenation
            string message = "My name is ";
            string firstName = "Tyler";
            string lastName = "Hancock";
            Console.WriteLine(message + firstName + " " + lastName);

            //Create a string and using the .ToUpper method, display the text in uppercase
            string uppercase = "This text should be uppercase";
            Console.WriteLine("\n" + uppercase.ToUpper());

            //Initialize a new string builder object and display a paragraph using string builder
            StringBuilder sb = new StringBuilder("\nThe house was located at the top of the hill at the end of winding road. ", 25);
            sb.Append("It wasn't obvious that the house was there, but everyone in town knew that it existed. ");
            sb.Append("They were just all too afraid to ever go and see it in person.");
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
