using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9Tutorials
{
    class Coin
    {
        // field to represent the side facing up.
        private string sideup;

        Random rand = new Random();

        public Coin()
        {
            sideup = "Heads";
        }

        // The toss method simulates the tossing of the coin 
        public void Toss()
        {
            // create a random object

            Random Rand = new Random();


            /* use a random number to determine
             * the side of the coin that is facing up
             * 0 = Heads, 1 = Tails*/

            if (rand.Next(2) == 0)
            {
                sideup = "Heads";
            }

            else
            {
                sideup = "Tails";
            }

        }

        public string getsideup()
        {
            return sideup;
        }


    }
}
