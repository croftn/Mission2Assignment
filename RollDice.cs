using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    internal class RollDice
    {
        private Random random;

        public RollDice()
        {
            random = new Random();
        }

        public int[] RollTheDice(int numberOfRolls)
        {
            int[] gameResults = new int[11];
            for (int iCount = 0; iCount < numberOfRolls; iCount++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;

                gameResults[sum - 2]++;
            }

            return gameResults;
        }

    }
}
