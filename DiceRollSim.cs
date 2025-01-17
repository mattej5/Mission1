using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission1
{
    internal class DiceRollSim
    {
        public static int[] DiceRollMethod(int DiceRolls)
        {
            // Second class method simulates rolls
            // also stores results in an array and returns array
            int[] results = new int[11];
            Random rnd = new Random();

            for (int i = 0; i < DiceRolls; i++)
            {
                int dice1 = rnd.Next(1, 7); // Produces random num between 1 and 6
                int dice2 = rnd.Next(1, 7); // Produces random num between 1 and 6
                int diceSum = dice1 + dice2;
                results[diceSum - 2]++;
            }

            return results;
        }
    }
}
