using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");

            //Person 1 enters their hourly rate and weekly hours
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            decimal personOneRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            sbyte personOneHours = Convert.ToSByte(Console.ReadLine());

            //Person 2 enters their hourly rate and weekly hours
            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Hourly Rate?");
            decimal personTwoRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            sbyte personTwoHours = Convert.ToSByte(Console.ReadLine());

            //Users hourly rate and weekly hours are multiplied, then multiplied by 52
            decimal personOneSalary = (personOneRate * personOneHours) * 52;
            decimal personTwoSalary = (personTwoRate * personTwoHours) * 52;

            //Create a bool that compares if Person 1's annual salary is greater than Person 2
            bool personOneComparison;

            if(personOneSalary > personTwoSalary)
            {
                personOneComparison = true;
            }
            else
            {
                personOneComparison = false;
            }

            //Display results to user
            Console.WriteLine("\nAnnual salary of Person 1:\n" + personOneSalary.ToString());
            Console.WriteLine("\nAnnual salary of Person 2:\n" + personTwoSalary.ToString());
            Console.WriteLine("\nPerson 1 makes more money than Person 2\n" + personOneComparison.ToString());
            Console.ReadLine();
        }
    }
}
