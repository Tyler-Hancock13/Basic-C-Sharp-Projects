using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //User enters age
            Console.WriteLine("What is your age?");
            sbyte age = Convert.ToSByte(Console.ReadLine());

            //User uses true/false to enter if they have had a DUI
            Console.WriteLine("\nHave you ever had a DUI?");
            bool hadDUI = Convert.ToBoolean(Console.ReadLine());

            //User enters how many speeding tickets they have
            Console.WriteLine("\nHow many speeding tickets do you have?");
            sbyte tickets = Convert.ToSByte(Console.ReadLine());

            //Create a boolean variable to determine whether the user has qualified or not
            bool qualified;

            //If the users age is greater than 15 AND they have never had a DUI AND they have had no more than 3 tickets
            //This will set the value of qualified to true, otherwise false
            if(age > 15 && hadDUI == false && tickets <= 3)
            {
                qualified = true;
            }
            else
            {
                qualified = false;
            }

            //Display in the console whether the user has qualified or not
            Console.WriteLine("\nQualified?\n" + qualified);
            Console.ReadLine();
        }
    }
}
