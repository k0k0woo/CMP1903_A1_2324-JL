using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        // Create Die

        private Die dice1 = new Die();
        private Die dice2 = new Die();
        private Die dice3 = new Die();

        // Create random seed
        private Random random = new Random();


        //Methods

        // Method called to start game
        public void GameStart()
        {
            // set sum
            int sum = 0;

            // Call Roll dice method and add output to sum
            sum += CallDiceRoll(dice1, random);
            sum += CallDiceRoll(dice2, random);
            sum += CallDiceRoll(dice3, random);

            // Output final sum
            Console.WriteLine("\nSum = " + sum);
        }

        // Method to roll die
        static int CallDiceRoll(Die die,Random random)
        {
            // Call dice method to roll with input of random seed
            die.RollDice(random);

            // Output die roll to terminal
            Console.WriteLine("Die rolled =  " + die.Value);

            // return roll value
            return die.Value;
        }
    }
}
