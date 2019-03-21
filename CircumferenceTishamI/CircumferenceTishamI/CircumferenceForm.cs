/*
 * Created by: Tisham Islam
 * Created on: 20/02/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Circumference
 * This program calculates the circumference of a circle based on user input for the radius
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircumferenceTishamI
{
    public partial class frmCircumference : Form
    {
        public frmCircumference()
        {
            InitializeComponent();
            //Hides the calculations until something shows the calculations
            this.lblCalculations.Hide();
        }

        //Here's our variable and constant
        const double PI = Math.PI;
        double Radius;

        //This closes the program if you get tired of calulating circumferences when you click on the exit menu item
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This prevents the usage of anything other than digits and backspaces
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //english translation: if the charcter inputted is not a digit, backspace or the delete key, then the character will not be accepted
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnCalculations_Click(object sender, EventArgs e)
        {
            //Gets the user input for the radius
            Radius = double.Parse(txtInput.Text);
            //shows the text for the calculations
            this.lblCalculations.Show();
            //Both calculates and shows the circumference of the circle
            lblCalculations.Text = "The circumference of this circle is " + Convert.ToString(Math.Round(2 * PI * Radius, 2)) + " cm";
        }
    }
}
