using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        public void Test(Game game)
        {
				Console.WriteLine("###########################\n");

				// Notify if dice roll incorrect
				Debug.Assert(game.dice1.Value > 1 || game.dice1.Value < 6);
				Debug.Assert(game.dice2.Value > 1 || game.dice2.Value < 6);
				Debug.Assert(game.dice3.Value > 1 || game.dice3.Value < 6);

				// Check if sum is correct
				Debug.Assert(game.sum == (game.dice1.Value + game.dice2.Value + game.dice3.Value));
				
				// After game done, tell user how to play again
				Console.WriteLine("\nDebug....\n\nPress enter to roll again...");
				// Wait for input
				Console.ReadLine();
        }
    }
}
