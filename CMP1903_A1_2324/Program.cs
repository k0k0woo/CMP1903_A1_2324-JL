using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            //Create testing for debugging
            Testing testing = new Testing();

            // Create an endless loop
            while (true)
            {
                Console.WriteLine("###########################\n");

                // Call start game method
                game.GameStart();

                // Run test
                testing.Test(game);

            }
        }
    }
}
