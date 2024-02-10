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

        private Die dice1 = new Die();
        private Die dice2 = new Die();
        private Die dice3 = new Die();
        //Methods

        public void GameRoll()
        {
            int sum;
            dice1.RollDice();
            Console.WriteLine("Die 1: " + dice1.Value);
            sum = dice1.Value;

            dice2.RollDice();
            Console.WriteLine("Die 2: " + dice2.Value);
            sum += dice2.Value;

            dice3.RollDice();
            Console.WriteLine("Die 3: " + dice3.Value);
            sum += dice3.Value;

            Console.WriteLine("Sum = " + sum);
        }
    }
}
