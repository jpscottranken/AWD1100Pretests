using System;
using System.Runtime.InteropServices;
using static System.Console;

/*
 *	3.	Create C# GUI guessing game GGConsole01,
 *		which is a console version of the previous
 *		program.
 *	
 *	Your program should create a random number between 
 *	1 – 100 (use constants) when the program begins or 
 *	whenever the new game button is clicked. 
 *	
 *	Create whatever variables you want to/need to. 
 *	They can be global or local.
 *	
 *	For Ranking:
 *	
 *	•	5 or fewer guesses 	= EXPERT
 *	•	6 to 10 guesses   	= AVERAGE
 *	•	> 10 guesses       	= NOVICE
 */

namespace Pretest2_3GGConsole
{
    internal class Program
    {
        //  Declare and initialize program constants
        const int MINNUM = 1;
        const int MAXNUM = 100;

        //  Declare and initialize "global" program variables
        static Random rand = new Random();
        static int number;
        static int numGuesses;
        static bool gameOver = false;

        static void Main(string[] args)
        {
            CreateNewGame();

            while (!gameOver)
            {
                MakeTheGuess();
            }
        }

        static void CreateNewGame()
        {
            number = rand.Next(MINNUM, MAXNUM);
            numGuesses = 0;
            WriteLine("\n\nThe Random Number Has Been Generated");

        }

        static void MakeTheGuess()
        {
            Write("Guess The Random Number Between 1 - 100: ");
            string guessStr = ReadLine();
            CheckCurrentGuess(guessStr);
        }

        static void CheckCurrentGuess(string g)
        {
            bool result;
            int theGuess;

            result = Int32.TryParse(g, out theGuess);

            if (!result || (theGuess < MINNUM) || (theGuess > MAXNUM))
            {
                WriteLine("Invalid Guess (Non-Numeric or < 1 or > 100)");

                return;
            }

            //  Guess made was numeric and between 1 - 100
            ++numGuesses;

            //  Check for guess too low
            if (theGuess < number)
            {
                WriteLine(theGuess.ToString() + " WAS TOO LOW");
            }
            //  Check for guess too high
            else if (theGuess > number)
            {
                WriteLine(theGuess.ToString() + " WAS TOO HIGH");
            }
            //  Guess was correct
            else
            {
                WriteLine(theGuess.ToString() + " WAS CORRECT.\n" +
                          "It took you " + numGuesses + " Guesses");
                SetAndDisplayRanking();
            }
        }

        static void SetAndDisplayRanking()
        {
            string rank = "";

            if (numGuesses <= 5)
            {
                rank = "EXPERT";
            }
            else if (numGuesses <= 10)
            {
                rank = "AVERAGE";
            }
            else
            {
                rank = "NOVICE";
            }

            WriteLine("Your rank is: " + rank);

            Write("Do you want to play again (Y / N): ");
            string again = ReadLine().ToUpper();

            if ((again == "Y") || (again == "YES"))
            {
                gameOver = false;
                CreateNewGame();
            }
            else
            {
                gameOver = true;
            }

            ReadLine();
            Clear();
        }
    }
}

