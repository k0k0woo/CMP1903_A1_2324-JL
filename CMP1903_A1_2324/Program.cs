using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            // Create game object
            Game game = new Game();

            // Create an endless loop
            while (true)
            {
                Console.WriteLine("###########################\n");

                // Call start game method
                game.GameStart();

                // After game done, tell user how to play again
                Console.WriteLine("\nPress enter to roll again ....");
                // Wait for input
                Console.ReadLine();
            }
        }
    }
}
