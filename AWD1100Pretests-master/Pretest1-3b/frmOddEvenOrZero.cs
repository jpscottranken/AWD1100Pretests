using System;
using System.Windows.Forms;

/*
 *      EX1	Write a GUI-based program (call it 
 *      Pretest1-3) that asks the user for a 
 *      number and determines whether the number
 *      is 0, odd, or even (use the modulo 
 *      operator as explained in class):
 */

namespace Pretest1_3b
{
    public partial class frmOddEvenOrZero : Form
    {
        public frmOddEvenOrZero()
        {
            InitializeComponent();
        }

        private void btnShowStatus_Click(object sender, EventArgs e)
        {
            //  Convert contents of textbox to an integer
            //  and store the result in the variable number
            int    number     = Convert.ToInt32(txtInputNumber.Text);

            //  Hold the string that will go into the
            //  lblAnswer label
            string outputStr  = "";

            //  Divide number by 2, keeping the remainder
            //  and putting the remainder into variable result
            int    result     = number % 2;

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

            //  Put result into the lblAnswer label
            lblAnswer.Text = outputStr;
        }
    }
}
