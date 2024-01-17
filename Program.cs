using Mission2Assignment;
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!\n");

        Console.WriteLine("How many dice rolls would you like to simulate? ");
        string userInput = System.Console.ReadLine();
     
        int numberOfRolls = int.Parse(userInput);

        RollDice roll = new RollDice();

        int[] gameResults = roll.RollTheDice(numberOfRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numberOfRolls + ".\n\n");

        for (int iCount = 2; iCount <= 12; iCount++)
        {
            int percentage = gameResults[iCount - 2] * 100 / numberOfRolls;
            string totalPercentage = new string('*', percentage);

            Console.WriteLine(iCount + ": " + totalPercentage);

        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");


    }
}

