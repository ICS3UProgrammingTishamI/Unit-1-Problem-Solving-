/*
 * Created by: Tisham Islam
 * Created on: 12/02/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 Moving Cat
 * This program displays an image of a cat, that can be changed via the usage of a menu item
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

namespace MovingCatTishamI
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        //This will close the form once the menu item "Exit" is clicked on
        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //These will let you change the cat image, to one or the other image
        private void mniCat1_Click(object sender, EventArgs e)
        {
            this.picCats.Image = Properties.Resources.cat1;
        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            this.picCats.Image = Properties.Resources.cat2;
        }
    }
}
