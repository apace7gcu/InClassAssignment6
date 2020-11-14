using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Amanda Pace
//Bill Hughes - CST 117
//11/14/2020
//This program is my own work 
//(some source code from class lecture)


namespace InClassAssignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method to roll the dice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnRollDice_Click(object sender, EventArgs e)
        {
           
            //Now we need to role the dice until we get the snake eyes and then report
            //the number of roles it took.
            //First Define our Variables

            int rolesDice1 = 0, rolesDice2 = 0;
            int roleCounter = 0;
            int sendNumber = 20;
            int defineSides = 6;

            do
            {

                //Now let's create dice objects
                DiceClass dice1 = new DiceClass(sendNumber, defineSides);

                //Now Roll the dice and get back the face value
                rolesDice1 = dice1.roleDice();

                //Put this value in the label
                lblDice1.Text = rolesDice1.ToString();

                //When creating a Random instance it's sending with the current time. So if
                //you create several of them at the same time they generate
                //the same random number sequence.

                //Stalls system for fraction of a second, so two numbers will be generated.
                System.Threading.Thread.Sleep(100);

                //Same for second dice
                DiceClass dice2 = new DiceClass(sendNumber, defineSides);

                rolesDice2 = dice2.roleDice();

                lblDice2.Text = rolesDice2.ToString();

                roleCounter++;
            }

            while (rolesDice1 != 1 || rolesDice2 != 1);

            MessageBox.Show("It took " + roleCounter + " rolls to get snake eyes.");
           
            

        }
    }
}
