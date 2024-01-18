// Author: Nya Croft
// Section 004


// Import namespace from RollDice
using Mission2Assignment;

// The main class of the program
public class Program
{
    // The entry point of the program
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!\n");

        // Ask user how mnay rolls and store the value
        Console.WriteLine("How many dice rolls would you like to simulate? ");
        string userInput = System.Console.ReadLine();
        int numberOfRolls = int.Parse(userInput);

        // Create an instance of the RollDice class
        RollDice roll = new RollDice();

        // Call the RollTheDice method to get the dice rolling game results 
        int[] gameResults = roll.RollTheDice(numberOfRolls);

        // Display dice rolling results
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numberOfRolls + ".\n");

        // Loop through the gameResults array
        for (int iCount = 2; iCount <= 12; iCount++)
        {
            // Calculate the percentage each number sum was rolled
            int percentage = gameResults[iCount - 2] * 100 / numberOfRolls;

            // Display histogram using a "*" for each 1% of the total rolls for each number
            string totalPercentage = new string('*', percentage);
            Console.WriteLine(iCount + ": " + totalPercentage);
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

    }
}

