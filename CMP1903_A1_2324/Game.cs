using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

        public Die dice1 = new Die();
        public Die dice2 = new Die();
        public Die dice3 = new Die();

        // Create random seed
        private Random random = new Random();

        public int sum;
        //Methods

        // Method called to start game
        public void GameStart()
        {
            // set sum
            sum = 0;

            // Call Roll dice method and add output to sum
            sum += dice1.RollDice(random);
            sum += dice2.RollDice(random);
            sum += dice3.RollDice(random);

            // Output final sum
            Console.WriteLine("\nSum = " + sum);


        }
    }
}
