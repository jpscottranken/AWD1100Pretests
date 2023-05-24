using System;
using System.Windows.Forms;

/*
 *	2.	Create C# GUI guessing game GGGUI01 shown below.
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
 *	
 *	Be sure to rename the form, set Accept and 
 *	Cancel buttons, set the Start Position to 
 *	Center Screen. Also set the Tab Order.
 */


namespace Pretest2_2GGGUI
{
    public partial class frmGGGUI : Form
    {
        public frmGGGUI()
        {
            InitializeComponent();
        }

        //  Declare and initialize program constants
        const int MINNUM =   1;
        const int MAXNUM = 100;

        //  Declare and initialize "global" program variables
        Random rand = new Random();
        int number;
        int numGuesses;

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            CreateNewGame();
        }

        private void CreateNewGame()
        {
            number = rand.Next(MINNUM, MAXNUM);
            numGuesses = 0;
            ClearAll();
            ShowMessage("The Random Number Has Been Generated",
                        "THE GAME IS READY!");
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            CheckCurrentGuess();
        }

        private void CheckCurrentGuess()
        {
            bool result;
            bool retVal;
            int theGuess;

            result = Int32.TryParse(txtCurrentGuess.Text, out theGuess);

            if (!result || (theGuess < MINNUM) || (theGuess > MAXNUM))
            {
                ShowMessage("Invalid Guess (Non-Numeric or < 1 or > 100)",
                            "CURRENT GUESS WAS INVALID!");
                
                txtCurrentGuess.Text = "";
                txtCurrentGuess.Focus();

                return;
            }

            //  Guess made was numeric and between 1 - 100
            ++numGuesses;

            //  Check for guess too low
            if (theGuess < number)
            {
                txtGuessStatus.Text = theGuess.ToString() + " WAS TOO LOW";
            }
            //  Check for guess too high
            else if (theGuess > number)
            {
                txtGuessStatus.Text = theGuess.ToString() + " WAS TOO HIGH";
            }
            //  Guess was correct
            else
            {
                txtGuessStatus.Text = theGuess.ToString() + " WAS CORRECT";
                SetAndDisplayRanking();
            }
        }

        private void SetAndDisplayRanking()
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

            txtRanking.Text = rank;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtCurrentGuess.Text = "";
            txtGuessStatus.Text  = "";
            txtRanking.Text      = "";
            txtCurrentGuess.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit The Program?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }

        private void frmGGGUI_Load(object sender, EventArgs e)
        {
            CreateNewGame();
        }
    }
}
