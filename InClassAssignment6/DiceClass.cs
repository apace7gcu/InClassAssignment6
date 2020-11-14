using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Amanda Pace
//Bill Hughes - CST 117
//11/14/2020
//This program is my own work 
//(some source code from class lecture)


namespace InClassAssignment6
{
    class DiceClass
    {
        //Create the properties (variables inside class)
        private int dieSides = 6;

        //Create a constructor for the DiceClass
        public DiceClass(int number, int numDiceSides)
        {
            //Initialize the value of dieSides
            dieSides = numDiceSides;

        }

        /// <summary>
        /// Method to roll the dice
        /// </summary>
        /// <returns></returns>
        public int roleDice()
        {
            //Random Generator
            //Instantiating Random Class and Creating an object called newRandomNumber
            //OR
            //Create an instance of Random

            Random newRandomNumber = new Random();

            //Rolling the dice is creating a random number between
            //1 and the number of sides on the dice.
            int roleDiceNumber = newRandomNumber.Next(1, dieSides + 1);
            return roleDiceNumber;

            //Could also be written like this
            //return newRandomNumber.Next(1, dieSides);

        }
    }
}
