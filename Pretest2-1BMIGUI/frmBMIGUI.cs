using System;
using System.Windows.Forms;

/*	
 *	1.	Body Mass Index (BMI) is a person's weight 
 *		in pounds divided by the square of their 
 *		height in inches. 
 *	
 *	The BMI ranges are shown below:
 *	
 *	bmi < 18.5					Underweight
 *	bmi >=  18.5 && < 25.0		Optimal weight
 *	bmi >=  25.0 && < 30.0		Overweight
 *	bmi >=  30.0				Obese
 *	
 *	Based on these statistics, create C# GUI app 
 *	BMIGUI01 shown. At a minimum, include the 
 *	following constants (you may create additional
 *	 if/as desired):
 *	
 *	const int MINHEIGHT =  12;
 *	const int MAXHEIGHT =  96;
 *	const int MINWEIGHT =   1;
 *	const int MAXHEIGHT = 777;
 *
 *	Create the following global program variables:
 *	
 *	int totalUnderweights 	= 0;
 *	int totalOptimalweights = 0;
 *	int totalOverweights   	= 0;
 *	int totalObese       	= 0;
 *	
 *	Any/all other variables must be local/passed
 *	into the following methods:
 *	
 *	•	ValidateHeight()
 *	•	ValidateWeight()
 *	•	CalculateBM()
 *	•	CalculateBMIStatus()
 *	•	UpdateTextBoxes()
 *	
 *	Be sure to rename the form, set Accept and
 *	Cancel buttons, set the Start Position to 
 *	Center Screen. Also set the Tab Order.
 */

namespace Pretest2_1BMIGUI
{
    public partial class frmBMIGUI : Form
    {
        public frmBMIGUI()
        {
            InitializeComponent();
        }

        //  Declare and initialize program constants
        const int MINHEIGHT   =  12;
        const int MAXHEIGHT   =  96;
        const int MINWEIGHT   =   1;
        const int MAXWEIGHT   = 777;
        const double MINOPT   =  18.5;
        const double MINOVER  =  25.0;
        const double MINOBESE =  30.0;

        //  Declare and initialize "global" program variables
        int totalUnderweights   = 0;
        int totalOptimalWeights = 0;
        int totalOverweights    = 0;
        int totalObese          = 0;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //  Declare local program variables
            int height;
            int weight;
            double bmi;
            string bmiStatus;

            bool keepGoing = ValidateHeight(out height);

            if (keepGoing)  //  Valid height inputted
            {
                keepGoing = ValidateWeight(out weight);
            }
            else
            {
                return;
            }

            if (keepGoing)  //  Valid weight inputted
            {
                //  Calculate BMI
                bmi = CalculateBMI(height, weight);

                //  Display BMI
                txtBMI.Text = bmi.ToString("n2");

                //  Calculate BMI Status
                bmiStatus = CalculateBMIStatus(bmi);

                //  Display BMI Status
                txtBMIStatus.Text = bmiStatus;

                //  Update associated textboxes
                UpdateTextBoxes();
            }
            else
            {
                return;
            }
        }

        private bool ValidateHeight(out int h )
        {
            bool result;
            bool retVal = true;

            //  Validate that inputted height is numeric
            result = Int32.TryParse(txtHeight.Text, out h );
            if (!result)
            {
                ShowMessage("Height Must Be Between 12 - 96",
                            "NON-NUMERIC-HEIGHT INPUTTED");

                txtHeight.Text = "";
                txtHeight.Focus();

                retVal = false;
            }
            //  Validate that inputted height is within range (12 - 96)
            else if ((h < MINHEIGHT) || (h > MAXHEIGHT))
            {
                ShowMessage("Height Must Be Between 12 - 96",
                            "OUT-OF-RANGE HEIGHT INPUTTED");

                txtHeight.Text = "";
                txtHeight.Focus();

                retVal = false;
            }

            return retVal;
        }

        private bool ValidateWeight(out int w)
        {
            bool result;
            bool retVal = true;

            //  Validate that inputted weight is numeric
            result = Int32.TryParse(txtWeight.Text, out w);
            if (!result)
            {
                ShowMessage("Weight Must Be Between 1 - 777",
                            "NON-NUMERIC-WEIGHT INPUTTED");

                txtWeight.Text = "";
                txtWeight.Focus();

                retVal = false;
            }
            //  Validate that inputted weight is within range (1 - 777)
            else if ((w < MINWEIGHT) || (w > MAXWEIGHT))
            {
                ShowMessage("Weight Must Be Between 1 - 777",
                            "OUT-OF-RANGE WEIGHT INPUTTED");

                txtWeight.Text = "";
                txtWeight.Focus();

                retVal = false;
            }

            return retVal;
        }

        private double CalculateBMI(double h, double w)
        {
            return ((double)703 * w / (Math.Pow(h, 2)));
        }

        private string CalculateBMIStatus(double bmi)
        {
            string theStatus = "";

            if (bmi < MINOPT)           //  bmi < 18.5
            {
                theStatus = "UNDERWEIGHT";
                ++totalUnderweights;
            }
            else if (bmi < MINOVER)     //  bmi >= 18.5 && < 25.0
            {
                theStatus = "OPTIMAL";
                ++totalOptimalWeights;
            }
            else if (bmi < MINOBESE)    //  bmi >= 25.0 && < 30.0
            {
                theStatus = "OVERWEIGHT";
                ++totalOverweights;
            }
            else
            {                           //  bmi >= 30
                theStatus = "OBESE";
                ++totalObese;
            }

            return theStatus;
        }

        private void UpdateTextBoxes()
        {
            txtTotalUnders.Text  = totalUnderweights.ToString();
            txtTotalOptimal.Text = totalOptimalWeights.ToString();
            txtTotalOvers.Text   = totalOverweights.ToString();
            txtTotalObese.Text   = totalObese.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtHeight.Text    = "";
            txtWeight.Text    = "";
            txtBMI.Text       = "";
            txtBMIStatus.Text = "";
            txtHeight.Focus();
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
    }
}
