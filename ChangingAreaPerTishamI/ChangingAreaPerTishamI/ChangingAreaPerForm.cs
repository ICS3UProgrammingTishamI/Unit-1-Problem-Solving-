/*
 * Created by: Tisham Islam
 * Created on: 15/02/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 Changing Area and Perimeter
 * This program calculates the area dn perimeter of a rectangle based on the values that you assign to the length and the width of the rectangle. 
 * This program also hides the labels used to show the calculations, revealing them once the calculations have been made
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

namespace ChangingAreaPerTishamI
{
    public partial class frmChangingAreaPer : Form
    {
        public frmChangingAreaPer()
        {
            InitializeComponent();
            //This will hide these two labels when the program starts up
            this.lblAreaCalculations.Hide();
            this.lblPerimeterCalculations.Hide();
        }
        //Variables
        double length, width, area, perimeter;

        //This disables the usage of everything except for numbers, the delete and backspace keys in the text boxes
        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch!= 46)
            {
                e.Handled = true;
            }
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        //This will activate when the button is clicked
        private void btnCalculations_Click(object sender, EventArgs e)
        {
            //This will get the user's inputted values
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            //Calculations are done here for area and perimeter
            area = length * width;
            perimeter = (2 * length) + (2 * width);

            //This will both reveal and change the labels to the results of the calculations
            lblPerimeterCalculations.Text = "The perimeter of the rectangle is " + Convert.ToString(perimeter) + "m in total";
            lblAreaCalculations.Text = "The area of the rectangle is " + Convert.ToString(area) + "m^2 in total";
            this.lblPerimeterCalculations.Show();
            this.lblAreaCalculations.Show();

        }
    }
}
