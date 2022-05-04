using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            //Program start
            Console.WriteLine("Academly of Learning Career College \nStudent Daily Report \n \n");

            //Questions
            Console.WriteLine("What course are you in?");
            string course = Console.ReadLine();

            Console.WriteLine("\nWhat page number?");
            ushort pageNumber = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\".");
            bool help = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();

            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("\nHow many hours did you study today?");
            float hours = float.Parse(Console.ReadLine());
            //End of questions

            //Printed after each question has been answered
            Console.WriteLine("\nThank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
