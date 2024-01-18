// Author: Nya Croft
// Section 004


// Import namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Define namespace
namespace Mission2Assignment
{
    // Declare class
    internal class RollDice
    {
        // Holds a random instance for dice rolling
        private Random random;

        // RollDice class constructor
        public RollDice()
        {
            // Initialize the random instance
            random = new Random();
        }

        // Method to simulate rolling the dice a specific number of times based on the user input 
        public int[] RollTheDice(int numberOfRolls)
        {
            // Array to store the results of each possible dice roll sum
            int[] gameResults = new int[11];

            // Loop simulates each dice roll
            for (int iCount = 0; iCount < numberOfRolls; iCount++)
            {
                // Generate random values between 1 and 6 (two 6-sided dice)
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                // Calculate the sum of the two dice
                int sum = dice1 + dice2;

                // Increment the corresponding position in the array based on the sum 
                gameResults[sum - 2]++;
            }

            // Return the array containing the results of the dice rolls
            return gameResults;
        }

    }
}
