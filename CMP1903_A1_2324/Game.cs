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


        // sum variable
        private int _sum;

        //propeties
        public int sum { get { return _sum; }set { _sum = value; }}


        //Methods

        // Method called to start game
        public void GameStart()
        {
            Console.WriteLine("Enter times rolled: ");

            string RollNumString = Console.ReadLine();

            int RollNumInt;

            bool RollNumBool = int.TryParse(RollNumString, out RollNumInt);

            if (RollNumBool)
            {
                RollDice(RollNumInt);
            }
            else
            { 
                Console.WriteLine("Error value not integer."); 
            }
        }

        public void RollDice(int RollNum)
        {
            var sumsList = new List<int>();
            for (int i = 1; i < RollNum+1; i++)
            {
                // set sum
                sum = 0;

                // Call Roll dice method and add output to sum
                sum += dice1.RollDice();
                sum += dice2.RollDice();
                sum += dice3.RollDice();

                sumsList.Add(sum);
                // Output final sum
                Console.WriteLine("\nRoll: " + i + " Sum = " + sum);
            }
            sumsList.ToArray();
            int total = 0;
            int minSum = 0;
            int maxSum = 0;
            double average;
            foreach (int number in sumsList)
            {
                total += number;
                if(number < minSum || minSum == 0) minSum = number;
                if(number > maxSum || maxSum == 0) maxSum = number;
            }

            average = (total / sumsList.Count);
            Console.WriteLine("\nTotal sum: " + total + "\nHighest sum: " + maxSum + "\nLowest sum: " + minSum + "\nAverage: " + average);
        }
    }
}
