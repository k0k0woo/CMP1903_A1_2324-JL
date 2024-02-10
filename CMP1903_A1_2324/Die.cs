using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        private int _Value;

        //Property
        public int Value { get { return _Value; } set { _Value = value; } }


        Random random = new Random();
        //Method

        public void RollDice() 
        {
            Value = random.Next(1,6);
        }

    }
}
