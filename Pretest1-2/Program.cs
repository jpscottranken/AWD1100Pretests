using System;
using static System.Console;

/*
 *      EX1	Write a GUI-based program (call it 
 *      Pretest1-1) that converts distances 
 *      between feet and yards.
 *      
 *      ●	The program must contain a constant named 
 *			FT_PER_YD which holds the number of feet 
 *			per  yard (3 feet = 1 yard).
 *
 *      Create the constant like this:
 *      
 *      const int FT_PER_YD = 3;
 *      
 *      ●	Prompt the user for a distance in feet.
 *      
 *      ●	Once the user presses a button, display 
 *          the  distance in both feet and yards as 
 *          follows: 
 *
 *      "6 feet = 2 yards"
 */

namespace Pretest1_2
{
    internal class Program
    {
        //  Declare and initialize program constant
        const int FT_PER_YD = 3;

        static void Main(string[] args)
        {
            //  Declare program variables
            decimal feet;
            decimal yards;
            string outputStr;

            //  Input feet
            Write("Please enter feet: ");
            feet = Convert.ToDecimal(Console.ReadLine());

            //  Do feet to yards calculation
            yards = feet / FT_PER_YD;

            //  Prepare output
            outputStr = feet.ToString() + " feet = " +
                        yards.ToString("n2") + " yards";

            //  Display output
            WriteLine("\n" + outputStr);

            ReadLine();
        }
    }
}
