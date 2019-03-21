/*
 * Created by: Tisham Islam
 * Created on: 11/02/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 School Mascot
 * This program displays schools, and their mascots as well. You cna switch between specific schools using the menu items.
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

namespace SchoolMascotTishamI
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void mniImmaculata_Click(object sender, EventArgs e)
        {
            lblSchools.Text = "Immaculata";
            lblMascots.Text = "Saints";
        }

        private void mniStMarks_Click(object sender, EventArgs e)
        {
            lblSchools.Text = "St. Mark's";
            lblMascots.Text = "Pickles";
        }

        private void mniMotherTeresa_Click(object sender, EventArgs e)
        {
            lblSchools.Text = "Mother Teresa";
            lblMascots.Text = "Gucci Gangs";
        }
        
    }
}
