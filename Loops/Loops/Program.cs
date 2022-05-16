using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare i as a counter variable and num variable as the current number
            int i = 0;
            int num = 1;

            //While i is less than 10 execute the switch statement
            while (i < 10)
            {

                switch (num)
                {
                    //If num equals 0 execute the code below
                    case 0:
                        Console.WriteLine(num);
                        break;
                    
                    //Print the other numbers to the console
                    default:
                        Console.WriteLine(num);
                        break;
                }

                //Increment the num and i variables for the next iteration
                num++;
                i++;
            }
            Console.WriteLine("\n");


            //Using a do while loop the variable j will print to the console
            //and decrement by 1 while it is greater than -1
            int j = 5;
            do
            {
                Console.WriteLine(j);
                j--;
            }
            while (j > -1);

            Console.Read();

            
            
        }
    }
}
