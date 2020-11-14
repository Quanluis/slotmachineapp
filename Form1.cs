﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slotmachineapp
{
    public partial class currencyLabel : Form
    {

        public currencyLabel()
        {
            InitializeComponent();
        }

        double money;

        int firstSpin, secondSpin, thirdSpin;
           

        private void playButton_Click(object sender, EventArgs e)
        {

            money = double.Parse(countLabel.Text);

            if (money > 0)
            {
                spinButton.Enabled = true;
                countLabel.ReadOnly = true;
                playButton.Enabled = false;

            } else
            {
                MessageBox.Show("Please insert currency.");

            }

        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            firstSpin = rnd.Next(1, 11);
            secondSpin = rnd.Next(1, 11);
            thirdSpin = rnd.Next(1, 11);
            

            // Spin one

            if (firstSpin == 1)
            {
                rollOne.Image = Properties.Resources.Apple;
            }
            else if (firstSpin == 2)
            {
                rollOne.Image = Properties.Resources.Banana;
            }
            else if (firstSpin == 3)
            {
                rollOne.Image = Properties.Resources.Cherries;
            }
            else if (firstSpin == 4)
            {
                rollOne.Image = Properties.Resources.Grapes;
            }
            else if (firstSpin == 5)
            {
                rollOne.Image = Properties.Resources.Lemon;
            }
            else if (firstSpin == 6)
            {
                rollOne.Image = Properties.Resources.Lime;
            }
            else if (firstSpin == 7)
            {
                rollOne.Image = Properties.Resources.Orange;
            }
            else if (firstSpin == 8)
            {
                rollOne.Image = Properties.Resources.Pear;
            }
            else if (firstSpin == 9)
            {
                rollOne.Image = Properties.Resources.Strawberry;
            }
            else if (firstSpin == 10)
            {
                rollOne.Image = Properties.Resources.Watermelon;
            }

            // Spin two


            if (secondSpin == 1)
            {
                rollTwo.Image = Properties.Resources.Apple;
            }
            else if (secondSpin == 2)
            {
                rollTwo.Image = Properties.Resources.Banana;
            }
            else if (secondSpin == 3)
            {
                rollTwo.Image = Properties.Resources.Cherries;
            }
            else if (secondSpin == 4)
            {
                rollTwo.Image = Properties.Resources.Grapes;
            }
            else if (secondSpin == 5)
            {
                rollTwo.Image = Properties.Resources.Lemon;
            }
            else if (secondSpin == 6)
            {
                rollTwo.Image = Properties.Resources.Lime;
            }
            else if (secondSpin == 7)
            {
                rollTwo.Image = Properties.Resources.Orange;
            }
            else if (secondSpin == 8)
            {
                rollTwo.Image = Properties.Resources.Pear;
            }
            else if (secondSpin == 9)
            {
                rollTwo.Image = Properties.Resources.Strawberry;
            }
            else if (secondSpin == 10)
            {
                rollTwo.Image = Properties.Resources.Watermelon;
            }

            // Spin three

            if (thirdSpin == 1)
            {
                rollThree.Image = Properties.Resources.Apple;
            }
            else if (thirdSpin == 2)
            {
                rollThree.Image = Properties.Resources.Banana;
            }
            else if (thirdSpin == 3)
            {
                rollThree.Image = Properties.Resources.Cherries;
            }
            else if (thirdSpin == 4)
            {
                rollThree.Image = Properties.Resources.Grapes;
            }
            else if (thirdSpin == 5)
            {
                rollThree.Image = Properties.Resources.Lemon;
            }
            else if (thirdSpin == 6)
            {
                rollThree.Image = Properties.Resources.Lime;
            }
            else if (thirdSpin == 7)
            {
                rollThree.Image = Properties.Resources.Orange;
            }
            else if (thirdSpin == 8)
            {
                rollThree.Image = Properties.Resources.Pear;
            }
            else if (thirdSpin == 9)
            {
                rollThree.Image = Properties.Resources.Strawberry;
            }
            else if (thirdSpin == 10)
            {
                rollThree.Image = Properties.Resources.Watermelon;
            }

        }
    }
}
