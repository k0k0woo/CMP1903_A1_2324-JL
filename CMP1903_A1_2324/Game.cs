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


        // Sum variable
        private int _sum;

        // Number of rolls
        private int _rollNumberOfTimes;

        // Sum calculation
        private double _sumTotal;
        private int _minSum;
        private int _maxSum;
        private double _average;

        // Propeties
        public int sum { get { return _sum; }set { _sum = value; }}
        public int rollNumberOfTimes { get { return _rollNumberOfTimes; }set { _rollNumberOfTimes = value; }}
        public double sumTotal { get { return _sumTotal;}set { _sumTotal = value; }}
        public int minSum { get { return _minSum; }set { _minSum = value; }}
        public int maxSum { get { return _maxSum;}set { _maxSum = value; }}
        public double average { get { return _average; }set { _average = value; }}


        // Methods

        // Method called to start game
        public void GameStart()
        {

            // Ask user for input of how many times wanted to simulate
            Console.WriteLine("Enter times rolled: ");

            string rollNumString = Console.ReadLine();

            // setup integer variable
            int rollNumInt;

            // Check if value is integer
            bool rollNumBool = int.TryParse(rollNumString, out rollNumInt);

            // If success call RollDice()
            if (rollNumBool)
            {
                rollNumberOfTimes = rollNumInt;
                RollDice();
            }
            // Else tell user not a valid input
            else
            { 
                Console.WriteLine("Error value not integer."); 
            }
        }

        private void RollDice()
        {
            // List of sums variable define
            var sumsList = new List<int>();

            // Loop for the number of asked roll times
            for (int count = 1; count < rollNumberOfTimes + 1; count++)
            {
                // Set sum
                sum = 0;

                // Call Roll dice method and add output to sum
                sum += dice1.RollDice();
                sum += dice2.RollDice();
                sum += dice3.RollDice();

                // Add to list
                sumsList.Add(sum);

                // Output final sum

                Console.WriteLine("Roll: " + count + " ||| Dice = " + dice1.Value + " : " + dice2.Value + " : " + dice3.Value + " ||||| Sum = " + sum);
            }

            // Calculate statistics
            StatisticCalc(sumsList.ToArray());

        }

        private void StatisticCalc(int[] sumsList)
        {

            // Variables set
            sumTotal = 0;

            minSum = 0;

            maxSum = 0;

            average = 0;

            // Loop through list of sums

            foreach (int number in sumsList)
            {
                // Add to running total
                sumTotal += number;

                // Check if smallest
                minSum = MinCheck(number);

                // Check if biggest
                maxSum = MaxCheck(number);
            }

            // Calculate average
            average = CalcAverage(sumTotal,sumsList.Length);


            // Output data to terminal
            Console.WriteLine("\nTotal sum: " + sumTotal + "\nHighest sum: " + maxSum + "\nLowest sum: " + minSum + "\nAverage: " + average.ToString("0.00"));
        }

        // Check if number is smaller
        private int MinCheck(int number) 
        {
            // If number is smaller return number
            if (number < minSum || minSum == 0) { return number; }
            // Else return current minsum
            else { return minSum; }
        }

        // Check if number is bigger
        private int MaxCheck(int number) 
        {
            // If number is smaller return number
            if (number > maxSum || maxSum == 0) { return number; }
            // Else return current minsum
            else { return maxSum; }
        }

        // Find mean
        private double CalcAverage(double total,double numElements)
        {
            // Divide total sum by number of sums (calc mean)
            // Convert to a 2 decimal string
            return (total / numElements);
        }
    }
}
