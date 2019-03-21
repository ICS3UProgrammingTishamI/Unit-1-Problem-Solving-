/*
 * Created by: Tisham Islam
 * Created on: 21/02/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #12 - Pseudocode
 * This program calculates the cost of a pizza when given the diameter of the pizza (in inches)
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

namespace PizzaCostTisham
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
            //You don't need to see the cost yet
            this.lblCalculations.Hide();
        }

        //Variables
        double CostBeforeTaxes;
        double CostAfterTaxes;
        int Diameter;

        //closes the form when the xit menu item is clicked
        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculations_Click(object sender, EventArgs e)
        {
            //takes the diameter from th numeric up down
            Diameter = Convert.ToInt32(nudDiameter.Value);

            //shows the calculation label, and calculates all the costs before creating the string for the label            
            CostBeforeTaxes = 1.75 + 0.5 * Diameter;
            CostAfterTaxes = CostBeforeTaxes * 1.13;
            lblCalculations.Text = "Here is your subtotal: $" + Convert.ToString(CostBeforeTaxes) + " Here is your Total, after taxes: $" + Convert.ToString(Math.Round(CostAfterTaxes, 2));
            this.lblCalculations.Show();
        }
    }
}
