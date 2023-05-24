using System;
using System.Windows.Forms;

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

namespace Pretest1_1
{
    public partial class frmDistanceConverter : Form
    {
        public frmDistanceConverter()
        {
            InitializeComponent();
        }

        //  Declare and initialize program constant
        const int FT_PER_YD = 3;

        //const decimal FT_PER_YD = 3.0M;

        private void btnConvert_Click(object sender, EventArgs e)
        {
            decimal feet  = Convert.ToDecimal(txtInputFeet.Text);
            decimal yards = (decimal)feet / FT_PER_YD;
            //decimal yards = feet / FT_PER_YD;
            string outputStr;

            outputStr = feet.ToString()      + " feet = " + 
                        yards.ToString("n2") + " yards";
            lblAnswer.Text = outputStr;
        }
    }
}
