using System;
using static System.Console;

/*
 *      EX1	Write a GUI-based program (call it 
 *      Pretest1-3) that asks the user for a 
 *      number and determines whether the number
 *      is 0, odd, or even (use the modulo 
 *      operator as explained in class):
 */

namespace Pretest1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  number to input
            int number = 0;

            //  Input a number
            Write("Input any whole number: ");
            number = Convert.ToInt32(Console.ReadLine());

            //  Hold the string that will go into answer
            string outputStr = "";

            //  Divide number by 2, keeping the remainder
            //  and putting the remainder into variable result
            int result = number % 2;

            //  Check for 0 (not odd, not even)
            if (number == 0)
            {
                outputStr = "0 is neither even nor odd";
            }
            //  Check for odd # (result = 1)
            else if (result == 1)
            {
                outputStr = "The number " + number.ToString() +
                            " is an odd #";
            }
            //  Check for even # (result = 0)
            else if (result == 0)
            {
                outputStr = "The number " + number.ToString() +
                            " is an even #";
            }

            //  Display output
            WriteLine("\n" + outputStr);

            ReadLine();
        }
    }
}
